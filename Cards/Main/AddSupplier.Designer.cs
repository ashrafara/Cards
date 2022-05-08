namespace Cards.Main
{
    partial class AddSupplier
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
            this.btnExist = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(520, 209);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 28);
            this.btnExist.TabIndex = 49;
            this.btnExist.Text = "خروج";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(127, 158);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(487, 26);
            this.txtnotes.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(487, 26);
            this.txtAddress.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "ملاحظات:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(127, 94);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(487, 26);
            this.txtSupplierName.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "العنوان:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "اضافة مورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "اسم المورد:";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 255);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مورد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}