using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsEductionLevel
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public byte? EducationLevelID { get; set; }

        private string _oldLevelName = string.Empty;
        private string _levelName = string.Empty;
        public string LevelName
        {
            get => _levelName;

            set
            {
                // If the old LevelName is not set (indicating either a new user or the LevelName is being set for the first time),
                // initialize it with the current LevelName value to track changes.
                if (string.IsNullOrWhiteSpace(_oldLevelName))
                {
                    _oldLevelName = _levelName;
                }

                _levelName = value;
            }
        }

        public clsEductionLevel()
        {
            EducationLevelID = null;
            LevelName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsEductionLevel(byte? educationLevelID, string levelName)
        {
            EducationLevelID = educationLevelID;
            LevelName = levelName;

            Mode = enMode.Update;
        }


        public static DataTable AllOnlyNames() => clsEductionLevelData.GetEductionLevelName();

        public static int GetEducationLeveID(string levelName)
          => clsEductionLevelData.GetEducationLevelID(levelName);

        public static string GetEducationLeveName(int? educationLevelID)
            => clsEductionLevelData.GetEducationLevelName(educationLevelID);

        public static clsEductionLevel Find(byte? educationLevelID)
        {
            string levelName = string.Empty;

            bool isFound = clsEductionLevelData.GetInfoByID(educationLevelID, ref levelName);

            return (isFound) ? (new clsEductionLevel(educationLevelID, levelName)) : null;
        }
    }
}
