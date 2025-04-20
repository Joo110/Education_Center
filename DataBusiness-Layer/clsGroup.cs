using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsGroup
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? GroupID { get; set; }
        public string GroupName { get; set; }
        public int? ClassID { get; set; }
        public int? TeacherID { get; set; }
        public int? SubjectTeacherID { get; set; }
        public int? MeetingTimeID { get; set; }
        public int? StudentCount { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public clsClasses ClassInfo { get; private set; }
        public clsTeacher TeacherInfo { get; private set; }
        public clsSubjectTeacher SubjectTeacherInfo { get; private set; }
        public clsMeetingTime MeetingTimeInfo { get; private set; }
        public ClsUser CreatedByUserInfo { get; private set; }

        public clsGroup()
        {
            GroupID = null;
            GroupName = string.Empty;
            ClassID = null;
            TeacherID = null;
            SubjectTeacherID = null;
            MeetingTimeID = null;
            StudentCount = 0;
            CreatedByUserID = null;
            CreationDate = DateTime.Now;
            LastModifiedDate = null;
            IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsGroup(int? groupID, string groupName, int? classID,
            int? teacherID, int? subjectTeacherID, int? meetingTimeID,
            int? studentCount, int? createdByUserID, DateTime creationDate,
             DateTime? lastModifiedDate, bool isActive)
        {
            GroupID = groupID;
            GroupName = groupName;
            ClassID = classID;
            TeacherID = teacherID;
            SubjectTeacherID = subjectTeacherID;
            MeetingTimeID = meetingTimeID;
            StudentCount = studentCount;
            CreatedByUserID = createdByUserID;
            CreationDate = creationDate;
            LastModifiedDate = lastModifiedDate;
            IsActive = isActive;

            ClassInfo = clsClasses.Find(classID);
            TeacherInfo = clsTeacher.FindByTeacherID(teacherID);
            SubjectTeacherInfo = clsSubjectTeacher.Find(subjectTeacherID);
            MeetingTimeInfo = clsMeetingTime.Find(meetingTimeID);
            CreatedByUserInfo = createdByUserID.HasValue ? ClsUser._FindByPersonID(createdByUserID.Value) : null;

            Mode = enMode.Update;
        }


        public static clsGroup Find(int? groupID)
        {
            string groupName = string.Empty;
            int? classID = null;
            int? teacherID = null;
            int? subjectTeacherID = null;
            int? meetingTimeID = null;
            int? studentCount = 0;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;
            DateTime? lastModifiedDate = null;
            bool isActive = true;

            bool isFound = clsGroupData.GetInfoByID(groupID, ref groupName,
                ref classID, ref teacherID, ref subjectTeacherID,
                ref meetingTimeID, ref studentCount,
                ref createdByUserID, ref creationDate,
                ref lastModifiedDate, ref isActive);

            return (isFound) ? (new clsGroup(groupID, groupName, classID,
                                teacherID, subjectTeacherID, meetingTimeID,
                                studentCount, createdByUserID, creationDate,
                                lastModifiedDate, isActive))
                             : null;
        }


        private bool _Add()
        {
            if (!ClassID.HasValue || !TeacherID.HasValue || !SubjectTeacherID.HasValue ||
                !MeetingTimeID.HasValue || !CreatedByUserID.HasValue)
            {
                return false;
            }

            GroupID = clsGroupData.Add(ClassID.Value, TeacherID.Value, SubjectTeacherID.Value,
                MeetingTimeID.Value, CreatedByUserID.Value);

            return GroupID.HasValue;
        }


        private bool _Update()
        {
            return clsGroupData.Update(GroupID.Value, ClassID.Value, TeacherID.Value,
                SubjectTeacherID.Value, MeetingTimeID.Value, IsActive);
        }

        public bool Save()
        {
            //if (!_ValidateUsingHelperClass())
            //{
            //    return false;
            //}

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


        public static DataTable GetTodaySchedule()
        {
            return clsGroupData.GetScheduleForToday();
        }

        public static DataTable GetAllStudentsInGroup(int groupID)
        {
            return clsGroupData.GetAllStudentsInGroup(groupID);
        }

        public static DataTable GetAllGroupsDetails()
        {
            return clsGroupData.GetAllGroupsDetails();
        }

        public static DataTable GetAllGroupName()
        {
            return clsGroupData.GetAllGroupName();
        }

        public static decimal GetSubjectFeesByGroupID(int? groupID)
            => clsGroupData.GetSubjectFeesByGroupID(groupID);


        public string GetStudentCount()
            => StudentCount.ToString() + "/" + ClassInfo?.Capacity
            + ((StudentCount <= 1) ? "  Student" : "  Students");
    }
}
