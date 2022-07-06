namespace csharpLab1WindowsForm
{
    partial class Form1
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
            this.Numberlab = new System.Windows.Forms.Label();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.IvNumbertxt = new System.Windows.Forms.TextBox();
            this.Inventorylab = new System.Windows.Forms.Label();
            this.Datelab = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.objecttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.counttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numberlab
            // 
            this.Numberlab.AutoSize = true;
            this.Numberlab.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberlab.Location = new System.Drawing.Point(38, 46);
            this.Numberlab.Name = "Numberlab";
            this.Numberlab.Size = new System.Drawing.Size(91, 26);
            this.Numberlab.TabIndex = 0;
            this.Numberlab.Text = "Number";
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(12, 91);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(155, 20);
            this.numbertxt.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Silver;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(57, 297);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(110, 42);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // IvNumbertxt
            // 
            this.IvNumbertxt.Location = new System.Drawing.Point(510, 88);
            this.IvNumbertxt.Name = "IvNumbertxt";
            this.IvNumbertxt.Size = new System.Drawing.Size(155, 20);
            this.IvNumbertxt.TabIndex = 4;
            // 
            // Inventorylab
            // 
            this.Inventorylab.AutoSize = true;
            this.Inventorylab.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventorylab.Location = new System.Drawing.Point(505, 46);
            this.Inventorylab.Name = "Inventorylab";
            this.Inventorylab.Size = new System.Drawing.Size(189, 26);
            this.Inventorylab.TabIndex = 3;
            this.Inventorylab.Text = "Invontory Number";
            // 
            // Datelab
            // 
            this.Datelab.AutoSize = true;
            this.Datelab.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelab.Location = new System.Drawing.Point(292, 46);
            this.Datelab.Name = "Datelab";
            this.Datelab.Size = new System.Drawing.Size(57, 26);
            this.Datelab.TabIndex = 5;
            this.Datelab.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // objecttxt
            // 
            this.objecttxt.Location = new System.Drawing.Point(12, 171);
            this.objecttxt.Name = "objecttxt";
            this.objecttxt.Size = new System.Drawing.Size(653, 20);
            this.objecttxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Object name";
            // 
            // counttxt
            // 
            this.counttxt.Location = new System.Drawing.Point(12, 242);
            this.counttxt.Name = "counttxt";
            this.counttxt.Size = new System.Drawing.Size(155, 20);
            this.counttxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "count";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(224, 242);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(155, 20);
            this.pricetxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "price";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Silver;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(331, 297);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(110, 42);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.counttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objecttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelab);
            this.Controls.Add(this.IvNumbertxt);
            this.Controls.Add(this.Inventorylab);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.Numberlab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numberlab;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox IvNumbertxt;
        private System.Windows.Forms.Label Inventorylab;
        private System.Windows.Forms.Label Datelab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox objecttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox counttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbtn;
    }
}

