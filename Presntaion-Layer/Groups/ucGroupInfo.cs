using DataBusiness_EC_;
using Educational_Center.Classes;
using Educational_Center.GlobalClasses;
using Educational_Center.Properties;
using Educational_Center.SubjectGradeLevel;
using Educational_Center.Teachers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Center.Groups
{
    public partial class ucGroupInfo : UserControl
    {
        private int? _groupID = null;
        private clsGroup _group = null;

        public int? groupID => _groupID;
        public clsGroup groupInfo => _group;

        public ucGroupInfo()
        {
            InitializeComponent();
        }

        private void _FillStudentData()
        {
            llShowClassInfo.Enabled = true;
            llShowTeacherInfo.Enabled = true;
            llShowSubjectGradeLevelInfo.Enabled = true;

            lblGroupID.Text = _group.GroupID.ToString();
            lblTeacherID.Text = _group.TeacherID.ToString();
            lblClassID.Text = _group.ClassID.ToString();
            lblSubjectGradeLevelID.Text = _group.SubjectTeacherInfo?.SubjectGradeLevelID.ToString();
            lblMeetingTime.Text = _group.MeetingTimeInfo.MeetingTimeText();
            lblStudentsCount.Text = _group.GetStudentCount();
            lblCreatedByUsername.Text = _group.CreatedByUserInfo.UserName;
            lblCreationDate.Text = clsFormat.DateToShort(_group.CreationDate);
            lblIsActive.Text = (_group.IsActive) ? "Yes" : "No";
            pbIsActive.Image = (_group.IsActive) ? Resources.confirm_32 : Resources.close_48;
        }

        public void Reset()
        {
            _groupID = null;
            _group = null;

            lblGroupID.Text = "[????]";
            lblTeacherID.Text = "[????]";
            lblClassID.Text = "[????]";
            lblSubjectGradeLevelID.Text = "[????]";
            lblMeetingTime.Text = "[????]";
            lblStudentsCount.Text = "[????]";
            lblCreatedByUsername.Text = "[????]";
            lblCreationDate.Text = "[????]";
            lblIsActive.Text = "[????]";

            llShowClassInfo.Enabled = false;
            llShowTeacherInfo.Enabled = false;
            llShowSubjectGradeLevelInfo.Enabled = false;
        }

        public void LoadGroupInfo(int? groupID)
        {
            _groupID = groupID;

            if (!_groupID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("group", _groupID);

                Reset();

                return;
            }

            _group = clsGroup.Find(_groupID);

            if (_group == null)
            {
                clsStandardMessages.ShowMissingDataMessage("group", _groupID);

                Reset();

                return;
            }

            _FillStudentData();
        }

        private void llShowSubjectGradeLevelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowSubjectGradeLevelInfo showSubjectGradeLevelInfo = new ShowSubjectGradeLevelInfo(_group.SubjectTeacherID);
            showSubjectGradeLevelInfo.ShowDialog();
        }

        private void llShowClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowClassesDetails frm = new frmShowClassesDetails(_group.ClassID);
            frm.ShowDialog();
        }

        private void llShowTeacherInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTeacherInfo frmShowTeacherInfo = new frmShowTeacherInfo(_group.TeacherID.GetValueOrDefault());
            frmShowTeacherInfo.ShowDialog();
        }
    }
}
