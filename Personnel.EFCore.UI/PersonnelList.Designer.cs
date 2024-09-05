namespace Personnel.EFCore.UI
{
    partial class PersonnelList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersonnels = new DataGridView();
            btnSearch = new Button();
            label1 = new Label();
            txtPersonnelID = new TextBox();
            btnRefreshList = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonnels
            // 
            dgvPersonnels.AllowUserToOrderColumns = true;
            dgvPersonnels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnels.Dock = DockStyle.Bottom;
            dgvPersonnels.Location = new Point(0, 122);
            dgvPersonnels.Name = "dgvPersonnels";
            dgvPersonnels.RowHeadersWidth = 51;
            dgvPersonnels.Size = new Size(800, 328);
            dgvPersonnels.TabIndex = 0;
            dgvPersonnels.CellDoubleClick += dgvPersonnels_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(258, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Personnel ID:";
            // 
            // txtPersonnelID
            // 
            txtPersonnelID.Location = new Point(158, 43);
            txtPersonnelID.Name = "txtPersonnelID";
            txtPersonnelID.Size = new Size(94, 27);
            txtPersonnelID.TabIndex = 3;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new Point(663, 40);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(111, 35);
            btnRefreshList.TabIndex = 4;
            btnRefreshList.Text = "Refresh List";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(422, 39);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 6;
            button1.Text = "Add Personnel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PersonnelList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRefreshList);
            Controls.Add(txtPersonnelID);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(dgvPersonnels);
            Name = "PersonnelList";
            Text = "PersonnelList";
            Load += PersonnelList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonnels;
        private Button btnSearch;
        private Label label1;
        private TextBox txtPersonnelID;
        private Button btnRefreshList;
        private Button button1;
    }
}