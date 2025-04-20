using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsStudents
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? StudentID { get; set; }
        public int? PersonID { get; set; }
        public int? GradeLevelID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreationDate { get; set; }

        public clsStudents()
        {
            StudentID = null;
            PersonID = null;
            GradeLevelID = null;
            CreatedByUserID = null;
            CreationDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsStudents(int? studentID, int? personID, int? gradeLevelID, int? createdByUserID, DateTime creationDate)
        {
            StudentID = studentID;
            PersonID = personID;
            GradeLevelID = gradeLevelID;
            CreatedByUserID = createdByUserID;
            CreationDate = creationDate;

            Mode = enMode.Update;
        }

        public static clsStudents Find(int studentID)
        {
            int? personID = null;
            int? gradeLevelID = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsStudentData.GetInfoByStudentID(studentID, ref personID, ref gradeLevelID, ref createdByUserID, ref creationDate);

            return (isFound) ? new clsStudents(studentID, personID, gradeLevelID, createdByUserID, creationDate) : null;
        }

        public static DataTable GetStudents()
        {
            return clsStudentData.GetStudents();
        }

        public bool UpdateStudentGrade(int studentID, string gradeName)
        {
            return clsStudentData.UpdateGradeLevel(studentID, gradeName);
        }

        public static bool Delete(int studentID)
            => clsStudentData.Delete(studentID);

        public bool SaveNewStudent()
        {
            //if (Mode == enMode.AddNew)
            //{
                return _Add();
            //}
            //return false;
        }

        private bool _Add()
        {
            if (!PersonID.HasValue || !GradeLevelID.HasValue || !CreatedByUserID.HasValue)
                return false;

            this.StudentID = clsStudentData.Add(PersonID.Value, GradeLevelID.Value, CreatedByUserID.Value);

            if (StudentID.HasValue)
            {
                Mode = enMode.Update;
                return true;
            }

            return false;
        }
    }
}