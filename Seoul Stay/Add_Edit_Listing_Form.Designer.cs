namespace Seoul_Stay
{
    partial class Add_Edit_Listing_Form
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            nudNumofBathroom = new NumericUpDown();
            nudNumofBedrooms = new NumericUpDown();
            nudNumofBeds = new NumericUpDown();
            nudCapacity = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbType = new ComboBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnNext = new Button();
            btnClose_Finish = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_Approximate_Address = new TextBox();
            txt_Exact_Adress = new TextBox();
            txt_Description = new TextBox();
            txt_Host_Rules = new TextBox();
            label12 = new Label();
            nudMinimum = new NumericUpDown();
            label13 = new Label();
            nudMaximum = new NumericUpDown();
            label14 = new Label();
            pnChoose = new Panel();
            label15 = new Label();
            dgvShowDistance = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumofBathroom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumofBedrooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumofBeds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinimum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaximum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowDistance).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 583);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nudMaximum);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(nudMinimum);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txt_Host_Rules);
            tabPage1.Controls.Add(txt_Description);
            tabPage1.Controls.Add(txt_Exact_Adress);
            tabPage1.Controls.Add(txt_Approximate_Address);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(nudNumofBathroom);
            tabPage1.Controls.Add(nudNumofBedrooms);
            tabPage1.Controls.Add(nudNumofBeds);
            tabPage1.Controls.Add(nudCapacity);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbType);
            tabPage1.Controls.Add(txtTitle);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listing Details";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudNumofBathroom
            // 
            nudNumofBathroom.Location = new Point(804, 100);
            nudNumofBathroom.Name = "nudNumofBathroom";
            nudNumofBathroom.Size = new Size(43, 23);
            nudNumofBathroom.TabIndex = 11;
            // 
            // nudNumofBedrooms
            // 
            nudNumofBedrooms.Location = new Point(563, 97);
            nudNumofBedrooms.Name = "nudNumofBedrooms";
            nudNumofBedrooms.Size = new Size(43, 23);
            nudNumofBedrooms.TabIndex = 10;
            // 
            // nudNumofBeds
            // 
            nudNumofBeds.Location = new Point(306, 92);
            nudNumofBeds.Name = "nudNumofBeds";
            nudNumofBeds.Size = new Size(43, 23);
            nudNumofBeds.TabIndex = 9;
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(92, 92);
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(43, 23);
            nudCapacity.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(638, 100);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 7;
            label6.Text = "Number of Bathrooms:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(401, 95);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 6;
            label5.Text = "Number of Bedrooms:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(180, 92);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 5;
            label4.Text = "Number of Beds:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 90);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Capacity:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(92, 31);
            cbType.Name = "cbType";
            cbType.Size = new Size(295, 23);
            cbType.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(581, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(312, 23);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 30);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnChoose);
            tabPage2.Controls.Add(label14);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(969, 555);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Amenities";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvShowDistance);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(969, 555);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Distance to Attraction";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(684, 633);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(136, 36);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnClose_Finish
            // 
            btnClose_Finish.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose_Finish.Location = new Point(853, 633);
            btnClose_Finish.Name = "btnClose_Finish";
            btnClose_Finish.Size = new Size(136, 36);
            btnClose_Finish.TabIndex = 2;
            btnClose_Finish.Text = "Close / Finish";
            btnClose_Finish.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 178);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 12;
            label7.Text = "Approximate Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 225);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 13;
            label8.Text = "Exact Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 296);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 14;
            label9.Text = "Description:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 373);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 15;
            label10.Text = "Host Rules:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 474);
            label11.Name = "label11";
            label11.Size = new Size(177, 20);
            label11.TabIndex = 16;
            label11.Text = "Reservation Time(Night): ";
            // 
            // txt_Approximate_Address
            // 
            txt_Approximate_Address.Location = new Point(180, 179);
            txt_Approximate_Address.Multiline = true;
            txt_Approximate_Address.Name = "txt_Approximate_Address";
            txt_Approximate_Address.Size = new Size(713, 23);
            txt_Approximate_Address.TabIndex = 17;
            // 
            // txt_Exact_Adress
            // 
            txt_Exact_Adress.Location = new Point(180, 226);
            txt_Exact_Adress.Multiline = true;
            txt_Exact_Adress.Name = "txt_Exact_Adress";
            txt_Exact_Adress.Size = new Size(713, 58);
            txt_Exact_Adress.TabIndex = 18;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(180, 296);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(713, 58);
            txt_Description.TabIndex = 19;
            // 
            // txt_Host_Rules
            // 
            txt_Host_Rules.Location = new Point(180, 360);
            txt_Host_Rules.Multiline = true;
            txt_Host_Rules.Name = "txt_Host_Rules";
            txt_Host_Rules.Size = new Size(713, 58);
            txt_Host_Rules.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(257, 474);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 21;
            label12.Text = "Minimum: ";
            // 
            // nudMinimum
            // 
            nudMinimum.Location = new Point(342, 476);
            nudMinimum.Name = "nudMinimum";
            nudMinimum.Size = new Size(43, 23);
            nudMinimum.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(464, 479);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 23;
            label13.Text = "Maximum:";
            // 
            // nudMaximum
            // 
            nudMaximum.Location = new Point(548, 481);
            nudMaximum.Name = "nudMaximum";
            nudMaximum.Size = new Size(43, 23);
            nudMaximum.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(27, 29);
            label14.Name = "label14";
            label14.Size = new Size(201, 20);
            label14.TabIndex = 0;
            label14.Text = "Choose Avalilable Amenities:";
            // 
            // pnChoose
            // 
            pnChoose.Location = new Point(28, 67);
            pnChoose.Name = "pnChoose";
            pnChoose.Size = new Size(546, 323);
            pnChoose.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(22, 32);
            label15.Name = "label15";
            label15.Size = new Size(521, 20);
            label15.TabIndex = 0;
            label15.Text = "Specify the distance from each close by attraction and it takes to get to them:";
            // 
            // dgvShowDistance
            // 
            dgvShowDistance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDistance.Location = new Point(22, 66);
            dgvShowDistance.Name = "dgvShowDistance";
            dgvShowDistance.Size = new Size(928, 456);
            dgvShowDistance.TabIndex = 1;
            // 
            // Add_Edit_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 697);
            Controls.Add(btnClose_Finish);
            Controls.Add(btnNext);
            Controls.Add(tabControl1);
            Name = "Add_Edit_Listing_Form";
            Text = "Add_Edit_Listing_Form";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumofBathroom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumofBedrooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumofBeds).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinimum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaximum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnNext;
        private Button btnClose_Finish;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbType;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private NumericUpDown nudNumofBathroom;
        private NumericUpDown nudNumofBedrooms;
        private NumericUpDown nudNumofBeds;
        private NumericUpDown nudCapacity;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown nudMaximum;
        private Label label13;
        private NumericUpDown nudMinimum;
        private Label label12;
        private TextBox txt_Host_Rules;
        private TextBox txt_Description;
        private TextBox txt_Exact_Adress;
        private TextBox txt_Approximate_Address;
        private Label label11;
        private Label label10;
        private Label label14;
        private Panel pnChoose;
        private Label label15;
        private DataGridView dgvShowDistance;
    }
}