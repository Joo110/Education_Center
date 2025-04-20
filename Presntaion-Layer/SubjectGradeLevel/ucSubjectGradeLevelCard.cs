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

namespace Educational_Center.SubjectGradeLevel
{
    public partial class ucSubjectGradeLevelCard : UserControl
    {
        clsSubjectGradeLevel _subjectGradeLevel;
        int? _SubjectGradeID;

        public ucSubjectGradeLevelCard()
        {
            InitializeComponent();
        }

        private void _FillStudentData()
        {
            lblSubjectGradeLevelID.Text = _subjectGradeLevel.SubjectGradeLevelID.ToString();
            lblSubjectID.Text = _subjectGradeLevel.SubjectID.ToString();
            lblGradeLevelID.Text = _subjectGradeLevel.GradeLevelID.ToString();
            lblFees.Text = $"{_subjectGradeLevel.Fees:C2}";
            lblSubjectName.Text = _subjectGradeLevel.SubjectInfo.SubjectName;
            lblGradeLevelName.Text = _subjectGradeLevel.GradeLevelInfo.GradeName;
            lblDescription.Text = string.IsNullOrWhiteSpace(_subjectGradeLevel.Description)
                                  ? "N/A"
                                  : _subjectGradeLevel.Description;

            llWhoTeachesIt.Enabled = true;
        }

        public void Reset()
        {
            _SubjectGradeID = -1;
            _subjectGradeLevel = null;

            lblSubjectGradeLevelID.Text = "[????]";
            lblSubjectID.Text = "[????]";
            lblGradeLevelID.Text = "[????]";
            lblFees.Text = "[????]";
            lblSubjectName.Text = "[????]";
            lblGradeLevelName.Text = "[????]";
            lblDescription.Text = "[????]";

            llWhoTeachesIt.Enabled = false;
        }

        public void LoadSubjectGradeLevelInfo(int? subjectGradeLevelID)
        {
            _SubjectGradeID = subjectGradeLevelID;

            if (!_SubjectGradeID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("Subject-GradeLevel", _SubjectGradeID);

                Reset();

                return;
            }

            _subjectGradeLevel = clsSubjectGradeLevel.Find(_SubjectGradeID);

            if (_subjectGradeLevel == null)
            {
                clsStandardMessages.ShowMissingDataMessage("Subject-GradeLevel", _SubjectGradeID);

                Reset();

                return;
            }

            _FillStudentData();
        }
    }
}
