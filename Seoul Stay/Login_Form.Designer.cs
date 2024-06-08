namespace Seoul_Stay
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cbShowPw = new CheckBox();
            cbSignin = new CheckBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            txtEmployee = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            label4 = new Label();
            lbCreateone = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(273, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbShowPw);
            groupBox1.Controls.Add(cbSignin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(txtEmployee);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Gotham Thin", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 221);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // cbShowPw
            // 
            cbShowPw.AutoSize = true;
            cbShowPw.Location = new Point(464, 118);
            cbShowPw.Name = "cbShowPw";
            cbShowPw.Size = new Size(145, 20);
            cbShowPw.TabIndex = 7;
            cbShowPw.Text = "Show Password";
            cbShowPw.UseVisualStyleBackColor = true;
            cbShowPw.CheckedChanged += cbShowPw_CheckedChanged;
            // 
            // cbSignin
            // 
            cbSignin.AutoSize = true;
            cbSignin.Location = new Point(464, 56);
            cbSignin.Name = "cbSignin";
            cbSignin.Size = new Size(168, 20);
            cbSignin.TabIndex = 6;
            cbSignin.Text = "Keep me signed in";
            cbSignin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 152);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(122, 93);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(229, 23);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(122, 31);
            txtEmployee.Multiline = true;
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(229, 23);
            txtEmployee.TabIndex = 3;
            txtEmployee.TextChanged += txtEmployee_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(82, 16);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 96);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "User:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 0;
            label1.Text = "Employee:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(273, 381);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 35);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(451, 381);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 35);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 439);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 10;
            label4.Text = "Don't have an account? ";
            // 
            // lbCreateone
            // 
            lbCreateone.AutoSize = true;
            lbCreateone.Location = new Point(467, 439);
            lbCreateone.Name = "lbCreateone";
            lbCreateone.Size = new Size(90, 15);
            lbCreateone.TabIndex = 8;
            lbCreateone.TabStop = true;
            lbCreateone.Text = "Create one";
            lbCreateone.LinkClicked += lbCreateone_LinkClicked;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 473);
            Controls.Add(lbCreateone);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Gotham", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login_Form";
            Text = "Seoul Stay-Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private CheckBox cbShowPw;
        private CheckBox cbSignin;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtEmployee;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Button btnExit;
        private Label label4;
        private LinkLabel lbCreateone;
    }
}
