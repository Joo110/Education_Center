using DataBusiness_EC_;
using Educational_Center.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.MettingTimes
{
    public partial class frmAddEditMeetingTime : Form
    {
        private enum _enMode { Add, Update };
        private _enMode _mode = _enMode.Add;

        private int? _meetingTimeID = null;
        clsMeetingTime _Time;

        public frmAddEditMeetingTime()
        {
            InitializeComponent();
            _mode = _enMode.Add;
            _Time = new clsMeetingTime();
        }

        public frmAddEditMeetingTime(int meetingTimeID)
        {
            InitializeComponent();
            _mode = _enMode.Update;
            _meetingTimeID = meetingTimeID;

            //_LoadMeetingTimeData();
        }

        //private void _LoadMeetingTimeData()
        //{
        //    if (_meetingTimeID == null) return;

        //    _Time = clsMeetingTime.GetByID(_meetingTimeID.Value);
        //    if (_Time != null)
        //    {
        //        dtpStartTime.Value = DateTime.Today.Add(_Time.StartTime);
        //        guna2DTPEndTime.Value = DateTime.Today.Add(_Time.EndTime);
        //        cbMeetingDays.Text = _Time.MeetingDays ?? "";
        //        guna2DateTimePicker1.Value = _Time.NumberDate;
        //    }
        //    else
        //    {
        //        MessageBox.Show("لم يتم العثور على الاجتماع!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.Close();
        //    }
        //}

        private TimeSpan _GetTimeFromDateTimePickerOfStartingTime()
        {
            if (dtpStartTime == null) throw new NullReferenceException("dtpStartTime غير مهيأ!");
            return new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
        }

        private TimeSpan _GetTimeFromDateTimePickerOfEndTime()
        {
            if (guna2DTPEndTime == null) throw new NullReferenceException("guna2DTPEndTime غير مهيأ!");
            return new TimeSpan(guna2DTPEndTime.Value.Hour, guna2DTPEndTime.Value.Minute, 0);
        }

        private void _FillMeetingTimeObjectWithFieldsData()
        {
            if (_Time == null) _Time = new clsMeetingTime();

            _Time.StartTime = _GetTimeFromDateTimePickerOfStartingTime();
            _Time.EndTime = _GetTimeFromDateTimePickerOfEndTime();
            _Time.MeetingDays = cbMeetingDays?.Text ?? "";
            _Time.NumberDate = guna2DateTimePicker1?.Value ?? DateTime.Now;
        }

        private void _SaveMeetingTime()
        {
            _FillMeetingTimeObjectWithFieldsData();

            if (_Time.Save())
            {
                lblTitle.Text = "Update MeetingTime";
                this.Text = lblTitle.Text;
                lblMeetingTimeID.Text = _Time.MeetingTimeID.ToString();

                _mode = _enMode.Update;
                clsStandardMessages.ShowSuccess("MeetingTime");
            }
            else
            {
                clsStandardMessages.ShowError("MeetingTime");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpStartTime == null || guna2DateTimePicker1 == null)
            {
                MessageBox.Show("Not Found", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsMeetingTime.Exists(dtpStartTime.Value.TimeOfDay, guna2DateTimePicker1.Value))
            {
                MessageBox.Show("A meeting is already scheduled at this time. Please choose a different start time.",
                                "Meeting Time Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveMeetingTime();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}