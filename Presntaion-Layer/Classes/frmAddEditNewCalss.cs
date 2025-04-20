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

namespace Educational_Center.Classes
{
    public partial class frmAddEditNewCalss : Form
    {
        public Action<int?> ClassIDBack;

        private enum _enMode { Add, Update };
        private _enMode _mode = _enMode.Add;

        private int? _classID = null;
        private clsClasses _class = null;

        public frmAddEditNewCalss()
        {
            InitializeComponent();
        }

        public frmAddEditNewCalss(int? classID)
        {
            InitializeComponent();

            _classID = classID;
            _mode = _enMode.Update;
        }


        private void _ResetFields()
        {
            txtClassName.Clear();
            numericUpDown1.Value = 1;
            txtDescription.Clear();
        }

        private void _ResetDefaultValues()
        {
            if (_mode == _enMode.Add)
            {
                lblTitle.Text = "Add New Class";
                _class = new clsClasses();
                _ResetFields();
            }
            else
            {
                lblTitle.Text = "Update Class";
            }

            this.Text = lblTitle.Text;
        }

        private void _FillFieldsWithClassInfo()
        {
            lblClassID.Text = _class.ClassID.ToString();
            txtClassName.Text = _class.ClassName;
            numericUpDown1.Value = _class.Capacity;
            txtDescription.Text = _class.Description ?? "N/A";
        }

        private void _LoadData()
        {
            _class = clsClasses.Find(_classID);

            if (_class == null)
            {
                clsStandardMessages.ShowMissingDataMessage("class", _classID);

                this.Close();
                return;
            }

            _FillFieldsWithClassInfo();
        }

        private void _FillClassObjectWithFieldsData()
        {
            _class.ClassName = txtClassName.Text.Trim();
            _class.Capacity = (byte)numericUpDown1.Value;
            _class.Description = txtDescription.Text.Trim();
        }

        private void _SaveClass()
        {
            _FillClassObjectWithFieldsData();

            if (_class.Save())
            {
                lblTitle.Text = "Update Class";
                this.Text = lblTitle.Text;
                lblClassID.Text = _class.ClassID.ToString();

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("Class");

                // Trigger the event to send data back to the caller form
                ClassIDBack?.Invoke(_class?.ClassID);
            }
            else
            {
                clsStandardMessages.ShowError("class");
            }
        }

        private void txtClassName_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtClassName.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtClassName, "This field is required!");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.SetError(txtClassName, null);
            //}

            //if ((_class?.ClassName.ToLower() != txtClassName.Text.Trim().ToLower()) &&
            //    clsClasses.Exists(txtClassName.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtClassName, "This class already exists! choose another one.");
            //}
            //else
            //{
            //    errorProvider1.SetError(txtClassName, null);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            _SaveClass();
        }

        private void frmAddEditNewCalss_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == _enMode.Update)
                _LoadData();
        }

        private void llEditClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditNewCalss frmAddEditNewCalss = new frmAddEditNewCalss();
            frmAddEditNewCalss.ShowDialog();
        }
    }
}
