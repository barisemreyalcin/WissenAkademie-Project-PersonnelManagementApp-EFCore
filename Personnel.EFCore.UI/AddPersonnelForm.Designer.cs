namespace Personnel.EFCore.UI
{
    partial class AddPersonnelForm
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
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtIdentityNumber = new TextBox();
            label4 = new Label();
            dtpBirthDate = new DateTimePicker();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            label5 = new Label();
            btnSave = new Button();
            chkIsActive = new CheckBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            rtxtAddress = new RichTextBox();
            label9 = new Label();
            txtDepartment = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(157, 22);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(293, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 74);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(157, 71);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(293, 27);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 121);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Identity Number:";
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.Location = new Point(157, 121);
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.Size = new Size(293, 27);
            txtIdentityNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 176);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Birth Date:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(157, 171);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(293, 27);
            dtpBirthDate.TabIndex = 7;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(157, 267);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 8;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(281, 267);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 9;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 269);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(157, 584);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(293, 41);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(157, 310);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(72, 24);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 310);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 351);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 27);
            txtEmail.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 354);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(157, 397);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(293, 27);
            txtPhone.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 400);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 16;
            label8.Text = "Phone:";
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(157, 443);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(293, 120);
            rtxtAddress.TabIndex = 18;
            rtxtAddress.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 446);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 19;
            label9.Text = "Address:";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(157, 221);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(293, 27);
            txtDepartment.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 224);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 20;
            label10.Text = "Department:";
            // 
            // AddPersonnelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 650);
            Controls.Add(txtDepartment);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(rtxtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(chkIsActive);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(rbtnFemale);
            Controls.Add(rbtnMale);
            Controls.Add(dtpBirthDate);
            Controls.Add(label4);
            Controls.Add(txtIdentityNumber);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "AddPersonnelForm";
            Text = "AddPersonnelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtIdentityNumber;
        private Label label4;
        private DateTimePicker dtpBirthDate;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Label label5;
        private Button btnSave;
        private CheckBox chkIsActive;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private RichTextBox rtxtAddress;
        private Label label9;
        private TextBox txtDepartment;
        private Label label10;
    }
}