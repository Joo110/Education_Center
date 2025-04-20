using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsTeacher
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? TeacherID { get; set; }

        private int? _oldPersonID = null;
        private int? _personID = null;
        public int? PersonID
        {
            get => _personID;

            set
            {
                if (!_oldPersonID.HasValue)
                {
                    _oldPersonID = _personID;
                }

                _personID = value;
            }
        }

        public int? EducationLevelID { get; set; }
        public byte? TeachingExperience { get; set; }
        public string Certifications { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreationDate { get; set; }

        public clsPeople PersonInfo { get; private set; }
        public ClsUser CreatedByUserInfo { get; private set; }
        public clsEductionLevel EducationLevelInfo { get; private set; }

        public clsTeacher()
        {
            TeacherID = null;
            PersonID = null;
            EducationLevelID = 0;
            TeachingExperience = null;
            Certifications = null;
            CreatedByUserID = null;
            CreationDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsTeacher(int? teacherID, int? personID, byte? educationLevelID,
            byte? teachingExperience, string certifications, int? createdByUserID,
            DateTime creationDate)
        {
            TeacherID = teacherID;
            PersonID = personID;
            EducationLevelID = educationLevelID;
            TeachingExperience = teachingExperience;
            Certifications = certifications;
            CreatedByUserID = createdByUserID;
            CreationDate = creationDate;

            PersonInfo = clsPeople.Find(personID);
            CreatedByUserInfo = ClsUser._FindByPersonID(createdByUserID.GetValueOrDefault());
            EducationLevelInfo = clsEductionLevel.Find(educationLevelID);

            Mode = enMode.Update;
        }

        public static bool Delete(int TeacherID)
            => clsTeacherData.Delete(TeacherID);


        public static int GetAllTeacherCount()
        {
            return clsTeacherData.GetAllTeacherCount();
        }

        public static DataTable GetTeacherDeatils()
        {
            return clsTeacherData.GetTeacherDeatails();
        }


        private bool _Add()
        {
            TeacherID = clsTeacherData.Add(PersonID.Value, EducationLevelID.Value, TeachingExperience,
                Certifications, CreatedByUserID.Value);

            return (TeacherID.HasValue);
        }

        private bool _Update()
        {
            return clsTeacherData.Update(TeacherID.Value, PersonID.Value, EducationLevelID.Value, TeachingExperience,
                Certifications, CreatedByUserID.Value);
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


        public static clsTeacher FindByTeacherID(int? teacherID)
        {
            int? personID = null;
            byte? educationLevelID = null;
            byte? teachingExperience = null;
            string certifications = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsTeacherData.GetInfoByTeacherID(teacherID, ref personID, ref educationLevelID,
                ref teachingExperience, ref certifications, ref createdByUserID, ref creationDate);

            return (isFound) ? (new clsTeacher(teacherID, personID, educationLevelID,
                                teachingExperience, certifications, createdByUserID, creationDate))
                             : null;
        }
    }
}
