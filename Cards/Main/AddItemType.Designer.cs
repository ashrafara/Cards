namespace Cards.Main
{
    partial class AddItemType
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
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.btnexist = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtItemType
            // 
            this.txtItemType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemType.Location = new System.Drawing.Point(122, 76);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(487, 26);
            this.txtItemType.TabIndex = 26;
            // 
            // btnexist
            // 
            this.btnexist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.Location = new System.Drawing.Point(551, 121);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(75, 28);
            this.btnexist.TabIndex = 24;
            this.btnexist.Text = "خروج";
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(459, 121);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 28);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "اضافة نوع الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "نوع الصنف:";
            // 
            // AddItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 192);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.btnexist);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddItemType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة نوع الصنف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}