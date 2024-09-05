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

namespace Personnel.EFCore.UI
{

    public partial class AddPersonnelForm : Form
    {
        private PersonnelOperations personnelOperations;
        public AddPersonnelForm()
        {
            InitializeComponent();
            personnelOperations = new PersonnelOperations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var gender = rbtnMale.Checked ? true : false;

            var personnel = new Personnel.EFCore.Domain.Personnel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                IdentityNumber = txtIdentityNumber.Text,
                BirthDate = dtpBirthDate.Value,
                Gender = gender,
                Department = txtDepartment.Text,
                IsActive = chkIsActive.Checked,
                PersonnelDetail = new PersonnelDetail
                {
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = rtxtAddress.Text
                }
            };

            personnelOperations.CreatePersonnel(personnel);
            MessageBox.Show("Personnel added successfully :)");
            this.Close();
        }
    }
}
