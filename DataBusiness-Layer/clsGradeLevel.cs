using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsGradeLevel
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? GradeLevelID { get; set; }

        private string _oldGradeName = string.Empty;
        private string _gradeName = string.Empty;
        public string GradeName
        {
            get => _gradeName;

            set
            {
                // If the old GradeName is not set (indicating either a new user or the GradeName is being set for the first time),
                // initialize it with the current GradeName value to track changes.
                if (string.IsNullOrWhiteSpace(_oldGradeName))
                {
                    _oldGradeName = _gradeName;
                }

                _gradeName = value;
            }
        }

        public clsGradeLevel()
        {
            GradeLevelID = null;
            GradeName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsGradeLevel(int? gradeLevelID, string gradeName)
        {
            GradeLevelID = gradeLevelID;
            GradeName = gradeName;

            Mode = enMode.Update;
        }


        public static clsGradeLevel Find(int? gradeLevelID)
        {
            string gradeName = string.Empty;

            bool isFound = clsGradeLevelData.GetInfoByID(gradeLevelID, ref gradeName);

            return (isFound) ? (new clsGradeLevel(gradeLevelID, gradeName)) : null;
        }

        public static DataTable GetAllGradeLevelsName()
        {
            return clsGradeLevelData.GetAllGradeLevelsName();
        }

        public static DataTable GetAllGradesName()
        {
            return clsGradeLevelData.GetAllGradeName();
        }

        public static string GetGradeLevelName(int? gradeLevelID)
        => clsGradeLevelData.GetGradeLevelName(gradeLevelID);

        public static int GetGradeLevelID(string gradeName)
            => clsGradeLevelData.GetGradeLevelID(gradeName);
    }
}
