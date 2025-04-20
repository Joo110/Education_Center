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
    public partial class ucShowClassesDeatails : UserControl
    {

        private int? _classID = null;
        private clsClasses _class = null;

        public int? ClassID => _classID;
        public clsClasses ClassInfo => _class;

        public ucShowClassesDeatails()
        {
            InitializeComponent();
        }

        private void _FillStudentData()
        {
            llEditClassInfo.Enabled = true;

            lblClassID.Text = _class.ClassID.ToString();
            lblClassName.Text = _class.ClassName;
            lblCapacity.Text = _class.Capacity.ToString();

            lblDescription.Text = (string.IsNullOrWhiteSpace(_class.Description))
                                       ? "N/A" : _class.Description;

        }

        public void Reset()
        {
            _classID = null;
            _class = null;

            lblClassID.Text = "[????]";
            lblClassName.Text = "[????]";
            lblCapacity.Text = "[????]";
            lblDescription.Text = "[????]";

            llEditClassInfo.Enabled = false;
        }

        public void LoadClassInfo(int? classID)
        {
            _classID = classID;

            if (!_classID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("class", _classID);

                Reset();

                return;
            }

            _class = clsClasses.Find(_classID);

            if (_class == null)
            {
                clsStandardMessages.ShowMissingDataMessage("class", _classID);

                Reset();

                return;
            }

            _FillStudentData();
        }

        private void llEditClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditNewCalss f = new frmAddEditNewCalss(_classID);
            f.ShowDialog();
        }
    }
}
