namespace Pharmacy_Records
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Pharmpic = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pharmpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(136, 42);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(118, 22);
            this.Usernametxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(136, 70);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(118, 22);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // Pharmpic
            // 
            this.Pharmpic.Image = ((System.Drawing.Image)(resources.GetObject("Pharmpic.Image")));
            this.Pharmpic.Location = new System.Drawing.Point(276, 12);
            this.Pharmpic.Name = "Pharmpic";
            this.Pharmpic.Size = new System.Drawing.Size(130, 111);
            this.Pharmpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pharmpic.TabIndex = 4;
            this.Pharmpic.TabStop = false;
            this.Pharmpic.Click += new System.EventHandler(this.Pharmpic_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(158, 99);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(418, 151);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.Pharmpic);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usernametxt);
            this.Name = "login";
            this.Text = "Pharmacy Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pharmpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.PictureBox Pharmpic;
        private System.Windows.Forms.Button loginbtn;
       
    }
}