using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayar_EC_;

namespace DataBusiness_EC_
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public short Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string FullName => string.Concat(FirstName, " ", SecondName, " ", ThirdName ?? "", " ", LastName);
        public string GenderName => Gender.ToString();      

        public clsPeople()
        {
            PersonID = null;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = null;
            LastName = string.Empty;
            Gender = -1;
            DateOfBirth = DateTime.Now;
            PhoneNumber = string.Empty;
            Address = null;

            Mode = enMode.AddNew;
        }

        private clsPeople(int? personID, string firstName, string secondName, string thirdName,
            string lastName, short gender, DateTime dateOfBirth, string phoneNumber,
            string address)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;

            Mode = enMode.Update;
        }

        public static clsPeople Find(int? UserID)
        {
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = null;
            string lastName = string.Empty;
            short gender = -1;
            DateTime dateOfBirth = DateTime.Now;
            string phoneNumber = string.Empty;
            string address = null;

            bool isFound = clsPeopleData.GetInfoByID(UserID, ref firstName, ref secondName,
                ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref phoneNumber,
                ref address);

            return (isFound) ? (new clsPeople(UserID, firstName, secondName, thirdName, lastName,
                               gender, dateOfBirth, phoneNumber, address))
                             : null;
        }

        public static clsPeople FindByStudentID(int? StudentID)
        {
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = null;
            string lastName = string.Empty;
            short gender = -1;
            DateTime dateOfBirth = DateTime.Now;
            string phoneNumber = string.Empty;
            string address = null;

            bool isFound = clsPeopleData.GetInfoByStudentsID(StudentID, ref firstName, ref secondName,
                ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref phoneNumber,
                ref address);

            return (isFound) ? (new clsPeople(StudentID, firstName, secondName, thirdName, lastName,
                               gender, dateOfBirth, phoneNumber, address))
                             : null;
        }


        public static clsPeople FindByPersonID(int? PersonID)
        {
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = null;
            string lastName = string.Empty;
            short gender = -1;
            DateTime dateOfBirth = DateTime.Now;
            string phoneNumber = string.Empty;
            string address = null;

            bool isFound = clsPeopleData.GetInfoByPersonID(PersonID, ref firstName, ref secondName,
                ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref phoneNumber,
                ref address);

            return (isFound) ? (new clsPeople(PersonID, firstName, secondName, thirdName, lastName,
                               gender, dateOfBirth, phoneNumber, address))
                             : null;
        }


        private bool _Add()
        {
            PersonID = clsPeopleData.Add(FirstName, SecondName, ThirdName,
                LastName, (byte)Gender, DateOfBirth, PhoneNumber, Address);

            return (PersonID.HasValue);
        }

        private bool _Update()
        {
            return clsPeopleData.Update(PersonID.Value, FirstName, SecondName, ThirdName,
                LastName, (byte)Gender, DateOfBirth, PhoneNumber, Address);
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
    }
}
