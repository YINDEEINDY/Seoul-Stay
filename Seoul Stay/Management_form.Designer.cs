namespace Seoul_Stay
{
    partial class Management_form
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
            ImgLogo = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvShowList = new DataGridView();
            txtSearch = new TextBox();
            tabPage2 = new TabPage();
            dgvShowAddList = new DataGridView();
            btnAddList = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            laCount = new Label();
            ((System.ComponentModel.ISupportInitialize)ImgLogo).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowAddList).BeginInit();
            SuspendLayout();
            // 
            // ImgLogo
            // 
            ImgLogo.BackColor = SystemColors.ActiveCaption;
            ImgLogo.Location = new Point(272, 31);
            ImgLogo.Name = "ImgLogo";
            ImgLogo.Size = new Size(363, 54);
            ImgLogo.TabIndex = 0;
            ImgLogo.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(37, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 356);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvShowList);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(862, 328);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "I'm Traveler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvShowList
            // 
            dgvShowList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowList.Location = new Point(24, 85);
            dgvShowList.Name = "dgvShowList";
            dgvShowList.Size = new Size(814, 216);
            dgvShowList.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(24, 23);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(701, 45);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvShowAddList);
            tabPage2.Controls.Add(btnAddList);
            tabPage2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(862, 328);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "I'm Owner/Manager";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvShowAddList
            // 
            dgvShowAddList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAddList.Location = new Point(18, 80);
            dgvShowAddList.Name = "dgvShowAddList";
            dgvShowAddList.Size = new Size(820, 220);
            dgvShowAddList.TabIndex = 1;
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(18, 35);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(170, 39);
            btnAddList.TabIndex = 0;
            btnAddList.Text = "Add Listing";
            btnAddList.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(683, 106);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 27);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(799, 106);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // laCount
            // 
            laCount.AutoSize = true;
            laCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laCount.Location = new Point(41, 484);
            laCount.Name = "laCount";
            laCount.Size = new Size(56, 40);
            laCount.TabIndex = 4;
            laCount.Text = "???";
            // 
            // Management_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 527);
            Controls.Add(laCount);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(tabControl1);
            Controls.Add(ImgLogo);
            Name = "Management_form";
            Text = "Management_form";
            ((System.ComponentModel.ISupportInitialize)ImgLogo).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowList).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowAddList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImgLogo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLogout;
        private Button btnExit;
        private Label laCount;
        private DataGridView dgvShowList;
        private TextBox txtSearch;
        private DataGridView dgvShowAddList;
        private Button btnAddList;
    }
}