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
using PersonnelDomain = Personnel.EFCore.Domain;

namespace Personnel.EFCore.UI
{
    public partial class PersonnelList : Form
    {
        private PersonnelOperations personnelOperations;
        private PersonnelDomain.Personnel selectedPersonnel;

        public PersonnelList()
        {
            InitializeComponent();
        }

        private void PersonnelList_Load(object sender, EventArgs e)
        {
            personnelOperations = new PersonnelOperations();
            LoadPersonnelData();
        }

        private void LoadPersonnelData()
        {
            //List<Personnel.EFCore.Domain.Personnel> personnels = personnelOperations.GetPersonnels();
            //dgvPersonnels.DataSource = personnels;

            var personnels = personnelOperations.GetPersonnels(); // Personelleri yükle
            dgvPersonnels.DataSource = personnels.Select(p => new
            {
                p.PersonnelID,
                p.FirstName,
                p.LastName,
                p.IdentityNumber,
                p.BirthDate,
                p.Gender,
                p.Department,
                p.IsActive,
                p.FullName,
                p.PersonnelDetail?.PersonnelDetailID,
                p.PersonnelDetail?.Email,
                p.PersonnelDetail?.Phone,
                p.PersonnelDetail?.Address
            }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPersonnelForm addPersonnelForm = new AddPersonnelForm();
            addPersonnelForm.ShowDialog();
            LoadPersonnelData();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadPersonnelData();
        }

        private void dgvPersonnels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int personnelId = (int)dgvPersonnels.Rows[e.RowIndex].Cells["PersonnelID"].Value;
                PersonnelDomain.Personnel selectedPersonnel = personnelOperations.GetPersonnelWithDetails(personnelId);

                PersonnelDetailForm detailForm = new PersonnelDetailForm(selectedPersonnel);
                detailForm.ShowDialog();
                LoadPersonnelData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPersonnelById();
        }

        private void SearchPersonnelById()
        {
            if (int.TryParse(txtPersonnelID.Text, out int personnelId))
            {
                var personnel = personnelOperations.GetPersonnelWithDetails(personnelId);
                if (personnel != null)
                {
                    dgvPersonnels.DataSource = new List<object> {
                        new {
                            personnel.PersonnelID,
                            personnel.FirstName,
                            personnel.LastName,
                            personnel.IdentityNumber,
                            personnel.BirthDate,
                            personnel.Gender,
                            personnel.Department,
                            personnel.IsActive,
                            personnel.FullName,
                            personnel.PersonnelDetail?.PersonnelDetailID,
                            personnel.PersonnelDetail?.Email,
                            personnel.PersonnelDetail?.Phone,
                            personnel.PersonnelDetail?.Address
                        }
                    };
                }
                else
                {
                    MessageBox.Show("Personnel not found :(");
                    LoadPersonnelData();
                }
            }
            else
            {
                MessageBox.Show("Invalid Personnel ID :(");
                LoadPersonnelData();
            }
        }
    }
}
