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
                Debug.WriteLine(userName + " " + password);
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
                dbCmd = new SqlCommand("SELECT Id, Enabled, UserName, [Given Name], [Family Name], Year, Role FROM Users", dbConn);
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
