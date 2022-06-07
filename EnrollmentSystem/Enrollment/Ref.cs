using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment
{
    public class Ref
    {
        public const string LEVEL_ELEM = "Elem";
        public const string LEVEL_HIGH = "High";
        public const string LEVEL_SENIOR_HIGH = "S_High";
        public const string LEVEL_RESERVED = "Res";

        public const int STUD_TYPE_UNKNOWN = -1;
        public const int STUD_TYPE_ENROLLEE = 0;
        public const int STUD_TYPE_STUDENT = 1;
        public const int STUD_TYPE_GRADUATE = 2;
        public const int STUD_TYPE_DROPOUT = 3;

        public const int TOTAL_STUDENTS = 500;

        public enum AccessTypes
        {
            Admin,
            SuperUser,
            User,
            Viewer,
            Unknown,
        }

        public class UserInfo
        {
            public string Username = "";
            public string Password = "";
            public AccessTypes Access = AccessTypes.Unknown;
            public string Notes = "";
            public DateTime DateRegistered = DateTime.Now;
            public DateTime DateUpdated = DateTime.Now;
            public DateTime? LastLogin = DateTime.Now;

            public UserInfo() { }

            public UserInfo(string username, string password, AccessTypes access, string notes,
                DateTime added, DateTime updated, DateTime? login)
            {
                this.Username = username;
                this.Password = password;
                this.Access = access;
                this.Notes = notes;
                this.DateRegistered = added;
                this.DateUpdated = updated;
                this.LastLogin = login;
            }
        }

        public class StudentInfo
        {
            public int ID = -1;
            public string StudentID = "";
            public string Lastname = "";
            public string Firstname = "";
            public string Middlename = "";
            public string Level = "";
            public int Grade = -1; // 1-12
            public string Section = "";
            public DateTime? Birthdate = DateTime.Now;
            public string Contact = "";
            public string Address = "";
            public int Type = STUD_TYPE_UNKNOWN;
            public string Notes = "";
            public DateTime DateCreated = DateTime.Now;
            public DateTime DateUpdated = DateTime.Now;
        }

        public class TuitionFeeInfo
        {
            public int ID = -1;
            public int Year = 0;
            public float Elem = 0f;
            public float High = 0f;
            public float Senior = 0f;
            public float Reserved = 0f;
        }

        public class MonthlyFeeInfo
        {
            public int ID = -1;
            public int Year = 0;
            public float Elem = 0f;
            public float High = 0f;
            public float Senior = 0f;
            public float Reserved = 0f;
        }

        public class TransTuitionInfo
        {
            public int ID = -1;
            public int StudentID = -1; // dbase iD
            public string StudentLevel = "";
            public int Year = 0;
            public float Amount = 0f;
            public DateTime DateUpdated = DateTime.Now;
        }

        public class TransMonthlyInfo
        {
            public int ID = -1;
            public int StudentID = -1; // dbase iD
            public string StudentLevel = "";
            public int Year = 0;
            public int Month = 0; // 1-12
            public float Amount = 0f;
            public DateTime DateUpdated = DateTime.Now;
        }

        public class SubjectInfo
        {
            public int ID = -1;
            public string Code = "";
            public int PassingGrade = -1;
            public string Desciption = "";
            public string Level = "";
        }

        public class SubjectMapInfo
        {
            public int Grade = -1; // 1-12
            public string Subjects = "";
        }

        public class GradingInfo
        {
            public int ID = -1;
            public int StudentID = -1;
            public int Year = 0;
            public int Grade = 0; // 1-12
            public int Quarter = 0; // 1-4
            public string Records = "";
        }

        public static int GetIndexFromAccess(AccessTypes type)
        {
            switch (type)
            {
                case AccessTypes.Admin: return 0;
                case AccessTypes.SuperUser: return 1;
                case AccessTypes.User: return 2;
                case AccessTypes.Viewer: return 3;
                default: return -1;
            }
        }

        public static string GetStringFromAccess(AccessTypes type)
        {
            switch (type)
            {
                case AccessTypes.Admin: return "Admin";
                case AccessTypes.SuperUser: return "Superuser";
                case AccessTypes.User: return "User";
                case AccessTypes.Viewer: return "Viewer";
                default: return "Unknown";
            }
        }

        public static Color GetColorFromAccess(AccessTypes type)
        {
            switch (type)
            {
                case AccessTypes.Admin: return Color.DodgerBlue;
                case AccessTypes.SuperUser: return Color.Yellow;
                case AccessTypes.User: return Color.White;
                case AccessTypes.Viewer: return Color.LightGray;
                default: return Color.Black;
            }
        }

        public static AccessTypes GetAccessFromIndex(int index)
        {
            switch (index)
            {
                case 0: return AccessTypes.Admin;
                case 1: return AccessTypes.SuperUser;
                case 2: return AccessTypes.User;
                case 3: return AccessTypes.Viewer;
                default: return AccessTypes.Unknown;
            }
        }

        public static AccessTypes GetAccessFromString(string str)
        {
            switch (str)
            {
                case "Admin": return AccessTypes.Admin;
                case "Superuser": return AccessTypes.SuperUser;
                case "User": return AccessTypes.User;
                case "Viewer": return AccessTypes.Viewer;
                default: return AccessTypes.Unknown;
            }
        }

        public static DateTime? ShortStringToDate(string str)
        {
            if (String.IsNullOrEmpty(str)) return null;
            else return DateTime.Parse(str);
        }

        public static string DateToShortString(DateTime? dt)
        {
            if (dt == null) return "";
            else return ((DateTime)dt).ToShortDateString();
        }

        public static string GetStudentTypeString(int type)
        {
            switch (type)
            {
                case 0: return "Enrollee";
                case 1: return "Student";
                case 2: return "Graduate";
                case 3: return "Dropout";
                default: return "Unknown";
            }
        }

        public static string GetMonthShortString(int month)
        {
            if (month < 1 || month > 12) return "ERR";
            string[] mos = new string[] {
                "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC",
            };
            return mos[month - 1];
        }
    }
}
