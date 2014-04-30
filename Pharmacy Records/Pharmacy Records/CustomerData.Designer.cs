namespace Pharmacy_Records
{
    partial class CustomerData
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
            this.Cquery = new System.Windows.Forms.Button();
            this.CBack = new System.Windows.Forms.Button();
            this.Cupdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cDrug = new System.Windows.Forms.RadioButton();
            this.cScript = new System.Windows.Forms.RadioButton();
            this.cSale = new System.Windows.Forms.RadioButton();
            this.Cname = new System.Windows.Forms.TextBox();
            this.custdat = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cquery
            // 
            this.Cquery.Location = new System.Drawing.Point(46, 263);
            this.Cquery.Name = "Cquery";
            this.Cquery.Size = new System.Drawing.Size(75, 23);
            this.Cquery.TabIndex = 3;
            this.Cquery.Text = "Query";
            this.Cquery.UseVisualStyleBackColor = true;
            this.Cquery.Click += new System.EventHandler(this.Cquery_Click);
            // 
            // CBack
            // 
            this.CBack.Location = new System.Drawing.Point(396, 263);
            this.CBack.Name = "CBack";
            this.CBack.Size = new System.Drawing.Size(75, 23);
            this.CBack.TabIndex = 4;
            this.CBack.Text = "Back";
            this.CBack.UseVisualStyleBackColor = true;
            this.CBack.Click += new System.EventHandler(this.CBack_Click);
            // 
            // Cupdate
            // 
            this.Cupdate.Location = new System.Drawing.Point(221, 263);
            this.Cupdate.Name = "Cupdate";
            this.Cupdate.Size = new System.Drawing.Size(75, 23);
            this.Cupdate.TabIndex = 5;
            this.Cupdate.Text = "Update";
            this.Cupdate.UseVisualStyleBackColor = true;
            this.Cupdate.Click += new System.EventHandler(this.Cupdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cDrug);
            this.groupBox1.Controls.Add(this.cScript);
            this.groupBox1.Controls.Add(this.cSale);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(46, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cDrug
            // 
            this.cDrug.AutoSize = true;
            this.cDrug.Location = new System.Drawing.Point(6, 87);
            this.cDrug.Name = "cDrug";
            this.cDrug.Size = new System.Drawing.Size(48, 17);
            this.cDrug.TabIndex = 2;
            this.cDrug.TabStop = true;
            this.cDrug.Text = "Drug";
            this.cDrug.UseVisualStyleBackColor = true;
            // 
            // cScript
            // 
            this.cScript.AutoSize = true;
            this.cScript.Location = new System.Drawing.Point(6, 53);
            this.cScript.Name = "cScript";
            this.cScript.Size = new System.Drawing.Size(80, 17);
            this.cScript.TabIndex = 1;
            this.cScript.TabStop = true;
            this.cScript.Text = "Perscription";
            this.cScript.UseVisualStyleBackColor = true;
            // 
            // cSale
            // 
            this.cSale.AutoSize = true;
            this.cSale.Location = new System.Drawing.Point(6, 19);
            this.cSale.Name = "cSale";
            this.cSale.Size = new System.Drawing.Size(46, 17);
            this.cSale.TabIndex = 0;
            this.cSale.TabStop = true;
            this.cSale.Text = "Sale";
            this.cSale.UseVisualStyleBackColor = true;
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(46, 48);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(100, 20);
            this.Cname.TabIndex = 7;
            // 
            // custdat
            // 
            this.custdat.FormattingEnabled = true;
            this.custdat.Location = new System.Drawing.Point(178, 52);
            this.custdat.Name = "custdat";
            this.custdat.Size = new System.Drawing.Size(293, 173);
            this.custdat.TabIndex = 8;
            // 
            // CustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(530, 378);
            this.Controls.Add(this.custdat);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cupdate);
            this.Controls.Add(this.CBack);
            this.Controls.Add(this.Cquery);
            this.Name = "CustomerData";
            this.Text = "Customer Data";
            this.Load += new System.EventHandler(this.CustomerData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cquery;
        private System.Windows.Forms.Button CBack;
        private System.Windows.Forms.Button Cupdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cDrug;
        private System.Windows.Forms.RadioButton cScript;
        private System.Windows.Forms.RadioButton cSale;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.ListBox custdat;
    }
}