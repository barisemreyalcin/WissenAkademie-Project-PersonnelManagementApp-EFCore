namespace Personnel.EFCore.UI
{
    partial class PersonnelDetailForm
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
            txtDepartmentDetail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            rtxtAddressDetail = new RichTextBox();
            txtPhoneDetail = new TextBox();
            label8 = new Label();
            txtEmailDetail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            chkIsActiveDetail = new CheckBox();
            btnUpdate = new Button();
            label5 = new Label();
            rbtnFemaleDetail = new RadioButton();
            rbtnMaleDetail = new RadioButton();
            dtpBirthDateDetail = new DateTimePicker();
            label4 = new Label();
            txtIdentityNumberDetail = new TextBox();
            label3 = new Label();
            txtLastNameDetail = new TextBox();
            label2 = new Label();
            txtFirstNameDetail = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDepartmentDetail
            // 
            txtDepartmentDetail.Location = new Point(172, 231);
            txtDepartmentDetail.Name = "txtDepartmentDetail";
            txtDepartmentDetail.Size = new Size(293, 27);
            txtDepartmentDetail.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 234);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 42;
            label10.Text = "Department:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 456);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 41;
            label9.Text = "Address:";
            // 
            // rtxtAddressDetail
            // 
            rtxtAddressDetail.Location = new Point(172, 453);
            rtxtAddressDetail.Name = "rtxtAddressDetail";
            rtxtAddressDetail.Size = new Size(293, 120);
            rtxtAddressDetail.TabIndex = 40;
            rtxtAddressDetail.Text = "";
            // 
            // txtPhoneDetail
            // 
            txtPhoneDetail.Location = new Point(172, 407);
            txtPhoneDetail.Name = "txtPhoneDetail";
            txtPhoneDetail.Size = new Size(293, 27);
            txtPhoneDetail.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 410);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 38;
            label8.Text = "Phone:";
            // 
            // txtEmailDetail
            // 
            txtEmailDetail.Location = new Point(172, 361);
            txtEmailDetail.Name = "txtEmailDetail";
            txtEmailDetail.Size = new Size(293, 27);
            txtEmailDetail.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 364);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 36;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 320);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 35;
            label6.Text = "Status:";
            // 
            // chkIsActiveDetail
            // 
            chkIsActiveDetail.AutoSize = true;
            chkIsActiveDetail.Location = new Point(172, 320);
            chkIsActiveDetail.Name = "chkIsActiveDetail";
            chkIsActiveDetail.Size = new Size(72, 24);
            chkIsActiveDetail.TabIndex = 34;
            chkIsActiveDetail.Text = "Active";
            chkIsActiveDetail.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(172, 594);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 41);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 279);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 32;
            label5.Text = "Gender:";
            // 
            // rbtnFemaleDetail
            // 
            rbtnFemaleDetail.AutoSize = true;
            rbtnFemaleDetail.Location = new Point(296, 277);
            rbtnFemaleDetail.Name = "rbtnFemaleDetail";
            rbtnFemaleDetail.Size = new Size(78, 24);
            rbtnFemaleDetail.TabIndex = 31;
            rbtnFemaleDetail.TabStop = true;
            rbtnFemaleDetail.Text = "Female";
            rbtnFemaleDetail.UseVisualStyleBackColor = true;
            // 
            // rbtnMaleDetail
            // 
            rbtnMaleDetail.AutoSize = true;
            rbtnMaleDetail.Location = new Point(172, 277);
            rbtnMaleDetail.Name = "rbtnMaleDetail";
            rbtnMaleDetail.Size = new Size(63, 24);
            rbtnMaleDetail.TabIndex = 30;
            rbtnMaleDetail.TabStop = true;
            rbtnMaleDetail.Text = "Male";
            rbtnMaleDetail.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDateDetail
            // 
            dtpBirthDateDetail.Location = new Point(172, 181);
            dtpBirthDateDetail.Name = "dtpBirthDateDetail";
            dtpBirthDateDetail.Size = new Size(293, 27);
            dtpBirthDateDetail.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 186);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 28;
            label4.Text = "Birth Date:";
            // 
            // txtIdentityNumberDetail
            // 
            txtIdentityNumberDetail.Location = new Point(172, 131);
            txtIdentityNumberDetail.Name = "txtIdentityNumberDetail";
            txtIdentityNumberDetail.Size = new Size(293, 27);
            txtIdentityNumberDetail.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 26;
            label3.Text = "Identity Number:";
            // 
            // txtLastNameDetail
            // 
            txtLastNameDetail.Location = new Point(172, 81);
            txtLastNameDetail.Name = "txtLastNameDetail";
            txtLastNameDetail.Size = new Size(293, 27);
            txtLastNameDetail.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 24;
            label2.Text = "Last Name:";
            // 
            // txtFirstNameDetail
            // 
            txtFirstNameDetail.Location = new Point(172, 32);
            txtFirstNameDetail.Name = "txtFirstNameDetail";
            txtFirstNameDetail.Size = new Size(293, 27);
            txtFirstNameDetail.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 22;
            label1.Text = "First Name:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 594);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 41);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PersonnelDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 667);
            Controls.Add(btnDelete);
            Controls.Add(txtDepartmentDetail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(rtxtAddressDetail);
            Controls.Add(txtPhoneDetail);
            Controls.Add(label8);
            Controls.Add(txtEmailDetail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(chkIsActiveDetail);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(rbtnFemaleDetail);
            Controls.Add(rbtnMaleDetail);
            Controls.Add(dtpBirthDateDetail);
            Controls.Add(label4);
            Controls.Add(txtIdentityNumberDetail);
            Controls.Add(label3);
            Controls.Add(txtLastNameDetail);
            Controls.Add(label2);
            Controls.Add(txtFirstNameDetail);
            Controls.Add(label1);
            Name = "PersonnelDetailForm";
            Text = "PersonnelDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepartmentDetail;
        private Label label10;
        private Label label9;
        private RichTextBox rtxtAddressDetail;
        private TextBox txtPhoneDetail;
        private Label label8;
        private TextBox txtEmailDetail;
        private Label label7;
        private Label label6;
        private CheckBox chkIsActiveDetail;
        private Button btnUpdate;
        private Label label5;
        private RadioButton rbtnFemaleDetail;
        private RadioButton rbtnMaleDetail;
        private DateTimePicker dtpBirthDateDetail;
        private Label label4;
        private TextBox txtIdentityNumberDetail;
        private Label label3;
        private TextBox txtLastNameDetail;
        private Label label2;
        private TextBox txtFirstNameDetail;
        private Label label1;
        private Button btnDelete;
    }
}