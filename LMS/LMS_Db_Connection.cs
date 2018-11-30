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

        public void DeleteAssignment(int assignmentID)
        {
            //to do: in database, have delete row operation trigger a delete on grades table as well, if same assignment ID is present
            if (authenticated && userRole == 3)
            {
                dbCmd = new SqlCommand("Delete_Assignment_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@Id", assignmentID);
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

        public void TurnInAssignment(int assignmentID)
        {
            Debug.WriteLine("Turning in assignment " + assignmentID);
            if (authenticated && userRole == 4 && !AssignmentTurnedIn(assignmentID))
            {
                dbCmd = new SqlCommand("TurnIn_Assignment_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@AssignmentId", assignmentID);
                dbCmd.Parameters.AddWithValue("@UserId", this.UserID);
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
        public bool AssignmentTurnedIn(int assignmentID)
        {
            return AssignmentTurnedIn(assignmentID, this.UserID);
        }

        public bool AssignmentTurnedIn(int assignmentID, int userID)
        {
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Grade FROM Grades WHERE AssignmentId='" + assignmentID + "' AND UserId='" + userID + "'", dbConn);
            dbDr = dbCmd.ExecuteReader();
            if (dbDr.Read())
            {
                Debug.WriteLine("Checking if " + assignmentID + " turned in for " + userID + " =" + dbDr[0]);
                dbConn.Close();
                return true;
            }
            dbConn.Close();
            return false;
        }

        public bool AssignmentGraded(int assignmentID)
        {
            return AssignmentGraded(assignmentID, this.userID);
        }

        public bool AssignmentGraded(int assignmentID, int userId)
        {
            int grade;
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Grade FROM Grades WHERE AssignmentId='" + assignmentID + "' AND UserId='" + userId + "'", dbConn);
            try
            {
                dbDr = dbCmd.ExecuteReader();
                if (dbDr.Read())
                {
                    grade = (int)dbDr[0];
                    dbConn.Close();
                    if (grade != -1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Checking if assignment graded and exeption. " + ex);
            }
            dbConn.Close();
            return false;
        }
        public DataSet getStudentsEnrrolledInClass(int courseId)
        {
            String sqlCmd = "SELECT Enrollments.UserId, Users.[Given Name], Users.[Family Name] FROM Enrollments, Users WHERE Users.Id=Enrollments.UserId AND Users.Role='4' AND Enrollments.CourseId='" + courseId + "'";
            dbConn.Open();
            dbCmd = new SqlCommand(sqlCmd, dbConn);
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
        
        public int getRoleOfUser(int userId)
        {
            int role;
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Role FROM Users WHERE Id='" + userId + "'", dbConn);
            try
            {
                dbDr = dbCmd.ExecuteReader();
                if (dbDr.Read())
                {
                    role = (int)dbDr[0];
                    dbConn.Close();
                    return role;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed getting role of user." + ex);
                            }
            dbConn.Close();
            return 0;
        }

        public int getYearOfStudent(int userId)
        {
            int role;
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Year FROM Users WHERE Id='" + userId + "'", dbConn);
            try
            {
                dbDr = dbCmd.ExecuteReader();
                if (dbDr.Read())
                {
                    role = (int)dbDr[0];
                    dbConn.Close();
                    return role;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed getting year of student. " + ex);
            }
            dbConn.Close();
            return 0;
        }

        public int GetAssignmentGrade(int assignmentID)
        {
            return GetAssignmentGrade(assignmentID, this.UserID);
        }
        public int GetAssignmentGrade(int assignmentID, int userId)
        {
            int grade;
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Grade FROM Grades WHERE AssignmentId='" + assignmentID + "' AND UserId='" + userId + "'", dbConn);
            dbDr = dbCmd.ExecuteReader();
            if (dbDr.Read())
            {
                grade = (int)dbDr[0];
                Debug.WriteLine("Checking if " + assignmentID + " graded for " + userId + "= " + grade);
                dbConn.Close();
                return grade;
            }
            Debug.WriteLine("Checking if " + assignmentID + " graded for " + userId + "= no");
            dbConn.Close();
            return 0;
        }

        public bool atLeastOneGradeAvailableInClass(int courseId)
        {
            return atLeastOneGradeAvailableInClass(courseId, this.UserID);
        }

        public bool atLeastOneGradeAvailableInClass(int courseId, int userId)
        {
            DataSet assignments = getAssignmentsForClass(courseId);
            for (int i = 0; i < assignments.Tables[0].Rows.Count; i++)
            {
                int assignmentId = assignments.Tables[0].Rows[i].Field<Int32>(0);
                if (AssignmentGraded(assignmentId, userId))
                {
                    return true;
                }
            }
            return false;
        }

        public double getStudentGradeInClass(int courseId)
        {
            return getStudentGradeInClass(courseId, this.UserID);
        }

        public double getStudentGradeInClass(int courseId, int userId)
        {
            int totalPointsAvail = 0;
            int totalPointsEarned = 0;
            DataSet assignments = getAssignmentsForClass(courseId);
            for (int i = 0; i < assignments.Tables[0].Rows.Count; i++)
            {
                int assignmentId = assignments.Tables[0].Rows[i].Field<Int32>(0);
                int assignmentTotalPoints = assignments.Tables[0].Rows[i].Field<Int32>(1);
                if (AssignmentGraded(assignmentId, userId))
                {
                    totalPointsAvail += assignmentTotalPoints;
                    totalPointsEarned += GetAssignmentGrade(assignmentId, userId);
                }
            }
            return (double)totalPointsEarned / totalPointsAvail;
        }
        
        public double getStudentGPACurrentSemester()
        {
            return getStudentGPACurrentSemester(this.UserID);
        }
        public double getStudentGPACurrentSemester(int userId)
        {
            DataSet enrolledCourses = getEnrolledCourses(userId);
            Double totalOfGrades = 0;
            Double totalCoursesGradeAvailable = 0;
            for (int i = 0; i < enrolledCourses.Tables[0].Rows.Count; i++)
            {
                if (atLeastOneGradeAvailableInClass(enrolledCourses.Tables[0].Rows[i].Field<Int32>(0)))
                {
                    totalOfGrades += getStudentGradeInClass(enrolledCourses.Tables[0].Rows[i].Field<Int32>(0));
                    totalCoursesGradeAvailable++;
                }
            }
            return totalOfGrades / totalCoursesGradeAvailable;
        }

        public void CreateAssignment(int courseID, int totalPoints, string desc)
        {
            Debug.WriteLine(courseID);
            if (authenticated && (userRole == 2 || userRole == 3))
            {
                dbCmd = new SqlCommand("Create_Assignment_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@CourseId", courseID);
                dbCmd.Parameters.AddWithValue("@TotalPoints", totalPoints);
                dbCmd.Parameters.AddWithValue("@Description", desc);
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
            return getEligibleClasses(this.UserID);
        }

        public DataSet getEligibleClasses(int userId)
        {
            String sqlCmd = "SELECT Id, Name FROM Courses";
            if (getRoleOfUser(userId) == 4)
            {
                sqlCmd += " WHERE Year = '" + getYearOfStudent(userId) + "'";
            }
            Debug.WriteLine(sqlCmd);
            dbConn.Open();
            dbCmd = new SqlCommand(sqlCmd, dbConn);
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
            Enroll_Course(courseID, this.UserID);
        }

        public void Enroll_Course(int courseID, int userID)
        {
            if (authenticated && (userRole == 4 || userRole == 2) )
            {
                dbCmd = new SqlCommand("Enroll_Course_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@userID", userID);
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

        public void Unenroll_Course(int courseID)
        {
            Unenroll_Course(courseID, this.UserID);
        }

        public void Unenroll_Course(int courseID, int userID)
        {
            if (authenticated && (userRole == 4 || userRole == 2))
            {
                dbCmd = new SqlCommand("Unenroll_Course_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@userID", userID);
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

        public void GradeAssignmentForUser(int assignmentId, int userId, int grade)
        {
            Debug.WriteLine("Grading " + assignmentId + " for user " + userId + " with grade " + grade);
            string SQLCmd;
            if (AssignmentTurnedIn(assignmentId, userId))
            {
                Debug.WriteLine("Assignment already turned in, so updating grade.");
                SQLCmd = "Update_Grade_SP";
            }
            else
            {
                Debug.WriteLine("Assignment not turned in, so inserting grade.");
                SQLCmd = "Insert_Grade_Entry_SP";
            }
            dbCmd = new SqlCommand(SQLCmd, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@assignmentId", assignmentId);
            dbCmd.Parameters.AddWithValue("@userId", userId);
            dbCmd.Parameters.AddWithValue("@grade", grade);
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

        public void Add_User(int Id, String UserName, String Password, String GivenName, String FamilyName, int Year, int Role)
        {
            if (authenticated && userRole <= 2)
            {
                dbCmd = new SqlCommand("Add_User_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@Id", Id);
                dbCmd.Parameters.AddWithValue("@UserName", UserName);
                dbCmd.Parameters.AddWithValue("@Password", Password);
                dbCmd.Parameters.AddWithValue("@GivenName", GivenName);
                dbCmd.Parameters.AddWithValue("@FamilyName", FamilyName);
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
        public void Update_User(int Id, bool Enabled, String UserName, String GivenName, String FamilyName, int Year, int Role)
        {
            Debug.WriteLine(Id + " " + Enabled + " " + UserName + " " + GivenName + " " + FamilyName + " " + Year + " " + Role);
            if (authenticated && userRole <= 2)
            {
                dbCmd = new SqlCommand("Update_User_SP", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@Id", Id);
                dbCmd.Parameters.AddWithValue("@Enabled", Enabled);
                dbCmd.Parameters.AddWithValue("@UserName", UserName);
                dbCmd.Parameters.AddWithValue("@GivenName", GivenName);
                dbCmd.Parameters.AddWithValue("@FamilyName", FamilyName);
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
        public bool IsEnrolled(int CourseID)
        {
            return IsEnrolled(CourseID, this.UserID);
        }
        public bool IsEnrolled(int CourseID, int UserID)
        {
            dbConn.Open();
            dbCmd = new SqlCommand("SELECT Id FROM Enrollments WHERE CourseID='" + CourseID + "' AND UserID='"+ UserID + "'", dbConn);
            Debug.WriteLine("Checking enrollment " + CourseID + " for " + UserID);
            try
            {
                dbDr = dbCmd.ExecuteReader();
                dbDr.Read();
                Debug.WriteLine("Enrolled? " + dbDr[0].ToString());
                dbConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Not enrolled? " + ex);
            }
            dbConn.Close();
            return false;
        }
        public DataSet getEnrolledCourses()
        {
            return getEnrolledCourses(this.UserID);
        }
        public DataSet getEnrolledCourses(int userId)
        {
            DataSet DS = null;
            if (authenticated && userRole >= 2)
            {
                dbConn.Open();
                dbCmd = new SqlCommand("Select Enrollments.courseId, Courses.Name from Enrollments, Courses WHERE Enrollments.UserId='" +userId+"' and Courses.Id=Enrollments.CourseId", dbConn);
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
                    Debug.WriteLine(ex);
                    DS = null;
                }
                dbConn.Close();
            }
            return DS;
        }

        public DataSet getAssignmentsForClass(int courseId)
        {
            DataSet DS = null;
            if (authenticated && userRole >= 1)
            {
                dbConn.Open();
                dbCmd = new SqlCommand("Select Id, TotalPoints, Description FROM Assignments WHERE CourseId='" + courseId + "'", dbConn);
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
                    Debug.WriteLine(ex);
                    DS = null;
                }
                dbConn.Close();
            }
            return DS;
        }
        public int getRoleIdFromDesc(string desc)
        {
            switch (desc)
            {
                case "Governor":
                    return 1;
                case "Headmaster/Headmistress":
                    return 2;
                case "Teacher":
                    return 3;
                case "Student":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
