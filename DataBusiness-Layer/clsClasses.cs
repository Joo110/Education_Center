using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsClasses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? ClassID { get; set; }

        private string _className = string.Empty;
        private string _oldClassName = string.Empty;
        public string ClassName
        {
            get => _className;
            set
            {
                if (string.IsNullOrWhiteSpace(_oldClassName))
                {
                    _oldClassName = _className;
                }
                _className = value;
            }
        }

        public int Capacity { get; set; } 
        public string Description { get; set; }

        public clsClasses()
        {
            ClassID = null;
            ClassName = string.Empty;
            Capacity = 1;
            Description = null;
            Mode = enMode.AddNew;
        }

        private clsClasses(int? classID, string className, int capacity, string description)
        {
            ClassID = classID;
            ClassName = className;
            Capacity = capacity;
            Description = description;
            Mode = enMode.Update;
        }

        public static int GetAllClassesCount()
        {
            return clsCLassesData.GetAllClassesCount();
        }

        public static DataTable GetTeachersByClass(int classID)
        {
            return clsCLassesData.GetTeachersByClassID(classID);
        }

        public static DataTable AllInPages()
            => clsCLassesData.GetAllClasses();

        public static clsClasses Find(int? classID)
        {
            string className = string.Empty;
            int capacity = 0;
            string description = null;

            bool isFound = clsCLassesData.GetInfoByID(classID, ref className, ref capacity, ref description);

            return (isFound) ? (new clsClasses(classID, className, capacity, description)) : null;
        }


        private bool _Add()
        {
            ClassID = clsCLassesData.Add(ClassName, Capacity, Description);

            return (ClassID.HasValue);
        }

        private bool _Update()
        {
            return clsCLassesData.Update(ClassID.Value, ClassName, Capacity, Description);
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
