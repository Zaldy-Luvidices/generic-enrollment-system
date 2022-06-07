using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public class Global
    {
        public static List<Ref.UserInfo> Users = new List<Ref.UserInfo>();
        public static List<Ref.StudentInfo> Students = new List<Ref.StudentInfo>();
        public static List<Ref.TuitionFeeInfo> TuitionFees = new List<Ref.TuitionFeeInfo>();
        public static List<Ref.TransTuitionInfo> TFTransactions = new List<Ref.TransTuitionInfo>();
        public static List<Ref.MonthlyFeeInfo> MonthlyFees = new List<Ref.MonthlyFeeInfo>();
        public static List<Ref.TransMonthlyInfo> MPTransactions = new List<Ref.TransMonthlyInfo>();
        public static List<Ref.SubjectInfo> Subjects = new List<Ref.SubjectInfo>();
        public static List<Ref.SubjectMapInfo> SubjectMaps = new List<Ref.SubjectMapInfo>(); // should be 12 items only
        public static List<Ref.GradingInfo> Gradings = new List<Ref.GradingInfo>();
        public static Ref.UserInfo CurrentUser = null;

        private static SqlConnection conn = null;

        public static bool OpenConnection()
        {
            string path = Application.StartupPath;
            if(!path.EndsWith(Path.DirectorySeparatorChar.ToString())) path += Path.DirectorySeparatorChar;
            path += "DATA.mdf";
            //path = @"|DataDirectory|\DBASE.mdf";
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + ";Integrated Security=True";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't establish database connection: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool CloseConnection()
        {
            if (conn == null) return false;
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't close database connection: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region User Data
        public static bool LoadUsers()
        {
            Users.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.UserInfo user = new Ref.UserInfo();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Access = Ref.GetAccessFromIndex(Convert.ToInt32(reader["Access"]));
                    user.Notes = reader["Notes"].ToString();
                    user.DateRegistered = (DateTime)Ref.ShortStringToDate(reader["DateRegistered"].ToString());
                    user.DateUpdated = (DateTime)Ref.ShortStringToDate(reader["DateUpdated"].ToString());
                    user.LastLogin = String.IsNullOrEmpty(reader["LastLogin"].ToString()) ? null : (DateTime?)Ref.ShortStringToDate(reader["LastLogin"].ToString());
                    Users.Add(user);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool IsUserExists(string username)
        {
            foreach (Ref.UserInfo user in Users)
            {
                if (user.Username.ToLower().Equals(username.ToLower()))
                    return true;
            }

            return false;
        }

        public static bool AddUser(Ref.UserInfo user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Users(Username,Password,Access,Notes,DateRegistered,DateUpdated,LastLogin) " +
                    "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                cmd.Parameters.AddWithValue("@p1", user.Username.ToLower());
                cmd.Parameters.AddWithValue("@p2", user.Password);
                cmd.Parameters.AddWithValue("@p3", Ref.GetIndexFromAccess(user.Access));
                cmd.Parameters.AddWithValue("@p4", user.Notes);
                cmd.Parameters.AddWithValue("@p5", Ref.DateToShortString(user.DateRegistered));
                cmd.Parameters.AddWithValue("@p6", Ref.DateToShortString(user.DateUpdated));
                cmd.Parameters.AddWithValue("@p7", "");
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                Users.Add(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.UserInfo UpdateUserData(string username, Ref.UserInfo user)
        {
            for (int i = 0; i < Users.Count; ++i)
            {
                if (Users[i].Username.ToLower().Equals(username.ToLower()))
                {
                    try
                    {
                        user.DateUpdated = DateTime.Now;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "UPDATE dbo.Users SET Username=@p1, Password=@p2, Access=@p3, Notes=@p4, DateUpdated=@p5 " +
                            "WHERE Username=@p6";
                        cmd.Parameters.AddWithValue("@p1", user.Username.ToLower());
                        cmd.Parameters.AddWithValue("@p2", user.Password);
                        cmd.Parameters.AddWithValue("@p3", Ref.GetIndexFromAccess(user.Access));
                        cmd.Parameters.AddWithValue("@p4", user.Notes);
                        cmd.Parameters.AddWithValue("@p5", Ref.DateToShortString(user.DateUpdated));
                        cmd.Parameters.AddWithValue("@p6", username.ToLower());
                        int ret = cmd.ExecuteNonQuery();
                        if (ret == 0)
                        {
                            MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }

                        Users[i].Username = user.Username;
                        Users[i].Password = user.Password;
                        Users[i].Access = user.Access;
                        Users[i].Notes = user.Notes;
                        Users[i].DateUpdated = user.DateUpdated;
                        return Users[i];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }

            return null;
        }

        public static DateTime? UpdateUserLogin(string username)
        {
            for (int i = 0; i < Users.Count; ++i)
            {
                if (Users[i].Username.ToLower().Equals(username.ToLower()))
                {
                    try
                    {
                        DateTime dte = DateTime.Now;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "UPDATE dbo.Users SET LastLogin=@p1 WHERE Username=@p2";
                        cmd.Parameters.AddWithValue("@p1", Ref.DateToShortString(dte));
                        cmd.Parameters.AddWithValue("@p2", username.ToLower());
                        int ret = cmd.ExecuteNonQuery();
                        if (ret == 0)
                        {
                            MessageBox.Show("Failed to update login record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                        return dte;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't update login record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }

            return null;
        }

        public static bool DeleteUser(string username)
        {
            for (int i = Users.Count - 1; i >= 0; --i)
            {
                if (Users[i].Username.ToLower().Equals(username.ToLower()))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "DELETE dbo.Users WHERE Username=@p1";
                        cmd.Parameters.AddWithValue("@p1", username.ToLower());
                        int ret = cmd.ExecuteNonQuery();
                        if (ret == 0)
                        {
                            MessageBox.Show("Failed to delete record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't delete record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    Users.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region Student Data
        public static bool LoadStudents()
        {
            Students.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Students", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.StudentInfo stud = new Ref.StudentInfo();
                    stud.ID = Convert.ToInt32(reader["ID"]);
                    stud.StudentID = reader["StudentID"].ToString();
                    stud.Lastname = reader["Lastname"].ToString();
                    stud.Firstname = reader["Firstname"].ToString();
                    stud.Middlename = reader["Middlename"].ToString();
                    stud.Level = reader["Level"].ToString();
                    stud.Grade = Convert.ToInt32(reader["Grade"]);
                    stud.Section = reader["Section"].ToString();
                    stud.Birthdate = Ref.ShortStringToDate(reader["Birthdate"].ToString());
                    stud.Contact = reader["Contact"].ToString();
                    stud.Address = reader["Address"].ToString();
                    stud.Type = Convert.ToInt32(reader["Type"]);
                    stud.Notes = reader["Notes"].ToString();
                    stud.DateCreated = (DateTime)Ref.ShortStringToDate(reader["DateCreated"].ToString());
                    stud.DateUpdated = (DateTime)Ref.ShortStringToDate(reader["DateUpdated"].ToString());
                    Students.Add(stud);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddStudent(Ref.StudentInfo stud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Students(StudentID,Lastname,Firstname,Middlename,Level,Section,Birthdate,Contact,Address,Type,Notes,DateCreated,DateUpdated,Grade) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";
                cmd.Parameters.AddWithValue("@p1", stud.StudentID);
                cmd.Parameters.AddWithValue("@p2", stud.Lastname);
                cmd.Parameters.AddWithValue("@p3", stud.Firstname);
                cmd.Parameters.AddWithValue("@p4", stud.Middlename);
                cmd.Parameters.AddWithValue("@p5", stud.Level);
                cmd.Parameters.AddWithValue("@p6", stud.Section);
                cmd.Parameters.AddWithValue("@p7", Ref.DateToShortString(stud.Birthdate));
                cmd.Parameters.AddWithValue("@p8", stud.Contact);
                cmd.Parameters.AddWithValue("@p9", stud.Address);
                cmd.Parameters.AddWithValue("@p10", stud.Type);
                cmd.Parameters.AddWithValue("@p11", stud.Notes);
                cmd.Parameters.AddWithValue("@p12", Ref.DateToShortString(stud.DateCreated));
                cmd.Parameters.AddWithValue("@p13", Ref.DateToShortString(stud.DateUpdated));
                cmd.Parameters.AddWithValue("@p14", stud.Grade);
                Object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                stud.ID = (int)obj;
                Students.Add(stud);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.StudentInfo UpdateStudentData(int index, Ref.StudentInfo data)
        {
            try
            {
                if (index >= Students.Count || index < 0) return null;

                data.DateUpdated = DateTime.Now;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Students SET StudentID=@p1, Lastname=@p2, Firstname=@p3, Middlename=@p4, Level=@p5, " +
                    "Section=@p6, Birthdate=@p7, Contact=@p8, Address=@p9, Type=@p10, Notes=@p11, DateUpdated=@p12, Grade=@p13 " +
                    "WHERE ID=@p14";
                cmd.Parameters.AddWithValue("@p1", data.StudentID);
                cmd.Parameters.AddWithValue("@p2", data.Lastname);
                cmd.Parameters.AddWithValue("@p3", data.Firstname);
                cmd.Parameters.AddWithValue("@p4", data.Middlename);
                cmd.Parameters.AddWithValue("@p5", data.Level);
                cmd.Parameters.AddWithValue("@p6", data.Section);
                cmd.Parameters.AddWithValue("@p7", Ref.DateToShortString(data.Birthdate));
                cmd.Parameters.AddWithValue("@p8", data.Contact);
                cmd.Parameters.AddWithValue("@p9", data.Address);
                cmd.Parameters.AddWithValue("@p10", data.Type);
                cmd.Parameters.AddWithValue("@p11", data.Notes);
                cmd.Parameters.AddWithValue("@p12", Ref.DateToShortString(data.DateUpdated));
                cmd.Parameters.AddWithValue("@p13", data.Grade);
                cmd.Parameters.AddWithValue("@p14", data.ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                Students[index].StudentID = data.StudentID;
                Students[index].Lastname = data.Lastname;
                Students[index].Firstname = data.Firstname;
                Students[index].Middlename = data.Middlename;
                Students[index].Level = data.Level;
                Students[index].Grade = data.Grade;
                Students[index].Section = data.Section;
                Students[index].Birthdate = data.Birthdate;
                Students[index].Contact = data.Contact;
                Students[index].Address = data.Address;
                Students[index].Type = data.Type;
                Students[index].Notes = data.Notes;
                Students[index].DateUpdated = data.DateUpdated;
                return Students[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Ref.StudentInfo UpdateStudentType(int index, int type)
        {
            try
            {
                if (index >= Students.Count || index < 0) return null;

                DateTime updateDate = DateTime.Now;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Students SET Type=@p1, DateUpdated=@p2 " +
                    "WHERE ID=@p3";
                cmd.Parameters.AddWithValue("@p1", type);
                cmd.Parameters.AddWithValue("@p2", updateDate);
                cmd.Parameters.AddWithValue("@p3", Students[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                Students[index].Type = type;
                Students[index].DateUpdated = updateDate;
                return Students[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool DeleteStudent(int index)
        {
            try
            {
                if (index >= Students.Count || index < 0) return false;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE dbo.Students WHERE ID=@p1";
                cmd.Parameters.AddWithValue("@p1", Students[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to delete record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't delete record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Students.RemoveAt(index);
            return true;
        }
        #endregion

        #region Tuition Fee Data
        public static bool LoadTuitionFees()
        {
            TuitionFees.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Tuition", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.TuitionFeeInfo tinfo = new Ref.TuitionFeeInfo();
                    tinfo.ID = Convert.ToInt32(reader["ID"]);
                    tinfo.Year = Convert.ToInt32(reader["Year"]);
                    tinfo.Elem = Convert.ToSingle(reader["Level_Elem"]);
                    tinfo.High = Convert.ToSingle(reader["Level_High"]);
                    tinfo.Senior = Convert.ToSingle(reader["Level_Senior"]);
                    tinfo.Reserved = Convert.ToSingle(reader["Level_Res"]);
                    TuitionFees.Add(tinfo);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddTuitionFee(Ref.TuitionFeeInfo tinfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Tuition(Year,Level_Elem,Level_High,Level_Senior,Level_Res) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", tinfo.Year);
                cmd.Parameters.AddWithValue("@p2", tinfo.Elem);
                cmd.Parameters.AddWithValue("@p3", tinfo.High);
                cmd.Parameters.AddWithValue("@p4", tinfo.Senior);
                cmd.Parameters.AddWithValue("@p5", tinfo.Reserved);
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                tinfo.ID = (int)obj;
                TuitionFees.Add(tinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.TuitionFeeInfo UpdateTuitionFeeData(int index, Ref.TuitionFeeInfo tinfo)
        {
            try
            {
                if (index >= TuitionFees.Count || index < 0) return null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Tuition SET Level_Elem=@p1, Level_High=@p2, Level_Senior=@p3, Level_Res=@p4 " +
                    "WHERE ID=@p5";
                cmd.Parameters.AddWithValue("@p1", tinfo.Elem);
                cmd.Parameters.AddWithValue("@p2", tinfo.High);
                cmd.Parameters.AddWithValue("@p3", tinfo.Senior);
                cmd.Parameters.AddWithValue("@p4", tinfo.Reserved);
                cmd.Parameters.AddWithValue("@p5", tinfo.ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                TuitionFees[index].Elem = tinfo.Elem;
                TuitionFees[index].High = tinfo.High;
                TuitionFees[index].Senior = tinfo.Senior;
                TuitionFees[index].Reserved = tinfo.Reserved;
                return TuitionFees[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool DeleteTuitionFee(int index)
        {
            try
            {
                if (index >= TuitionFees.Count || index < 0) return false;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE dbo.Tuition WHERE ID=@p1";
                cmd.Parameters.AddWithValue("@p1", TuitionFees[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to delete record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't delete record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            TuitionFees.RemoveAt(index);
            return true;
        }
        #endregion

        #region Tuition Fee Transactions Data
        public static bool LoadTransTuition()
        {
            TFTransactions.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.TransTuition", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.TransTuitionInfo ttinfo = new Ref.TransTuitionInfo();
                    ttinfo.ID = Convert.ToInt32(reader["ID"]);
                    ttinfo.StudentID = Convert.ToInt32(reader["StudentID"]);
                    ttinfo.StudentLevel = reader["StudentLevel"].ToString();
                    ttinfo.Year = Convert.ToInt32(reader["Year"]);
                    ttinfo.Amount = Convert.ToSingle(reader["Amount"]);
                    ttinfo.DateUpdated = (DateTime)Ref.ShortStringToDate(reader["DateUpdated"].ToString());
                    TFTransactions.Add(ttinfo);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddTransTuition(Ref.TransTuitionInfo ttinfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.TransTuition(Year,StudentID,Amount,DateUpdated,StudentLevel) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", ttinfo.Year);
                cmd.Parameters.AddWithValue("@p2", ttinfo.StudentID);
                cmd.Parameters.AddWithValue("@p3", ttinfo.Amount);
                cmd.Parameters.AddWithValue("@p4", Ref.DateToShortString(ttinfo.DateUpdated));
                cmd.Parameters.AddWithValue("@p5", ttinfo.StudentLevel);
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                ttinfo.ID = (int)obj;
                TFTransactions.Add(ttinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.TransTuitionInfo UpdateTransTuitionData(int index, float amount)
        {
            try
            {
                if (index >= TFTransactions.Count || index < 0) return null;

                DateTime updateDate = DateTime.Now;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.TransTuition SET Amount=@p1, DateUpdated=@p2 " +
                    "WHERE ID=@p3";
                cmd.Parameters.AddWithValue("@p1", amount);
                cmd.Parameters.AddWithValue("@p2", Ref.DateToShortString(updateDate));
                cmd.Parameters.AddWithValue("@p3", TFTransactions[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                TFTransactions[index].Amount = amount;
                TFTransactions[index].DateUpdated = updateDate;
                return TFTransactions[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Monthly Payment Data
        public static bool LoadMonthlyFees()
        {
            MonthlyFees.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Monthly", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.MonthlyFeeInfo minfo = new Ref.MonthlyFeeInfo();
                    minfo.ID = Convert.ToInt32(reader["ID"]);
                    minfo.Year = Convert.ToInt32(reader["Year"]);
                    minfo.Elem = Convert.ToSingle(reader["Level_Elem"]);
                    minfo.High = Convert.ToSingle(reader["Level_High"]);
                    minfo.Senior = Convert.ToSingle(reader["Level_Senior"]);
                    minfo.Reserved = Convert.ToSingle(reader["Level_Res"]);
                    MonthlyFees.Add(minfo);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddMonthlyFee(Ref.MonthlyFeeInfo minfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Monthly(Year,Level_Elem,Level_High,Level_Senior,Level_Res) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", minfo.Year);
                cmd.Parameters.AddWithValue("@p2", minfo.Elem);
                cmd.Parameters.AddWithValue("@p3", minfo.High);
                cmd.Parameters.AddWithValue("@p4", minfo.Senior);
                cmd.Parameters.AddWithValue("@p5", minfo.Reserved);
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                minfo.ID = (int)obj;
                MonthlyFees.Add(minfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.MonthlyFeeInfo UpdateMonthlyFeeData(int index, Ref.MonthlyFeeInfo minfo)
        {
            try
            {
                if (index >= MonthlyFees.Count || index < 0) return null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Monthly SET Level_Elem=@p1, Level_High=@p2, Level_Senior=@p3, Level_Res=@p4 " +
                    "WHERE ID=@p5";
                cmd.Parameters.AddWithValue("@p1", minfo.Elem);
                cmd.Parameters.AddWithValue("@p2", minfo.High);
                cmd.Parameters.AddWithValue("@p3", minfo.Senior);
                cmd.Parameters.AddWithValue("@p4", minfo.Reserved);
                cmd.Parameters.AddWithValue("@p5", minfo.ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                MonthlyFees[index].Elem = minfo.Elem;
                MonthlyFees[index].High = minfo.High;
                MonthlyFees[index].Senior = minfo.Senior;
                MonthlyFees[index].Reserved = minfo.Reserved;
                return MonthlyFees[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Monthly Payment Transactions Data
        public static bool LoadTransMonthly()
        {
            MPTransactions.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.TransMonthly", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.TransMonthlyInfo tminfo = new Ref.TransMonthlyInfo();
                    tminfo.ID = Convert.ToInt32(reader["ID"]);
                    tminfo.StudentID = Convert.ToInt32(reader["StudentID"]);
                    tminfo.StudentLevel = reader["StudentLevel"].ToString();
                    tminfo.Year = Convert.ToInt32(reader["Year"]);
                    tminfo.Month = Convert.ToInt32(reader["Month"]);
                    tminfo.Amount = Convert.ToSingle(reader["Amount"]);
                    tminfo.DateUpdated = (DateTime)Ref.ShortStringToDate(reader["DateUpdated"].ToString());
                    MPTransactions.Add(tminfo);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddTransMonthly(Ref.TransMonthlyInfo tminfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.TransMonthly(Year,Month,StudentID,Amount,DateUpdated,StudentLevel) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5,@p6)";
                cmd.Parameters.AddWithValue("@p1", tminfo.Year);
                cmd.Parameters.AddWithValue("@p2", tminfo.Month);
                cmd.Parameters.AddWithValue("@p3", tminfo.StudentID);
                cmd.Parameters.AddWithValue("@p4", tminfo.Amount);
                cmd.Parameters.AddWithValue("@p5", Ref.DateToShortString(tminfo.DateUpdated));
                cmd.Parameters.AddWithValue("@p6", tminfo.StudentLevel);
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                tminfo.ID = (int)obj;
                MPTransactions.Add(tminfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.TransMonthlyInfo UpdateTransMonthlyData(int index, float amount)
        {
            try
            {
                if (index >= MPTransactions.Count || index < 0) return null;

                DateTime updateDate = DateTime.Now;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.TransMonthly SET Amount=@p1, DateUpdated=@p2 " +
                    "WHERE ID=@p3";
                cmd.Parameters.AddWithValue("@p1", amount);
                cmd.Parameters.AddWithValue("@p2", Ref.DateToShortString(updateDate));
                cmd.Parameters.AddWithValue("@p3", MPTransactions[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                MPTransactions[index].Amount = amount;
                MPTransactions[index].DateUpdated = updateDate;
                return MPTransactions[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Subjects Data
        public static bool LoadSubjects()
        {
            Subjects.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Subjects", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.SubjectInfo subj = new Ref.SubjectInfo();
                    subj.ID = Convert.ToInt32(reader["ID"]);
                    subj.Code = reader["Code"].ToString();
                    subj.PassingGrade = Convert.ToInt32(reader["Passing"]);
                    subj.Desciption = reader["Description"].ToString();
                    subj.Level = reader["Level"].ToString();
                    Subjects.Add(subj);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddSubject(Ref.SubjectInfo subj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Subjects(Code,Passing,Description,Level) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4)";
                cmd.Parameters.AddWithValue("@p1", subj.Code);
                cmd.Parameters.AddWithValue("@p2", subj.PassingGrade);
                cmd.Parameters.AddWithValue("@p3", subj.Desciption);
                cmd.Parameters.AddWithValue("@p4", subj.Level);
                Object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                subj.ID = (int)obj;
                Subjects.Add(subj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Ref.SubjectInfo UpdateSubjectData(int index, Ref.SubjectInfo subj)
        {
            try
            {
                if (index >= Subjects.Count || index < 0) return null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Subjects SET Code=@p1, Passing=@p2, Description=@p3, Level=@p4 " +
                    "WHERE ID=@p5";
                cmd.Parameters.AddWithValue("@p1", subj.Code);
                cmd.Parameters.AddWithValue("@p2", subj.PassingGrade);
                cmd.Parameters.AddWithValue("@p3", subj.Desciption);
                cmd.Parameters.AddWithValue("@p4", subj.Level);
                cmd.Parameters.AddWithValue("@p5", subj.ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                Subjects[index].Code = subj.Code;
                Subjects[index].PassingGrade = subj.PassingGrade;
                Subjects[index].Desciption = subj.Desciption;
                return Subjects[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool DeleteSubject(int index)
        {
            try
            {
                if (index >= Subjects.Count || index < 0) return false;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE dbo.Subjects WHERE ID=@p1";
                cmd.Parameters.AddWithValue("@p1", Subjects[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to delete record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't delete record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Subjects.RemoveAt(index);
            return true;
        }
        #endregion

        #region Subject Maps Data
        public static bool LoadSubjectMaps()
        {
            SubjectMaps.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SubjectsMapping", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.SubjectMapInfo subj = new Ref.SubjectMapInfo();
                    subj.Grade = Convert.ToInt32(reader["Grade"]);
                    subj.Subjects = reader["Subjects"].ToString();
                    SubjectMaps.Add(subj);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddSubjectMap(Ref.SubjectMapInfo map)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.SubjectsMapping(Grade,Subjects) " +
                    "VALUES(@p1,@p2)";
                cmd.Parameters.AddWithValue("@p1", map.Grade);
                cmd.Parameters.AddWithValue("@p2", map.Subjects);
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                SubjectMaps.Add(map);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool UpdateSubjectMapData(int grade, string subjects)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.SubjectsMapping SET Subjects=@p1 " +
                    "WHERE Grade=@p2";
                cmd.Parameters.AddWithValue("@p1", subjects);
                cmd.Parameters.AddWithValue("@p2", grade);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                SubjectMaps[grade - 1].Subjects = subjects;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        public static bool LoadGradings()
        {
            Gradings.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Grading", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ref.GradingInfo grade = new Ref.GradingInfo();
                    grade.ID = Convert.ToInt32(reader["ID"]);
                    grade.StudentID = Convert.ToInt32(reader["StudentID"]);
                    grade.Year = Convert.ToInt32(reader["Year"]);
                    grade.Grade = Convert.ToInt32(reader["Grade"]);
                    grade.Quarter = Convert.ToInt32(reader["Quarter"]);
                    grade.Records = reader["Records"].ToString();
                    Gradings.Add(grade);
                }
                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't retrieve records: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AddGrading(Ref.GradingInfo grade)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Grading(StudentID,Year,Grade,Quarter,Records) " +
                    "output INSERTED.ID VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", grade.StudentID);
                cmd.Parameters.AddWithValue("@p2", grade.Year);
                cmd.Parameters.AddWithValue("@p3", grade.Grade);
                cmd.Parameters.AddWithValue("@p4", grade.Quarter);
                cmd.Parameters.AddWithValue("@p5", grade.Records);
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Failed to add new record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // add to list
                grade.ID = (int)obj;
                Gradings.Add(grade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add new record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool UpdateGradingData(int index, string records)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.Grading SET Records=@p1 " +
                    "WHERE ID=@p2";
                cmd.Parameters.AddWithValue("@p1", records);
                cmd.Parameters.AddWithValue("@p2", Gradings[index].ID);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    MessageBox.Show("Failed to update record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Gradings[index].Records = records;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update record: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
