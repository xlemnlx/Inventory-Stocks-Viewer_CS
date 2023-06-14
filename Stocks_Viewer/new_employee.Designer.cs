namespace Stocks_Viewer
{
    partial class new_employee
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
            this.lbl_oldidnumber = new System.Windows.Forms.Label();
            this.lbl_newidnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_firstname = new System.Windows.Forms.TextBox();
            this.txtbx_lastname = new System.Windows.Forms.TextBox();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.bttn_Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_oldidnumber
            // 
            this.lbl_oldidnumber.AutoSize = true;
            this.lbl_oldidnumber.Location = new System.Drawing.Point(364, 9);
            this.lbl_oldidnumber.Name = "lbl_oldidnumber";
            this.lbl_oldidnumber.Size = new System.Drawing.Size(50, 18);
            this.lbl_oldidnumber.TabIndex = 0;
            this.lbl_oldidnumber.Text = "label1";
            this.lbl_oldidnumber.Visible = false;
            // 
            // lbl_newidnumber
            // 
            this.lbl_newidnumber.AutoSize = true;
            this.lbl_newidnumber.Location = new System.Drawing.Point(160, 35);
            this.lbl_newidnumber.Name = "lbl_newidnumber";
            this.lbl_newidnumber.Size = new System.Drawing.Size(50, 18);
            this.lbl_newidnumber.TabIndex = 1;
            this.lbl_newidnumber.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // txtbx_firstname
            // 
            this.txtbx_firstname.Location = new System.Drawing.Point(160, 64);
            this.txtbx_firstname.Name = "txtbx_firstname";
            this.txtbx_firstname.Size = new System.Drawing.Size(131, 26);
            this.txtbx_firstname.TabIndex = 7;
            // 
            // txtbx_lastname
            // 
            this.txtbx_lastname.Location = new System.Drawing.Point(160, 96);
            this.txtbx_lastname.Name = "txtbx_lastname";
            this.txtbx_lastname.Size = new System.Drawing.Size(131, 26);
            this.txtbx_lastname.TabIndex = 8;
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(160, 128);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(131, 26);
            this.txtbx_username.TabIndex = 9;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(160, 160);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(131, 26);
            this.txtbx_password.TabIndex = 10;
            this.txtbx_password.UseSystemPasswordChar = true;
            // 
            // bttn_Signup
            // 
            this.bttn_Signup.Location = new System.Drawing.Point(108, 192);
            this.bttn_Signup.Name = "bttn_Signup";
            this.bttn_Signup.Size = new System.Drawing.Size(75, 36);
            this.bttn_Signup.TabIndex = 11;
            this.bttn_Signup.Text = "Sign-Up";
            this.bttn_Signup.UseVisualStyleBackColor = true;
            this.bttn_Signup.Click += new System.EventHandler(this.bttn_Signup_Click);
            // 
            // new_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 236);
            this.Controls.Add(this.bttn_Signup);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.txtbx_lastname);
            this.Controls.Add(this.txtbx_firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_newidnumber);
            this.Controls.Add(this.lbl_oldidnumber);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign-Up";
            this.Load += new System.EventHandler(this.new_employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_oldidnumber;
        private System.Windows.Forms.Label lbl_newidnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_firstname;
        private System.Windows.Forms.TextBox txtbx_lastname;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button bttn_Signup;
    }
}