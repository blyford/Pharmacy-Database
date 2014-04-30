namespace Pharmacy_Records
{
    partial class NewUser
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
            this.Enter = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Aclvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(32, 194);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Save";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(167, 194);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(32, 33);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(32, 82);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 3;
            // 
            // Aclvl
            // 
            this.Aclvl.Location = new System.Drawing.Point(32, 131);
            this.Aclvl.Name = "Aclvl";
            this.Aclvl.Size = new System.Drawing.Size(100, 20);
            this.Aclvl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Access Level";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aclvl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Enter);
            this.Name = "NewUser";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Aclvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}