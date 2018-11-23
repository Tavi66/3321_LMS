using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Diagnostics;

namespace LMS
{
    class LMS_Db_Connection
    {
        private static LMS_Db_Connection instance = null;
        private bool authenticated;
        private int userID;
        private String givenName;
        private String familyName;
        private int userRole;
        private int userYear;

        private Exception ex;

        SqlConnection dbConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
                                                   
        SqlCommand dbCmd;
        SqlDataReader dbDr;

        private LMS_Db_Connection()
        {

        }
        public bool Authenticated
        {
            get
            {
                return authenticated;
            }
        }

        public int UserID
        {
            get
            {
                if (authenticated) return userID;
                return 0;
            }
        }
        public int UserRole
        {
            get
            {
                if (authenticated) return userRole;
                return 0;
            }
        }
        public int UserYear
        {
            get
            {
                if (authenticated) return userYear;
                return 0;
            }
        }
        public String GivenName
        {
            get
            {
                if (authenticated) return givenName;
                return String.Empty;
            }
        }
        public String FamilyName
        {
            get
            {
                if (authenticated) return familyName;
                return String.Empty;
            }
        }
        public Exception Ex
        {
            get
            {
                return ex;
            }
        }

        public static LMS_Db_Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LMS_Db_Connection();
                }
                return instance;
            }
        }
        public bool authenticateUser(String userName, String password)
        {
            bool authenticated = false;
            dbConn.Open();
            try
            {
                dbCmd = new SqlCommand("SELECT Id, Enabled, [Given Name], [Family Name], Year, Role FROM Users WHERE UserName='" + userName + "' AND Password ='" + password + "'", dbConn);
                dbDr = dbCmd.ExecuteReader();
                dbDr.Read();
                authenticated = (bool)dbDr[1];
                this.authenticated = false;
                if (authenticated)
                {
                    this.authenticated = true;
                    this.userID = (int)dbDr[0];
                    this.givenName = dbDr[2].ToString();
                    this.familyName = dbDr[3].ToString();
                    if (!dbDr[4].ToString().Equals(String.Empty))
                    {
                        this.userYear = (int)dbDr[4];
                    }
                    else
                    {
                        this.userYear = 0;
                    }
                    this.userRole = (int)dbDr[5];
                }
            }
            catch (Exception ex)
            {
                this.ex = ex;
                Debug.WriteLine(ex.ToString());
            }
            dbConn.Close();
            return authenticated;
        }
        public DataSet getEligibleClasses()
        {
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Id, Name FROM Courses WHERE Year='" + this.userYear + "'", dbConn);
            SqlDataAdapter DA = new SqlDataAdapter(dbCmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            try
            {
                dbCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.ex = ex;
                DS = null;
            }
            dbConn.Close();
            return DS;
        }

        public DataSet getUsers()
        {
            DataSet DS = null;
            if (authenticated && userRole <= 2)
            {
                dbConn.Open();
                dbCmd = new SqlCommand("SELECT Users.Id, Users.Enabled, Users.UserName, Users.[Given Name], Users.[Family Name], Users.Year, Roles.[Desc] FROM Users, Roles WHERE Roles.Id=Users.Role", dbConn);
                SqlDataAdapter DA = new SqlDataAdapter(dbCmd);
                DS = new DataSet();
                DA.Fill(DS);
                try
                {
                    dbCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    this.ex = ex;
                    DS = null;
                }
                dbConn.Close();
            }
            return DS;
        }
        public void Enroll_Course(int courseID)
        {
            if (authenticated && userRole == 4)
            {
                dbCmd = new SqlCommand("Enroll_Course_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@userID", this.userID);
                dbCmd.Parameters.AddWithValue("@courseID", courseID);
                dbConn.Open();
                try
                {
                    dbCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                dbConn.Close();
            }
        }

        public void Add_User(int Id, String UserName, String Password, String GivenName, String FamilyName, int Year, int Role)
        {
            if (authenticated && userRole <= 2)
            {
                dbCmd = new SqlCommand("Add_User_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@Id", Id);
                dbCmd.Parameters.AddWithValue("@UserName", UserName);
                dbCmd.Parameters.AddWithValue("@Password", UserName);
                dbCmd.Parameters.AddWithValue("@GivenName", UserName);
                dbCmd.Parameters.AddWithValue("@FamilyName", UserName);
                if (Role != 4)
                {
                    dbCmd.Parameters.AddWithValue("@Year", DBNull.Value);
                    dbCmd.Parameters["@Year"].IsNullable = true;
                }
                else
                {
                    dbCmd.Parameters.AddWithValue("@Year", Year);
                }
                dbCmd.Parameters.AddWithValue("@Role", Role);
                dbConn.Open();
                try
                {
                    dbCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                dbConn.Close();
            }
        }
        public int getNextUserId(int Role)
        {
            int lastUserId;
            dbCmd = new SqlCommand("SELECT Id FROM Users WHERE Id like '900" + Role + "%' ORDER BY Id DESC", dbConn);
            dbConn.Open();
            dbDr = dbCmd.ExecuteReader();
            dbDr.Read();
            
            if (int.TryParse(dbDr[0].ToString(), out lastUserId))
            {
                dbConn.Close();
                return lastUserId+1;
            }
            dbConn.Close();
            return -1;  
        }
        public DataSet getEnrolledCourses()
        {
            DataSet DS = null;
            if (authenticated && userRole == 4)
            {
                dbConn.Open();
                dbCmd = new SqlCommand("Select Enrollments.courseId, Courses.Name from Enrollments, Courses WHERE userId='" +this.userID+"' and Courses.Id=Enrollments.CourseId", dbConn);
                SqlDataAdapter DA = new SqlDataAdapter(dbCmd);
                DS = new DataSet();
                DA.Fill(DS);
                try
                {
                    dbCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    this.ex = ex;
                    DS = null;
                }
                dbConn.Close();
            }

            return DS;
        }
    }
}
