using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBusiness_EC_
{
    public class ClsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enPermissions
        {
            All = -1,
            AddUser = 1,
            UpdateUser = 2,
            DeleteUser = 4,
            ListUsers = 8
        }

        public int?UserID { get; set; }
        public int? PersonID { get; set; }
        public int Permissions { get; set; }
        public clsPeople PersonInfo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int isActive { get; set; }
        public ClsUser()
        {
            UserID = -1;
            PersonID = -1;
            Permissions = -1;
            UserName = "";
            Password = "";
            isActive = -1;
        }
        private ClsUser(int? userID, int? personInfo, string userName, string password, int Permission, int IsActive)
        {
            UserID = userID;
            PersonID = personInfo;
            PersonInfo = clsPeople.Find(PersonID);
            UserName = userName;
            Password = password;
            Permissions = Permission;
            isActive = IsActive;
        }

        private ClsUser(int? userID, string userName, string password, int Permission, int IsActive)
        {
            UserID = userID;
            PersonInfo = clsPeople.Find(PersonID);
            UserName = userName;
            Password = password;
            Permissions = Permission;
            isActive = IsActive;
        }

        public static bool ExistsByUsernameAndPassword(string username, string password)
        {
            return !ClsUserData.Exists(username, password);
        }

        public static bool Delete(int userID)
        {
            return ClsUserData.DeleteUser(userID);
        }

        public static bool CheckUserExists(string username)
        {
            return ClsUserData.DoesUserExistByUsername(username);
        }


        private static ClsUser _FindByUsernameAndPassword(string Username, string Password)
        {
            int? UserID = null;
            int? PersonID = null;
            int IsActive = -1;
            int permissions = -1;
            bool IsFound = ClsUserData.GetUserInfoByUsernameAndPassword(ref UserID, ref PersonID, Username,
                Password, ref permissions, ref IsActive);

            return (IsFound) ? (new ClsUser(UserID, PersonID, Username, Password, permissions, IsActive)) : null;
        }


        public static ClsUser FindBy<T>(T Data1, T Data2)
        {
            if (Data1 == null || Data2 == null)
                return null;

            return _FindByUsernameAndPassword(Data1 as string, Data2 as string);
        }

        public static int GetAllUsersCount()
        {
            return ClsUserData.GetAllUsersCount();
        }

        public static ClsUser _FindByPersonID(int UserID)
        {
            string Username = string.Empty;
            string Password = string.Empty;
            int permissions = -1;
            int IsActive = -1;
            int PersonID = -1;

            bool IsFound = ClsUserData.GetUserInfoByPersonID(UserID, ref PersonID,
                ref Username, ref Password, ref permissions, ref IsActive);

            return (IsFound) ? (new ClsUser(UserID, PersonID, Username, Password, permissions, IsActive)) : null;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
            => ClsUserData.ChangePassword(UserID, NewPassword);


        private bool _Add()
        {
            if (PersonID <= 0)
            {
                throw new InvalidOperationException("PersonID must have a value before adding a user.");
            }

            UserID = ClsUserData.Add(PersonID.Value, UserName, Password, Permissions, isActive);

            return (UserID.HasValue);
        }

        private bool _Update()
        {
            if (!UserID.HasValue || !PersonID.HasValue)
                throw new InvalidOperationException("UserID and PersonID must have values before updating a user.");

            return ClsUserData.Update(UserID.Value, PersonID.Value, UserName, Password, Permissions, isActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetAllUsers();
        }
    }
}
