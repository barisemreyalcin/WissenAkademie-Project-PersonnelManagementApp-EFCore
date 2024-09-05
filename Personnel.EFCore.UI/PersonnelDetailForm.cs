using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel.EFCore.BAL;
using Personnel.EFCore.Domain;
using PersonnelDomain = Personnel.EFCore.Domain;

namespace Personnel.EFCore.UI
{
    public partial class PersonnelDetailForm : Form
    {
        private PersonnelDomain.Personnel _personnel;

        public PersonnelDetailForm(PersonnelDomain.Personnel personnel)
        {
            InitializeComponent();
            _personnel = personnel;
            ShowPersonnelDetails(_personnel);
        }

        private void ShowPersonnelDetails(PersonnelDomain.Personnel personnel)
        {
            txtFirstNameDetail.Text = personnel.FirstName;
            txtLastNameDetail.Text = personnel.LastName;
            txtIdentityNumberDetail.Text = personnel.IdentityNumber;
            dtpBirthDateDetail.Value = personnel.BirthDate ?? DateTime.Today;
            if (personnel.Gender)
            {
                rbtnMaleDetail.Checked = true;
            }
            else
            {
                rbtnFemaleDetail.Checked = true;
            }
            txtDepartmentDetail.Text = personnel.Department;
            chkIsActiveDetail.Checked = personnel.IsActive;

            txtEmailDetail.Text = personnel.PersonnelDetail?.Email;
            txtPhoneDetail.Text = personnel.PersonnelDetail?.Phone;
            rtxtAddressDetail.Text = personnel.PersonnelDetail?.Address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var gender = rbtnMaleDetail.Checked ? true : false;

            _personnel.FirstName = txtFirstNameDetail.Text;
            _personnel.LastName = txtLastNameDetail.Text;
            _personnel.IdentityNumber = txtIdentityNumberDetail.Text;
            _personnel.BirthDate = dtpBirthDateDetail.Value;
            _personnel.Gender = gender;
            _personnel.Department = txtDepartmentDetail.Text;
            _personnel.IsActive = chkIsActiveDetail.Checked;

            if (_personnel.PersonnelDetail == null)
            {
                _personnel.PersonnelDetail = new PersonnelDomain.PersonnelDetail();
            }

            _personnel.PersonnelDetail.Email = txtEmailDetail.Text;
            _personnel.PersonnelDetail.Phone = txtPhoneDetail.Text;
            _personnel.PersonnelDetail.Address = rtxtAddressDetail.Text;

            PersonnelOperations personnelOperations = new PersonnelOperations();
            personnelOperations.UpdatePersonnel(_personnel);
            MessageBox.Show("Personnel updated successfully :)");
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PersonnelOperations personnelOperations = new PersonnelOperations();
            personnelOperations.DeletePersonnel(_personnel.PersonnelID);
            MessageBox.Show("Personnel deleted successfully :)");
            this.Close();
        }
    }
}
