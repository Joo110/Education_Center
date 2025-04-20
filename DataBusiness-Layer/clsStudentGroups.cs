using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsStudentGroups
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? StudentGroupID { get; set; }
        public int? StudentID { get; set; }
        public int? GroupID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }

        public clsStudents StudentInfo { get; private set; }
        public clsGroup GroupInfo { get; private set; }
        public ClsUser CreatedByUserInfo { get; private set; }

        public clsStudentGroups()
        {
            StudentGroupID = null;
            StudentID = null;
            GroupID = null;
            StartDate = DateTime.Now;
            EndDate = null;
            IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsStudentGroups(int? studentGroupID, int? studentID,
            int? groupID, DateTime startDate, DateTime? endDate, bool isActive, int? createdByUserID)
        {
            StudentGroupID = studentGroupID;
            StudentID = studentID;
            GroupID = groupID;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;

            StudentInfo = clsStudents.Find(studentID.GetValueOrDefault());
            GroupInfo = clsGroup.Find(groupID);
            CreatedByUserInfo = ClsUser._FindByPersonID(createdByUserID.GetValueOrDefault());

            Mode = enMode.Update;
        }
        
        private bool _Add()
        {
            StudentGroupID = clsStudentGroupsData.Add(StudentID.Value, GroupID.Value, CreatedByUserID.Value);

            return (StudentGroupID.HasValue);
        }

        private bool _Update()
        {
            return clsStudentGroupsData.Update(StudentGroupID.Value, StudentID.Value, GroupID.Value, EndDate, IsActive);
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

        public static DataTable GetAvailableGroups(int studentID)
        {
            return clsStudentGroupsData.GetAvailableGroupsForStudent(studentID);
        }


        public static clsStudentGroups Find(int? studentGroupID)
        {
            int? studentID = null;
            int? groupID = null;
            DateTime startDate = DateTime.Now;
            DateTime? endDate = null;
            bool isActive = true;
            int? createdByUserID = null;

            bool isFound = clsStudentGroupsData.GetInfoByID(studentGroupID, ref studentID,
                ref groupID, ref startDate, ref endDate, ref isActive, ref createdByUserID);

            return (isFound) ? (new clsStudentGroups(studentGroupID, studentID, groupID,
                startDate, endDate, isActive, createdByUserID)) : null;
        }
    }
}
