namespace EventOrganizerApp
{
    partial class frm_Tenders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tenders));
            this.dtgv_Tenders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTotalSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CheckTender = new System.Windows.Forms.Button();
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_DeleteTender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Tenders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Tenders
            // 
            this.dtgv_Tenders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Tenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Tenders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clientName,
            this.eventType,
            this.eventTotalSalePrice,
            this.guestNumber,
            this.clientPhone,
            this.clientEmail});
            this.dtgv_Tenders.Location = new System.Drawing.Point(12, 91);
            this.dtgv_Tenders.MultiSelect = false;
            this.dtgv_Tenders.Name = "dtgv_Tenders";
            this.dtgv_Tenders.ReadOnly = true;
            this.dtgv_Tenders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Tenders.Size = new System.Drawing.Size(856, 183);
            this.dtgv_Tenders.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Azonosító";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // clientName
            // 
            this.clientName.HeaderText = "Megrendelő neve";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            // 
            // eventType
            // 
            this.eventType.HeaderText = "Rendezvény típusa";
            this.eventType.Name = "eventType";
            this.eventType.ReadOnly = true;
            // 
            // eventTotalSalePrice
            // 
            this.eventTotalSalePrice.HeaderText = "Ajánlott ár";
            this.eventTotalSalePrice.Name = "eventTotalSalePrice";
            this.eventTotalSalePrice.ReadOnly = true;
            // 
            // guestNumber
            // 
            this.guestNumber.HeaderText = "Vendégek száma";
            this.guestNumber.Name = "guestNumber";
            this.guestNumber.ReadOnly = true;
            // 
            // clientPhone
            // 
            this.clientPhone.HeaderText = "Megrendelő tel. száma";
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.ReadOnly = true;
            // 
            // clientEmail
            // 
            this.clientEmail.HeaderText = "Megrendelő emailcíme";
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.ReadOnly = true;
            // 
            // btn_CheckTender
            // 
            this.btn_CheckTender.Location = new System.Drawing.Point(333, 280);
            this.btn_CheckTender.Name = "btn_CheckTender";
            this.btn_CheckTender.Size = new System.Drawing.Size(215, 44);
            this.btn_CheckTender.TabIndex = 1;
            this.btn_CheckTender.Text = "Választott árajánlat megtekintése";
            this.btn_CheckTender.UseVisualStyleBackColor = true;
            this.btn_CheckTender.Click += new System.EventHandler(this.btn_CheckTender_Click);
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Rockwell", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_AppTitle.Location = new System.Drawing.Point(622, 0);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(257, 37);
            this.lbl_AppTitle.TabIndex = 11;
            this.lbl_AppTitle.Text = "Event Organizer ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Árajánlatok";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 322);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(96, 27);
            this.btn_Exit.TabIndex = 97;
            this.btn_Exit.Text = "Kilépés";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(12, 289);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(96, 27);
            this.btn_MainMenu.TabIndex = 96;
            this.btn_MainMenu.Text = "Főmenü";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_DeleteTender
            // 
            this.btn_DeleteTender.Location = new System.Drawing.Point(689, 280);
            this.btn_DeleteTender.Name = "btn_DeleteTender";
            this.btn_DeleteTender.Size = new System.Drawing.Size(179, 36);
            this.btn_DeleteTender.TabIndex = 98;
            this.btn_DeleteTender.Text = "Választott árajánlat törlése";
            this.btn_DeleteTender.UseVisualStyleBackColor = true;
            this.btn_DeleteTender.Click += new System.EventHandler(this.btn_DeleteTender_Click);
            // 
            // frm_Tenders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 358);
            this.Controls.Add(this.btn_DeleteTender);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AppTitle);
            this.Controls.Add(this.btn_CheckTender);
            this.Controls.Add(this.dtgv_Tenders);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(900, 400);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "frm_Tenders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Árajánlatok megtekintése";
            this.Load += new System.EventHandler(this.frm_Tenders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Tenders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Tenders;
        private System.Windows.Forms.Button btn_CheckTender;
        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTotalSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmail;
        private System.Windows.Forms.Button btn_DeleteTender;
    }
}