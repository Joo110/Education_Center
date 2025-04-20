using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsSubject
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SubjectID { get; set; }

        private string _oldSubjectName = string.Empty;
        private string _subjectName = string.Empty;
        public string SubjectName
        {
            get => _subjectName;

            set
            {
                // If the old SubjectName is not set (indicating either a new user or the SubjectName is being set for the first time),
                // initialize it with the current SubjectName value to track changes.
                if (string.IsNullOrWhiteSpace(_oldSubjectName))
                {
                    _oldSubjectName = _subjectName;
                }

                _subjectName = value;
            }
        }

        public clsSubject()
        {
            SubjectID = null;
            SubjectName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsSubject(int? subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;

            Mode = enMode.Update;
        }

        public static string GetSubjectNameBySubjectGradeLevelID(int? subjectGradeLevelID)
            => clsSubjectData.GetSubjectNameBySubjectGradeLevelID(subjectGradeLevelID);


        public static DataTable GetAllSubjectName()
        {
            return clsSubjectData.GetAllSubjectName();
        }

        public static clsSubject Find(int? subjectID)
        {
            string subjectName = string.Empty;

            bool isFound = clsSubjectData.GetInfoByID(subjectID, ref subjectName);

            return (isFound) ? (new clsSubject(subjectID, subjectName)) : null;
        }


        public static int? GetSubjectID(string subjectName)
            => clsSubjectData.GetSubjectID(subjectName);


        private bool _Add()
        {
            SubjectID = clsSubjectData.AddNewSubject(SubjectName);

            return (SubjectID.HasValue);
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

                //case enMode.Update:
                //    return _Update();
            }

            return false;
        }
    }
}
