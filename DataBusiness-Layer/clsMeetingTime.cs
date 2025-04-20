using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsMeetingTime
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MeetingTimeID { get; set; }

        private TimeSpan _oldStartTime = TimeSpan.Zero;
        private TimeSpan _startTime = TimeSpan.Zero;
        public TimeSpan StartTime
        {
            get => _startTime;

            set
            {
                if (_oldStartTime != TimeSpan.Zero)
                {
                    _oldStartTime = _startTime;
                }

                _startTime = value;
            }
        }

        public DateTime NumberDate;

        public TimeSpan EndTime { get; set; }

        private byte? _oldMeetingDays = null;
        private byte? _meetingDays = null;
        public string MeetingDays = null;
        

        public clsMeetingTime()
        {
            MeetingTimeID = null;
            StartTime = DateTime.Now.TimeOfDay;
            EndTime = DateTime.Now.TimeOfDay;
            MeetingDays = null;

            Mode = enMode.AddNew;
        }

        private clsMeetingTime(int? meetingTimeID, TimeSpan startTime, TimeSpan endTime, string meetingDays)
        {
            MeetingTimeID = meetingTimeID;
            StartTime = startTime;
            EndTime = endTime;
            MeetingDays = meetingDays;

            Mode = enMode.Update;
        }


        public static clsMeetingTime Find(int? meetingTimeID)
        {
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            string meetingDays = null;
            DateTime NumberDate = DateTime.Now;

            bool isFound = clsMeetingTimeData.GetInfoByID(meetingTimeID, ref startTime, ref endTime, ref meetingDays, ref NumberDate);

            return (isFound) ? (new clsMeetingTime(meetingTimeID, startTime, endTime, meetingDays)) : null;
        }

        public static DataTable GetAllMeetingTimeDetails()
        {
            return clsMeetingTimeData.GetAllMeetingTimeDetails();
        }


        private bool _Add()
        {
            MeetingTimeID = clsMeetingTimeData.Add(StartTime, EndTime, MeetingDays, NumberDate);

            return (MeetingTimeID.HasValue);
        }

        private bool _Update()
        {
            return clsMeetingTimeData.Update(MeetingTimeID.Value, StartTime, EndTime, MeetingDays, NumberDate);
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

        public static bool Exists(TimeSpan startTime, DateTime numberDate)
        {
            return clsMeetingTimeData.DoesMeetingTimeExist(startTime, numberDate);
        }


        public static string MeetingDayText(byte meetingDayIndex)
        {
            switch (meetingDayIndex)
            {
                case 0:
                    return "Daily";
                case 1:
                    return "STT";
                case 2:
                    return "MW";
                default:
                    return "Unknown";
            }
        }

        public static byte MeetingDayIndex(string meetingDayName)
        {
            switch (meetingDayName.ToUpper())
            {
                case "DAILY":
                    return 0;
                case "STT":
                    return 1;
                case "MW":
                    return 2;
                default:
                    return 0;
            }
        }

            public string MeetingTimeText()
        => $"{StartTime.Hours.ToString("00")}:{StartTime.Minutes.ToString("00")} - " +
           $"{EndTime.Hours.ToString("00")}:{EndTime.Minutes.ToString("00")}   " +
           $"{MeetingDayText(MeetingDayIndex(MeetingDays))}";
    }

}

