namespace EventOrganizerApp
{
    partial class frm_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainMenu));
            this.btn_NewEvent = new System.Windows.Forms.Button();
            this.lbl_MenuTitle = new System.Windows.Forms.Label();
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.btn_Tenders = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewEvent
            // 
            this.btn_NewEvent.Font = new System.Drawing.Font("Rockwell", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_NewEvent.Location = new System.Drawing.Point(87, 135);
            this.btn_NewEvent.Name = "btn_NewEvent";
            this.btn_NewEvent.Size = new System.Drawing.Size(257, 31);
            this.btn_NewEvent.TabIndex = 7;
            this.btn_NewEvent.Text = "Új árajánlat készítése";
            this.btn_NewEvent.UseVisualStyleBackColor = true;
            this.btn_NewEvent.Click += new System.EventHandler(this.btn_NewEvent_Click);
            // 
            // lbl_MenuTitle
            // 
            this.lbl_MenuTitle.AutoSize = true;
            this.lbl_MenuTitle.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuTitle.Location = new System.Drawing.Point(162, 78);
            this.lbl_MenuTitle.Name = "lbl_MenuTitle";
            this.lbl_MenuTitle.Size = new System.Drawing.Size(133, 37);
            this.lbl_MenuTitle.TabIndex = 9;
            this.lbl_MenuTitle.Text = "Főmenü";
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_AppTitle.Location = new System.Drawing.Point(213, 9);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(257, 37);
            this.lbl_AppTitle.TabIndex = 8;
            this.lbl_AppTitle.Text = "Event Organizer ";
            // 
            // btn_Tenders
            // 
            this.btn_Tenders.Font = new System.Drawing.Font("Rockwell", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Tenders.Location = new System.Drawing.Point(87, 172);
            this.btn_Tenders.Name = "btn_Tenders";
            this.btn_Tenders.Size = new System.Drawing.Size(257, 38);
            this.btn_Tenders.TabIndex = 12;
            this.btn_Tenders.Text = "Árajánlatok megtekintése";
            this.btn_Tenders.UseVisualStyleBackColor = true;
            this.btn_Tenders.Click += new System.EventHandler(this.btn_Tenders_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Rockwell", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_LogOut.Location = new System.Drawing.Point(87, 216);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(257, 31);
            this.btn_LogOut.TabIndex = 14;
            this.btn_LogOut.Text = "Kijelentkezés";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Rockwell", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Exit.Location = new System.Drawing.Point(87, 253);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(257, 31);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Kilépés";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(428, 349);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Tenders);
            this.Controls.Add(this.lbl_MenuTitle);
            this.Controls.Add(this.lbl_AppTitle);
            this.Controls.Add(this.btn_NewEvent);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "frm_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü - Event Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewEvent;
        private System.Windows.Forms.Label lbl_MenuTitle;
        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Button btn_Tenders;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Exit;
    }
}