
namespace Pharmacy_Records
{
    partial class Information
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
            this.logout = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.mngID = new System.Windows.Forms.TextBox();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Dataoutput = new System.Windows.Forms.ListBox();
            this.Fullreport = new System.Windows.Forms.RadioButton();
            this.Names = new System.Windows.Forms.RadioButton();
            this.YearSal = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(138, 264);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(57, 222);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Insert";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // mngID
            // 
            this.mngID.Location = new System.Drawing.Point(59, 51);
            this.mngID.Name = "mngID";
            this.mngID.Size = new System.Drawing.Size(100, 20);
            this.mngID.TabIndex = 2;
            // 
            // fnamebox
            // 
            this.fnamebox.Location = new System.Drawing.Point(59, 108);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(100, 20);
            this.fnamebox.TabIndex = 3;
            // 
            // lnamebox
            // 
            this.lnamebox.Location = new System.Drawing.Point(59, 163);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(100, 20);
            this.lnamebox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(59, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Manager ID";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(59, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(59, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Last Name";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(138, 222);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(57, 264);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Dataoutput
            // 
            this.Dataoutput.FormattingEnabled = true;
            this.Dataoutput.Location = new System.Drawing.Point(341, 32);
            this.Dataoutput.Name = "Dataoutput";
            this.Dataoutput.Size = new System.Drawing.Size(243, 173);
            this.Dataoutput.TabIndex = 11;
            this.Dataoutput.SelectedIndexChanged += new System.EventHandler(this.Dataoutput_SelectedIndexChanged);
            // 
            // Fullreport
            // 
            this.Fullreport.AutoSize = true;
            this.Fullreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fullreport.Location = new System.Drawing.Point(245, 228);
            this.Fullreport.Name = "Fullreport";
            this.Fullreport.Size = new System.Drawing.Size(96, 19);
            this.Fullreport.TabIndex = 12;
            this.Fullreport.TabStop = true;
            this.Fullreport.Text = "Full Report";
            this.Fullreport.UseVisualStyleBackColor = true;
            this.Fullreport.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Names.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Names.Location = new System.Drawing.Point(245, 251);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(70, 19);
            this.Names.TabIndex = 13;
            this.Names.TabStop = true;
            this.Names.Text = "Names";
            this.Names.UseVisualStyleBackColor = true;
            // 
            // YearSal
            // 
            this.YearSal.AutoSize = true;
            this.YearSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearSal.Location = new System.Drawing.Point(245, 276);
            this.YearSal.Name = "YearSal";
            this.YearSal.Size = new System.Drawing.Size(108, 19);
            this.YearSal.TabIndex = 14;
            this.YearSal.TabStop = true;
            this.YearSal.Text = "Yearly Salary";
            this.YearSal.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(359, 251);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(674, 319);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.YearSal);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Fullreport);
            this.Controls.Add(this.Dataoutput);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lnamebox);
            this.Controls.Add(this.fnamebox);
            this.Controls.Add(this.mngID);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.logout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Information";
            this.Text = "Pharmacy Database";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox mngID;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox Dataoutput;
        private System.Windows.Forms.RadioButton Fullreport;
        private System.Windows.Forms.RadioButton Names;
        private System.Windows.Forms.RadioButton YearSal;
        private System.Windows.Forms.Button Search;
    }
}

