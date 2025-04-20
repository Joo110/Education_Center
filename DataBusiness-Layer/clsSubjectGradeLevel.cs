using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsSubjectGradeLevel
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SubjectGradeLevelID { get; set; }

        private int? _oldSubjectID = null;
        private int? _subjectID = null;
        public int? SubjectID
        {
            get => _subjectID;

            set
            {
                if (!_oldSubjectID.HasValue)
                {
                    _oldSubjectID = _subjectID;
                }

                _subjectID = value;
            }
        }

        private byte? _oldGradeLevelID = null;
        private byte? _gradeLevelID = null;
        public byte? GradeLevelID
        {
            get => _gradeLevelID;

            set
            {
                if (!_oldGradeLevelID.HasValue)
                {
                    _oldGradeLevelID = _gradeLevelID;
                }

                _gradeLevelID = value;
            }
        }

        public decimal Fees { get; set; }
        public string Description { get; set; }

        public clsSubject SubjectInfo { get; private set; }
        public clsGradeLevel GradeLevelInfo { get; private set; }

        public clsSubjectGradeLevel()
        {
            SubjectGradeLevelID = null;
            SubjectID = null;
            GradeLevelID = null;
            Fees = -1M;
            Description = null;

            Mode = enMode.AddNew;
        }

        private clsSubjectGradeLevel(int? subjectGradeLevelID, int? subjectID,
            byte? gradeLevelID, decimal fees, string description)
        {
            SubjectGradeLevelID = subjectGradeLevelID;
            SubjectID = subjectID;
            GradeLevelID = gradeLevelID;
            Fees = fees;
            Description = description;

            SubjectInfo = clsSubject.Find(subjectID);
            GradeLevelInfo = clsGradeLevel.Find(gradeLevelID);

            Mode = enMode.Update;
        }


        private bool _Add()
        {
            if (!SubjectID.HasValue || !GradeLevelID.HasValue)
            {
                throw new InvalidOperationException("SubjectID and GradeLevelID must have a value.");
            }

            SubjectGradeLevelID = clsSubjectGradeLevelData.Add(SubjectID.Value, GradeLevelID.Value, Fees, Description);

            return SubjectGradeLevelID.HasValue;
        }

        private bool _Update()
        {
            return clsSubjectGradeLevelData.Update(SubjectGradeLevelID.Value, SubjectID.Value,
                GradeLevelID.Value, Fees, Description);
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


        public static clsSubjectGradeLevel Find(int? subjectGradeLevelID)
        {
            int? subjectID = null;
            byte? gradeLevelID = null;
            decimal fees = -1M;
            string description = null;

            bool isFound = clsSubjectGradeLevelData.GetInfoByID(subjectGradeLevelID,
                ref subjectID, ref gradeLevelID, ref fees, ref description);

            return (isFound) ? (new clsSubjectGradeLevel(subjectGradeLevelID,
                subjectID, gradeLevelID, fees, description)) : null;
        }


        public static DataTable GetAllSubjectGradeLevel()
        {
            return clsSubjectGradeLevelData.GetSubjectGradeLevelData();
        }

        public static DataTable GetAllTeachersTeachSubject(int subjectGradeLevelID)
        {
            return clsSubjectGradeLevelData.GetAllTeachersTeachSubject(subjectGradeLevelID);
        }

        public static DataTable GetUntaughtSubjects(int? teacherID)
        {
            return clsSubjectGradeLevelData.GetUntaughtSubjectsByTeacher(teacherID);
        }

    }
}
