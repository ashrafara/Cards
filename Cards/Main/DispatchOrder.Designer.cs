namespace Cards.Main
{
    partial class DispatchOrder
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
            this.btnAddRec = new System.Windows.Forms.Button();
            this.btnexist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtquantity2 = new System.Windows.Forms.TextBox();
            this.txttype2 = new System.Windows.Forms.TextBox();
            this.txtquantity1 = new System.Windows.Forms.TextBox();
            this.txttype1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNoteDisp = new System.Windows.Forms.TextBox();
            this.txtQuantityDisp = new System.Windows.Forms.TextBox();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.cbEmployeePost = new System.Windows.Forms.ComboBox();
            this.cbEmployeeName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDispatch = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRec
            // 
            this.btnAddRec.Location = new System.Drawing.Point(872, 310);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(75, 23);
            this.btnAddRec.TabIndex = 38;
            this.btnAddRec.Text = "اضافة";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // btnexist
            // 
            this.btnexist.Location = new System.Drawing.Point(953, 307);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(75, 28);
            this.btnexist.TabIndex = 37;
            this.btnexist.Text = "خروج";
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtquantity2);
            this.groupBox2.Controls.Add(this.txttype2);
            this.groupBox2.Controls.Add(this.txtquantity1);
            this.groupBox2.Controls.Add(this.txttype1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNoteDisp);
            this.groupBox2.Controls.Add(this.txtQuantityDisp);
            this.groupBox2.Controls.Add(this.cbItemName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(17, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 164);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصرف";
            // 
            // txtquantity2
            // 
            this.txtquantity2.Location = new System.Drawing.Point(146, 68);
            this.txtquantity2.Name = "txtquantity2";
            this.txtquantity2.Size = new System.Drawing.Size(100, 26);
            this.txtquantity2.TabIndex = 16;
            // 
            // txttype2
            // 
            this.txttype2.Location = new System.Drawing.Point(297, 68);
            this.txttype2.Name = "txttype2";
            this.txttype2.Size = new System.Drawing.Size(69, 26);
            this.txttype2.TabIndex = 14;
            // 
            // txtquantity1
            // 
            this.txtquantity1.Location = new System.Drawing.Point(623, 69);
            this.txtquantity1.Name = "txtquantity1";
            this.txtquantity1.Size = new System.Drawing.Size(100, 26);
            this.txtquantity1.TabIndex = 17;
            // 
            // txttype1
            // 
            this.txttype1.Location = new System.Drawing.Point(770, 71);
            this.txttype1.Name = "txttype1";
            this.txttype1.Size = new System.Drawing.Size(67, 26);
            this.txttype1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "العدد";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "الفئة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "العدد";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(843, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "الفئة";
            // 
            // txtNoteDisp
            // 
            this.txtNoteDisp.Location = new System.Drawing.Point(175, 118);
            this.txtNoteDisp.Name = "txtNoteDisp";
            this.txtNoteDisp.Size = new System.Drawing.Size(730, 26);
            this.txtNoteDisp.TabIndex = 7;
            // 
            // txtQuantityDisp
            // 
            this.txtQuantityDisp.Location = new System.Drawing.Point(524, 23);
            this.txtQuantityDisp.Name = "txtQuantityDisp";
            this.txtQuantityDisp.Size = new System.Drawing.Size(90, 26);
            this.txtQuantityDisp.TabIndex = 7;
            // 
            // cbItemName
            // 
            this.cbItemName.DisplayMember = "itemName";
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(761, 25);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(144, 27);
            this.cbItemName.TabIndex = 6;
            this.cbItemName.ValueMember = "itemId";
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.cbItemName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "الكمية المصروفة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "ملاحظات:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(923, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "الصنف:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.month);
            this.groupBox1.Controls.Add(this.cbEmployeePost);
            this.groupBox1.Controls.Add(this.cbEmployeeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateDispatch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 93);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(202, 52);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(59, 26);
            this.year.TabIndex = 13;
            this.year.Visible = false;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(363, 55);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(53, 26);
            this.month.TabIndex = 12;
            this.month.Visible = false;
            // 
            // cbEmployeePost
            // 
            this.cbEmployeePost.DisplayMember = "employeePosition";
            this.cbEmployeePost.FormattingEnabled = true;
            this.cbEmployeePost.Location = new System.Drawing.Point(153, 18);
            this.cbEmployeePost.Name = "cbEmployeePost";
            this.cbEmployeePost.Size = new System.Drawing.Size(263, 27);
            this.cbEmployeePost.TabIndex = 6;
            this.cbEmployeePost.ValueMember = "employeeId";
            this.cbEmployeePost.SelectedIndexChanged += new System.EventHandler(this.cbEmployeePost_SelectedIndexChanged);
            // 
            // cbEmployeeName
            // 
            this.cbEmployeeName.DisplayMember = "employeeName";
            this.cbEmployeeName.FormattingEnabled = true;
            this.cbEmployeeName.Location = new System.Drawing.Point(568, 18);
            this.cbEmployeeName.Name = "cbEmployeeName";
            this.cbEmployeeName.Size = new System.Drawing.Size(302, 27);
            this.cbEmployeeName.TabIndex = 6;
            this.cbEmployeeName.ValueMember = "employeeId";
            this.cbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "الصفة/رقم الهاتف:";
            // 
            // dateDispatch
            // 
            this.dateDispatch.Location = new System.Drawing.Point(568, 51);
            this.dateDispatch.Name = "dateDispatch";
            this.dateDispatch.Size = new System.Drawing.Size(302, 26);
            this.dateDispatch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "تاريخ الصرف:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "سنة";
            this.label13.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "شهر";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الموظف/الجهة:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "صرف الكروت";
            // 
            // DispatchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 345);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnexist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DispatchOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صرف الكروت";
            this.Load += new System.EventHandler(this.DispatchOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRec;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNoteDisp;
        private System.Windows.Forms.TextBox txtQuantityDisp;
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEmployeePost;
        private System.Windows.Forms.ComboBox cbEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDispatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtquantity2;
        private System.Windows.Forms.TextBox txttype2;
        private System.Windows.Forms.TextBox txtquantity1;
        private System.Windows.Forms.TextBox txttype1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}