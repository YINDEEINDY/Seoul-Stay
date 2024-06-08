namespace Seoul_Stay
{
    partial class Create_Account_Form
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
            groupBox1 = new GroupBox();
            linkLabelViewTeam = new LinkLabel();
            txtRetypePw = new TextBox();
            label6 = new Label();
            numericUpDownMember = new NumericUpDown();
            label5 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            termsCheckBox = new CheckBox();
            dtpBirthday = new DateTimePicker();
            txtPw = new TextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegister = new Button();
            btnReturnlogin = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMember).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelViewTeam);
            groupBox1.Controls.Add(txtRetypePw);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownMember);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(termsCheckBox);
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(txtPw);
            groupBox1.Controls.Add(txtFullname);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Gotham Thin", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your Information";
            // 
            // linkLabelViewTeam
            // 
            linkLabelViewTeam.AutoSize = true;
            linkLabelViewTeam.Location = new Point(459, 263);
            linkLabelViewTeam.Name = "linkLabelViewTeam";
            linkLabelViewTeam.Size = new Size(215, 16);
            linkLabelViewTeam.TabIndex = 15;
            linkLabelViewTeam.TabStop = true;
            linkLabelViewTeam.Text = "View Terms and Conditions";
            linkLabelViewTeam.LinkClicked += linkLabelViewTeam_LinkClicked;
            // 
            // txtRetypePw
            // 
            txtRetypePw.Location = new Point(527, 198);
            txtRetypePw.Multiline = true;
            txtRetypePw.Name = "txtRetypePw";
            txtRetypePw.Size = new Size(227, 20);
            txtRetypePw.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 198);
            label6.Name = "label6";
            label6.Size = new Size(144, 16);
            label6.TabIndex = 13;
            label6.Text = "Retype PAssword:";
            // 
            // numericUpDownMember
            // 
            numericUpDownMember.Location = new Point(646, 90);
            numericUpDownMember.Name = "numericUpDownMember";
            numericUpDownMember.Size = new Size(59, 23);
            numericUpDownMember.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 94);
            label5.Name = "label5";
            label5.Size = new Size(210, 16);
            label5.TabIndex = 11;
            label5.Text = "Number of Family Member:";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(527, 46);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 20);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(430, 46);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(60, 20);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // termsCheckBox
            // 
            termsCheckBox.AutoSize = true;
            termsCheckBox.Location = new Point(46, 259);
            termsCheckBox.Name = "termsCheckBox";
            termsCheckBox.Size = new Size(307, 20);
            termsCheckBox.TabIndex = 8;
            termsCheckBox.Text = "I agree to the Teams and Conditions.";
            termsCheckBox.UseVisualStyleBackColor = true;
            termsCheckBox.CheckedChanged += termsCheckBox_CheckedChanged;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(126, 140);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(227, 23);
            dtpBirthday.TabIndex = 7;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(126, 194);
            txtPw.Multiline = true;
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(227, 20);
            txtPw.TabIndex = 6;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(126, 90);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(227, 20);
            txtFullname.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(126, 45);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 20);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 194);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 2;
            label3.Text = "Birthday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Gotham Thin", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(431, 356);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 39);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register and login";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturnlogin
            // 
            btnReturnlogin.Font = new Font("Gotham Thin", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnlogin.Location = new Point(642, 356);
            btnReturnlogin.Name = "btnReturnlogin";
            btnReturnlogin.Size = new Size(188, 39);
            btnReturnlogin.TabIndex = 2;
            btnReturnlogin.Text = "Return login form";
            btnReturnlogin.UseVisualStyleBackColor = true;
            btnReturnlogin.Click += btnReturnlogin_Click;
            // 
            // Create_Account_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 419);
            Controls.Add(btnReturnlogin);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            Name = "Create_Account_Form";
            Text = "Create_Account_from";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private CheckBox termsCheckBox;
        private DateTimePicker dtpBirthday;
        private TextBox txtPw;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtRetypePw;
        private Label label6;
        private NumericUpDown numericUpDownMember;
        private Label label5;
        private LinkLabel linkLabelViewTeam;
        private Button btnRegister;
        private Button btnReturnlogin;
    }
}