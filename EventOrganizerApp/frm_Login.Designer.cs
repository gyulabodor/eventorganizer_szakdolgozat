namespace EventOrganizerApp
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.lbl_LoginTitle = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_AppTitle.Location = new System.Drawing.Point(120, 32);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(205, 30);
            this.lbl_AppTitle.TabIndex = 0;
            this.lbl_AppTitle.Text = "Event Organizer ";
            // 
            // lbl_LoginTitle
            // 
            this.lbl_LoginTitle.AutoSize = true;
            this.lbl_LoginTitle.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_LoginTitle.Location = new System.Drawing.Point(137, 82);
            this.lbl_LoginTitle.Name = "lbl_LoginTitle";
            this.lbl_LoginTitle.Size = new System.Drawing.Size(171, 30);
            this.lbl_LoginTitle.TabIndex = 1;
            this.lbl_LoginTitle.Text = "Bejelentkezés";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Email.Location = new System.Drawing.Point(48, 136);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(84, 19);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Emailcím:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Password.Location = new System.Drawing.Point(67, 190);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(65, 19);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Jelszó:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Rockwell", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_Email.Location = new System.Drawing.Point(134, 136);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 22);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Rockwell", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_Password.Location = new System.Drawing.Point(134, 189);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = 'x';
            this.txt_Password.Size = new System.Drawing.Size(176, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Rockwell", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Login.Location = new System.Drawing.Point(146, 226);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(153, 31);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Bejelentkezés";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(430, 288);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_LoginTitle);
            this.Controls.Add(this.lbl_AppTitle);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 330);
            this.MinimumSize = new System.Drawing.Size(450, 330);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés - Event Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Label lbl_LoginTitle;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

