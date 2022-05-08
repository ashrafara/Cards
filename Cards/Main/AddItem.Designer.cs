namespace Cards.Main
{
    partial class AddItem
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
            this.cbsupplierId = new System.Windows.Forms.ComboBox();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnexist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbsupplierId
            // 
            this.cbsupplierId.DisplayMember = "supplierName";
            this.cbsupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupplierId.FormattingEnabled = true;
            this.cbsupplierId.Location = new System.Drawing.Point(138, 86);
            this.cbsupplierId.Name = "cbsupplierId";
            this.cbsupplierId.Size = new System.Drawing.Size(486, 28);
            this.cbsupplierId.TabIndex = 36;
            this.cbsupplierId.ValueMember = "supplierId";
            // 
            // txtnotes
            // 
            this.txtnotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotes.Location = new System.Drawing.Point(137, 117);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(487, 26);
            this.txtnotes.TabIndex = 32;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(137, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(487, 26);
            this.txtItemName.TabIndex = 34;
            // 
            // btnexist
            // 
            this.btnexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.Location = new System.Drawing.Point(540, 158);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(75, 28);
            this.btnexist.TabIndex = 30;
            this.btnexist.Text = "خروج";
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "ملاحظات:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "اسم المورد:";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(459, 158);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 28);
            this.btnadd.TabIndex = 31;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "اضافة صنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "اسم الصنف:";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 197);
            this.Controls.Add(this.cbsupplierId);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnexist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbsupplierId;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}