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

namespace Educational_Center.Subjects
{
    public partial class AddEditNewSubject : Form
    {

        private enum _enMode { Add, Update };
        private _enMode _mode = _enMode.Add;

        clsSubject _subject;

        public AddEditNewSubject()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillSubjectObjectWithFieldsData()
        {
            _subject = new clsSubject();
            _subject.SubjectName = textBox1.Text.ToString();
        }

        private void _SaveNewSubject()
        {
            _FillSubjectObjectWithFieldsData();
            if (_subject.Save())
            {
                lblTitle.Text = "Update Subject";
                this.Text = lblTitle.Text;
                lblSubjectID.Text = _subject.SubjectID.ToString();

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Subject");
            }
            else
            {
                clsStandardMessages.ShowError("subject");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            _SaveNewSubject();
        }
        
    }
}
