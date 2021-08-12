namespace EventOrganizerApp
{
    partial class frm_CheckTender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CheckTender));
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.dtgv_Meals = new System.Windows.Forms.DataGridView();
            this.mealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealPortion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_NumberOfGuests = new System.Windows.Forms.Label();
            this.lbl_NumberOfGuestsResult = new System.Windows.Forms.Label();
            this.lbl_EventTypeResult = new System.Windows.Forms.Label();
            this.lbl_EventType = new System.Windows.Forms.Label();
            this.lbl_EventDateResult = new System.Windows.Forms.Label();
            this.lbl_EventDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ClientEmailResult = new System.Windows.Forms.Label();
            this.lbl_ClientEmail = new System.Windows.Forms.Label();
            this.lbl_ClientNameResult = new System.Windows.Forms.Label();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.lbl_ClientPhoneResult = new System.Windows.Forms.Label();
            this.lbl_ClientPhone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Drinks = new System.Windows.Forms.Label();
            this.lbl_DrinksResult = new System.Windows.Forms.Label();
            this.lbl_MenuSalePricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_MenuSalePricePerPerson = new System.Windows.Forms.Label();
            this.lbl_TotalPriceEventResult = new System.Windows.Forms.Label();
            this.lbl_PlaceRentingPriceResult = new System.Windows.Forms.Label();
            this.lbl_EmployeePriceResult = new System.Windows.Forms.Label();
            this.lbl_MenuTotalSalePriceResult = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuTotalSalePriceResult = new System.Windows.Forms.Label();
            this.lbl_MealMenuTotalSalePriceResult = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuSalePricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_MealMenuSalePricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_TotalPriceEvent = new System.Windows.Forms.Label();
            this.lbl_MealMenuSalePricePerPerson = new System.Windows.Forms.Label();
            this.lbl_PlaceRentingPrice = new System.Windows.Forms.Label();
            this.lbl_MenuTotalSalePrice = new System.Windows.Forms.Label();
            this.lbl_EmployeePrice = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuSalePricePerPerson = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuTotalsSalePrice = new System.Windows.Forms.Label();
            this.lbl_MealMenuTotalSalePrice = new System.Windows.Forms.Label();
            this.btn_CreatePDF = new System.Windows.Forms.Button();
            this.dtgv_Employees = new System.Windows.Forms.DataGridView();
            this.employeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_MenuDevPricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_MenuDevPricePerPerson = new System.Windows.Forms.Label();
            this.lbl_MenuTotalDevPriceResult = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuTotalDevPriceResult = new System.Windows.Forms.Label();
            this.lbl_MealMenuTotalDevPriceResult = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuDevPricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_MealMenuDevPricePerPersonResult = new System.Windows.Forms.Label();
            this.lbl_MealMenuDevPricePerPerson = new System.Windows.Forms.Label();
            this.lbl_MenuTotalDevPrice = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuDevPricePerPerson = new System.Windows.Forms.Label();
            this.lbl_DrinkMenuTotalsDevPrice = new System.Windows.Forms.Label();
            this.lbl_MealMenuTotalDevPrice = new System.Windows.Forms.Label();
            this.lbl_ProfitResult = new System.Windows.Forms.Label();
            this.lbl_Profit = new System.Windows.Forms.Label();
            this.sfd_SavePDF = new System.Windows.Forms.SaveFileDialog();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_NewEventTender = new System.Windows.Forms.Button();
            this.btn_Tenders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Meals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Rockwell", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_AppTitle.Location = new System.Drawing.Point(427, 9);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(257, 37);
            this.lbl_AppTitle.TabIndex = 10;
            this.lbl_AppTitle.Text = "Event Organizer ";
            // 
            // dtgv_Meals
            // 
            this.dtgv_Meals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Meals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealName,
            this.mealPortion});
            this.dtgv_Meals.Location = new System.Drawing.Point(61, 201);
            this.dtgv_Meals.Name = "dtgv_Meals";
            this.dtgv_Meals.ReadOnly = true;
            this.dtgv_Meals.Size = new System.Drawing.Size(386, 150);
            this.dtgv_Meals.TabIndex = 11;
            // 
            // mealName
            // 
            this.mealName.HeaderText = "Étel neve";
            this.mealName.Name = "mealName";
            this.mealName.ReadOnly = true;
            // 
            // mealPortion
            // 
            this.mealPortion.HeaderText = "Adag";
            this.mealPortion.Name = "mealPortion";
            this.mealPortion.ReadOnly = true;
            // 
            // lbl_NumberOfGuests
            // 
            this.lbl_NumberOfGuests.AutoSize = true;
            this.lbl_NumberOfGuests.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_NumberOfGuests.Location = new System.Drawing.Point(57, 104);
            this.lbl_NumberOfGuests.Name = "lbl_NumberOfGuests";
            this.lbl_NumberOfGuests.Size = new System.Drawing.Size(145, 19);
            this.lbl_NumberOfGuests.TabIndex = 12;
            this.lbl_NumberOfGuests.Text = "Vendégek száma:";
            // 
            // lbl_NumberOfGuestsResult
            // 
            this.lbl_NumberOfGuestsResult.AutoSize = true;
            this.lbl_NumberOfGuestsResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_NumberOfGuestsResult.Location = new System.Drawing.Point(208, 99);
            this.lbl_NumberOfGuestsResult.Name = "lbl_NumberOfGuestsResult";
            this.lbl_NumberOfGuestsResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_NumberOfGuestsResult.TabIndex = 40;
            this.lbl_NumberOfGuestsResult.Text = "default";
            // 
            // lbl_EventTypeResult
            // 
            this.lbl_EventTypeResult.AutoSize = true;
            this.lbl_EventTypeResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EventTypeResult.Location = new System.Drawing.Point(208, 69);
            this.lbl_EventTypeResult.Name = "lbl_EventTypeResult";
            this.lbl_EventTypeResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_EventTypeResult.TabIndex = 42;
            this.lbl_EventTypeResult.Text = "default";
            // 
            // lbl_EventType
            // 
            this.lbl_EventType.AutoSize = true;
            this.lbl_EventType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EventType.Location = new System.Drawing.Point(40, 74);
            this.lbl_EventType.Name = "lbl_EventType";
            this.lbl_EventType.Size = new System.Drawing.Size(162, 19);
            this.lbl_EventType.TabIndex = 41;
            this.lbl_EventType.Text = "Rendezvény típusa:";
            // 
            // lbl_EventDateResult
            // 
            this.lbl_EventDateResult.AutoSize = true;
            this.lbl_EventDateResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EventDateResult.Location = new System.Drawing.Point(208, 132);
            this.lbl_EventDateResult.Name = "lbl_EventDateResult";
            this.lbl_EventDateResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_EventDateResult.TabIndex = 44;
            this.lbl_EventDateResult.Text = "default";
            // 
            // lbl_EventDate
            // 
            this.lbl_EventDate.AutoSize = true;
            this.lbl_EventDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EventDate.Location = new System.Drawing.Point(30, 137);
            this.lbl_EventDate.Name = "lbl_EventDate";
            this.lbl_EventDate.Size = new System.Drawing.Size(172, 19);
            this.lbl_EventDate.TabIndex = 43;
            this.lbl_EventDate.Text = "Rendezvény dátuma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(57, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ételek listája:";
            // 
            // lbl_ClientEmailResult
            // 
            this.lbl_ClientEmailResult.AutoSize = true;
            this.lbl_ClientEmailResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientEmailResult.Location = new System.Drawing.Point(566, 132);
            this.lbl_ClientEmailResult.Name = "lbl_ClientEmailResult";
            this.lbl_ClientEmailResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_ClientEmailResult.TabIndex = 51;
            this.lbl_ClientEmailResult.Text = "default";
            this.lbl_ClientEmailResult.Visible = false;
            // 
            // lbl_ClientEmail
            // 
            this.lbl_ClientEmail.AutoSize = true;
            this.lbl_ClientEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientEmail.Location = new System.Drawing.Point(384, 138);
            this.lbl_ClientEmail.Name = "lbl_ClientEmail";
            this.lbl_ClientEmail.Size = new System.Drawing.Size(185, 19);
            this.lbl_ClientEmail.TabIndex = 50;
            this.lbl_ClientEmail.Text = "Megrendelő emailcíme:";
            this.lbl_ClientEmail.Visible = false;
            // 
            // lbl_ClientNameResult
            // 
            this.lbl_ClientNameResult.AutoSize = true;
            this.lbl_ClientNameResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientNameResult.Location = new System.Drawing.Point(566, 69);
            this.lbl_ClientNameResult.Name = "lbl_ClientNameResult";
            this.lbl_ClientNameResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_ClientNameResult.TabIndex = 49;
            this.lbl_ClientNameResult.Text = "default";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientName.Location = new System.Drawing.Point(423, 75);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(146, 19);
            this.lbl_ClientName.TabIndex = 48;
            this.lbl_ClientName.Text = "Megrendelő neve:";
            // 
            // lbl_ClientPhoneResult
            // 
            this.lbl_ClientPhoneResult.AutoSize = true;
            this.lbl_ClientPhoneResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientPhoneResult.Location = new System.Drawing.Point(566, 99);
            this.lbl_ClientPhoneResult.Name = "lbl_ClientPhoneResult";
            this.lbl_ClientPhoneResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_ClientPhoneResult.TabIndex = 47;
            this.lbl_ClientPhoneResult.Text = "default";
            // 
            // lbl_ClientPhone
            // 
            this.lbl_ClientPhone.AutoSize = true;
            this.lbl_ClientPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ClientPhone.Location = new System.Drawing.Point(358, 105);
            this.lbl_ClientPhone.Name = "lbl_ClientPhone";
            this.lbl_ClientPhone.Size = new System.Drawing.Size(211, 19);
            this.lbl_ClientPhone.TabIndex = 46;
            this.lbl_ClientPhone.Text = "Megrendelő telefonszáma:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 37);
            this.label12.TabIndex = 52;
            this.label12.Text = "Árajánlat";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Drinks
            // 
            this.lbl_Drinks.AutoSize = true;
            this.lbl_Drinks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Drinks.Location = new System.Drawing.Point(57, 368);
            this.lbl_Drinks.Name = "lbl_Drinks";
            this.lbl_Drinks.Size = new System.Drawing.Size(98, 19);
            this.lbl_Drinks.TabIndex = 53;
            this.lbl_Drinks.Text = "Italcsomag:";
            // 
            // lbl_DrinksResult
            // 
            this.lbl_DrinksResult.AutoSize = true;
            this.lbl_DrinksResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinksResult.Location = new System.Drawing.Point(150, 365);
            this.lbl_DrinksResult.Name = "lbl_DrinksResult";
            this.lbl_DrinksResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_DrinksResult.TabIndex = 54;
            this.lbl_DrinksResult.Text = "default";
            // 
            // lbl_MenuSalePricePerPersonResult
            // 
            this.lbl_MenuSalePricePerPersonResult.AutoSize = true;
            this.lbl_MenuSalePricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuSalePricePerPersonResult.Location = new System.Drawing.Point(299, 550);
            this.lbl_MenuSalePricePerPersonResult.Name = "lbl_MenuSalePricePerPersonResult";
            this.lbl_MenuSalePricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MenuSalePricePerPersonResult.TabIndex = 72;
            this.lbl_MenuSalePricePerPersonResult.Text = "default";
            // 
            // lbl_MenuSalePricePerPerson
            // 
            this.lbl_MenuSalePricePerPerson.AutoSize = true;
            this.lbl_MenuSalePricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuSalePricePerPerson.Location = new System.Drawing.Point(36, 559);
            this.lbl_MenuSalePricePerPerson.Name = "lbl_MenuSalePricePerPerson";
            this.lbl_MenuSalePricePerPerson.Size = new System.Drawing.Size(257, 19);
            this.lbl_MenuSalePricePerPerson.TabIndex = 71;
            this.lbl_MenuSalePricePerPerson.Text = "Menü és italok eladási ára 1 főre:";
            // 
            // lbl_TotalPriceEventResult
            // 
            this.lbl_TotalPriceEventResult.AutoSize = true;
            this.lbl_TotalPriceEventResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_TotalPriceEventResult.Location = new System.Drawing.Point(366, 682);
            this.lbl_TotalPriceEventResult.Name = "lbl_TotalPriceEventResult";
            this.lbl_TotalPriceEventResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_TotalPriceEventResult.TabIndex = 70;
            this.lbl_TotalPriceEventResult.Text = "default";
            // 
            // lbl_PlaceRentingPriceResult
            // 
            this.lbl_PlaceRentingPriceResult.AutoSize = true;
            this.lbl_PlaceRentingPriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_PlaceRentingPriceResult.Location = new System.Drawing.Point(299, 644);
            this.lbl_PlaceRentingPriceResult.Name = "lbl_PlaceRentingPriceResult";
            this.lbl_PlaceRentingPriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_PlaceRentingPriceResult.TabIndex = 69;
            this.lbl_PlaceRentingPriceResult.Text = "default";
            // 
            // lbl_EmployeePriceResult
            // 
            this.lbl_EmployeePriceResult.AutoSize = true;
            this.lbl_EmployeePriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EmployeePriceResult.Location = new System.Drawing.Point(299, 613);
            this.lbl_EmployeePriceResult.Name = "lbl_EmployeePriceResult";
            this.lbl_EmployeePriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_EmployeePriceResult.TabIndex = 68;
            this.lbl_EmployeePriceResult.Text = "default";
            // 
            // lbl_MenuTotalSalePriceResult
            // 
            this.lbl_MenuTotalSalePriceResult.AutoSize = true;
            this.lbl_MenuTotalSalePriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuTotalSalePriceResult.Location = new System.Drawing.Point(299, 583);
            this.lbl_MenuTotalSalePriceResult.Name = "lbl_MenuTotalSalePriceResult";
            this.lbl_MenuTotalSalePriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MenuTotalSalePriceResult.TabIndex = 67;
            this.lbl_MenuTotalSalePriceResult.Text = "default";
            // 
            // lbl_DrinkMenuTotalSalePriceResult
            // 
            this.lbl_DrinkMenuTotalSalePriceResult.AutoSize = true;
            this.lbl_DrinkMenuTotalSalePriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuTotalSalePriceResult.Location = new System.Drawing.Point(299, 520);
            this.lbl_DrinkMenuTotalSalePriceResult.Name = "lbl_DrinkMenuTotalSalePriceResult";
            this.lbl_DrinkMenuTotalSalePriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_DrinkMenuTotalSalePriceResult.TabIndex = 66;
            this.lbl_DrinkMenuTotalSalePriceResult.Text = "default";
            // 
            // lbl_MealMenuTotalSalePriceResult
            // 
            this.lbl_MealMenuTotalSalePriceResult.AutoSize = true;
            this.lbl_MealMenuTotalSalePriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuTotalSalePriceResult.Location = new System.Drawing.Point(299, 461);
            this.lbl_MealMenuTotalSalePriceResult.Name = "lbl_MealMenuTotalSalePriceResult";
            this.lbl_MealMenuTotalSalePriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MealMenuTotalSalePriceResult.TabIndex = 65;
            this.lbl_MealMenuTotalSalePriceResult.Text = "default";
            // 
            // lbl_DrinkMenuSalePricePerPersonResult
            // 
            this.lbl_DrinkMenuSalePricePerPersonResult.AutoSize = true;
            this.lbl_DrinkMenuSalePricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuSalePricePerPersonResult.Location = new System.Drawing.Point(299, 491);
            this.lbl_DrinkMenuSalePricePerPersonResult.Name = "lbl_DrinkMenuSalePricePerPersonResult";
            this.lbl_DrinkMenuSalePricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_DrinkMenuSalePricePerPersonResult.TabIndex = 64;
            this.lbl_DrinkMenuSalePricePerPersonResult.Text = "default";
            // 
            // lbl_MealMenuSalePricePerPersonResult
            // 
            this.lbl_MealMenuSalePricePerPersonResult.AutoSize = true;
            this.lbl_MealMenuSalePricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuSalePricePerPersonResult.Location = new System.Drawing.Point(299, 430);
            this.lbl_MealMenuSalePricePerPersonResult.Name = "lbl_MealMenuSalePricePerPersonResult";
            this.lbl_MealMenuSalePricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MealMenuSalePricePerPersonResult.TabIndex = 63;
            this.lbl_MealMenuSalePricePerPersonResult.Text = "default";
            // 
            // lbl_TotalPriceEvent
            // 
            this.lbl_TotalPriceEvent.AutoSize = true;
            this.lbl_TotalPriceEvent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_TotalPriceEvent.Location = new System.Drawing.Point(82, 682);
            this.lbl_TotalPriceEvent.Name = "lbl_TotalPriceEvent";
            this.lbl_TotalPriceEvent.Size = new System.Drawing.Size(283, 24);
            this.lbl_TotalPriceEvent.TabIndex = 62;
            this.lbl_TotalPriceEvent.Text = "Rendezvény ára összesen:";
            // 
            // lbl_MealMenuSalePricePerPerson
            // 
            this.lbl_MealMenuSalePricePerPerson.AutoSize = true;
            this.lbl_MealMenuSalePricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuSalePricePerPerson.Location = new System.Drawing.Point(103, 438);
            this.lbl_MealMenuSalePricePerPerson.Name = "lbl_MealMenuSalePricePerPerson";
            this.lbl_MealMenuSalePricePerPerson.Size = new System.Drawing.Size(190, 19);
            this.lbl_MealMenuSalePricePerPerson.TabIndex = 57;
            this.lbl_MealMenuSalePricePerPerson.Text = "Menü eladási ára 1 főre:";
            // 
            // lbl_PlaceRentingPrice
            // 
            this.lbl_PlaceRentingPrice.AutoSize = true;
            this.lbl_PlaceRentingPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_PlaceRentingPrice.Location = new System.Drawing.Point(177, 652);
            this.lbl_PlaceRentingPrice.Name = "lbl_PlaceRentingPrice";
            this.lbl_PlaceRentingPrice.Size = new System.Drawing.Size(118, 19);
            this.lbl_PlaceRentingPrice.TabIndex = 61;
            this.lbl_PlaceRentingPrice.Text = "Helybérleti díj:";
            // 
            // lbl_MenuTotalSalePrice
            // 
            this.lbl_MenuTotalSalePrice.AutoSize = true;
            this.lbl_MenuTotalSalePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuTotalSalePrice.Location = new System.Drawing.Point(39, 589);
            this.lbl_MenuTotalSalePrice.Name = "lbl_MenuTotalSalePrice";
            this.lbl_MenuTotalSalePrice.Size = new System.Drawing.Size(254, 19);
            this.lbl_MenuTotalSalePrice.TabIndex = 55;
            this.lbl_MenuTotalSalePrice.Text = "Menü és italok teljes eladási ára:";
            // 
            // lbl_EmployeePrice
            // 
            this.lbl_EmployeePrice.AutoSize = true;
            this.lbl_EmployeePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_EmployeePrice.Location = new System.Drawing.Point(120, 619);
            this.lbl_EmployeePrice.Name = "lbl_EmployeePrice";
            this.lbl_EmployeePrice.Size = new System.Drawing.Size(173, 19);
            this.lbl_EmployeePrice.TabIndex = 60;
            this.lbl_EmployeePrice.Text = "Munkaerő teljes bére:";
            // 
            // lbl_DrinkMenuSalePricePerPerson
            // 
            this.lbl_DrinkMenuSalePricePerPerson.AutoSize = true;
            this.lbl_DrinkMenuSalePricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuSalePricePerPerson.Location = new System.Drawing.Point(104, 499);
            this.lbl_DrinkMenuSalePricePerPerson.Name = "lbl_DrinkMenuSalePricePerPerson";
            this.lbl_DrinkMenuSalePricePerPerson.Size = new System.Drawing.Size(189, 19);
            this.lbl_DrinkMenuSalePricePerPerson.TabIndex = 56;
            this.lbl_DrinkMenuSalePricePerPerson.Text = "Italok eladási ára 1 főre:";
            // 
            // lbl_DrinkMenuTotalsSalePrice
            // 
            this.lbl_DrinkMenuTotalsSalePrice.AutoSize = true;
            this.lbl_DrinkMenuTotalsSalePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuTotalsSalePrice.Location = new System.Drawing.Point(14, 528);
            this.lbl_DrinkMenuTotalsSalePrice.Name = "lbl_DrinkMenuTotalsSalePrice";
            this.lbl_DrinkMenuTotalsSalePrice.Size = new System.Drawing.Size(281, 19);
            this.lbl_DrinkMenuTotalsSalePrice.TabIndex = 59;
            this.lbl_DrinkMenuTotalsSalePrice.Text = "Italok eladási ára a teljes létszámra: ";
            // 
            // lbl_MealMenuTotalSalePrice
            // 
            this.lbl_MealMenuTotalSalePrice.AutoSize = true;
            this.lbl_MealMenuTotalSalePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuTotalSalePrice.Location = new System.Drawing.Point(15, 467);
            this.lbl_MealMenuTotalSalePrice.Name = "lbl_MealMenuTotalSalePrice";
            this.lbl_MealMenuTotalSalePrice.Size = new System.Drawing.Size(278, 19);
            this.lbl_MealMenuTotalSalePrice.TabIndex = 58;
            this.lbl_MealMenuTotalSalePrice.Text = "Menü eladási ára a teljes létszámra:";
            // 
            // btn_CreatePDF
            // 
            this.btn_CreatePDF.Location = new System.Drawing.Point(659, 676);
            this.btn_CreatePDF.Name = "btn_CreatePDF";
            this.btn_CreatePDF.Size = new System.Drawing.Size(165, 30);
            this.btn_CreatePDF.TabIndex = 73;
            this.btn_CreatePDF.Text = "PDF készítése ";
            this.btn_CreatePDF.UseVisualStyleBackColor = true;
            this.btn_CreatePDF.Click += new System.EventHandler(this.btn_CreateClientPDF_Click);
            // 
            // dtgv_Employees
            // 
            this.dtgv_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeType,
            this.numberOfEmployee});
            this.dtgv_Employees.Location = new System.Drawing.Point(499, 201);
            this.dtgv_Employees.Name = "dtgv_Employees";
            this.dtgv_Employees.ReadOnly = true;
            this.dtgv_Employees.Size = new System.Drawing.Size(250, 150);
            this.dtgv_Employees.TabIndex = 75;
            // 
            // employeeType
            // 
            this.employeeType.HeaderText = "Munkakör";
            this.employeeType.Name = "employeeType";
            this.employeeType.ReadOnly = true;
            // 
            // numberOfEmployee
            // 
            this.numberOfEmployee.HeaderText = "Darab";
            this.numberOfEmployee.Name = "numberOfEmployee";
            this.numberOfEmployee.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(495, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 19);
            this.label16.TabIndex = 76;
            this.label16.Text = "Alkalmazottak listája:";
            // 
            // lbl_MenuDevPricePerPersonResult
            // 
            this.lbl_MenuDevPricePerPersonResult.AutoSize = true;
            this.lbl_MenuDevPricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuDevPricePerPersonResult.Location = new System.Drawing.Point(736, 553);
            this.lbl_MenuDevPricePerPersonResult.Name = "lbl_MenuDevPricePerPersonResult";
            this.lbl_MenuDevPricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MenuDevPricePerPersonResult.TabIndex = 89;
            this.lbl_MenuDevPricePerPersonResult.Text = "default";
            // 
            // lbl_MenuDevPricePerPerson
            // 
            this.lbl_MenuDevPricePerPerson.AutoSize = true;
            this.lbl_MenuDevPricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuDevPricePerPerson.Location = new System.Drawing.Point(444, 557);
            this.lbl_MenuDevPricePerPerson.Name = "lbl_MenuDevPricePerPerson";
            this.lbl_MenuDevPricePerPerson.Size = new System.Drawing.Size(286, 19);
            this.lbl_MenuDevPricePerPerson.TabIndex = 88;
            this.lbl_MenuDevPricePerPerson.Text = "Menü és italok beszerzési ára 1 főre:";
            // 
            // lbl_MenuTotalDevPriceResult
            // 
            this.lbl_MenuTotalDevPriceResult.AutoSize = true;
            this.lbl_MenuTotalDevPriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuTotalDevPriceResult.Location = new System.Drawing.Point(736, 581);
            this.lbl_MenuTotalDevPriceResult.Name = "lbl_MenuTotalDevPriceResult";
            this.lbl_MenuTotalDevPriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MenuTotalDevPriceResult.TabIndex = 87;
            this.lbl_MenuTotalDevPriceResult.Text = "default";
            // 
            // lbl_DrinkMenuTotalDevPriceResult
            // 
            this.lbl_DrinkMenuTotalDevPriceResult.AutoSize = true;
            this.lbl_DrinkMenuTotalDevPriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuTotalDevPriceResult.Location = new System.Drawing.Point(736, 524);
            this.lbl_DrinkMenuTotalDevPriceResult.Name = "lbl_DrinkMenuTotalDevPriceResult";
            this.lbl_DrinkMenuTotalDevPriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_DrinkMenuTotalDevPriceResult.TabIndex = 86;
            this.lbl_DrinkMenuTotalDevPriceResult.Text = "default";
            // 
            // lbl_MealMenuTotalDevPriceResult
            // 
            this.lbl_MealMenuTotalDevPriceResult.AutoSize = true;
            this.lbl_MealMenuTotalDevPriceResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuTotalDevPriceResult.Location = new System.Drawing.Point(736, 459);
            this.lbl_MealMenuTotalDevPriceResult.Name = "lbl_MealMenuTotalDevPriceResult";
            this.lbl_MealMenuTotalDevPriceResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MealMenuTotalDevPriceResult.TabIndex = 85;
            this.lbl_MealMenuTotalDevPriceResult.Text = "default";
            // 
            // lbl_DrinkMenuDevPricePerPersonResult
            // 
            this.lbl_DrinkMenuDevPricePerPersonResult.AutoSize = true;
            this.lbl_DrinkMenuDevPricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuDevPricePerPersonResult.Location = new System.Drawing.Point(736, 495);
            this.lbl_DrinkMenuDevPricePerPersonResult.Name = "lbl_DrinkMenuDevPricePerPersonResult";
            this.lbl_DrinkMenuDevPricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_DrinkMenuDevPricePerPersonResult.TabIndex = 84;
            this.lbl_DrinkMenuDevPricePerPersonResult.Text = "default";
            // 
            // lbl_MealMenuDevPricePerPersonResult
            // 
            this.lbl_MealMenuDevPricePerPersonResult.AutoSize = true;
            this.lbl_MealMenuDevPricePerPersonResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuDevPricePerPersonResult.Location = new System.Drawing.Point(736, 430);
            this.lbl_MealMenuDevPricePerPersonResult.Name = "lbl_MealMenuDevPricePerPersonResult";
            this.lbl_MealMenuDevPricePerPersonResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_MealMenuDevPricePerPersonResult.TabIndex = 83;
            this.lbl_MealMenuDevPricePerPersonResult.Text = "default";
            // 
            // lbl_MealMenuDevPricePerPerson
            // 
            this.lbl_MealMenuDevPricePerPerson.AutoSize = true;
            this.lbl_MealMenuDevPricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuDevPricePerPerson.Location = new System.Drawing.Point(511, 434);
            this.lbl_MealMenuDevPricePerPerson.Name = "lbl_MealMenuDevPricePerPerson";
            this.lbl_MealMenuDevPricePerPerson.Size = new System.Drawing.Size(219, 19);
            this.lbl_MealMenuDevPricePerPerson.TabIndex = 80;
            this.lbl_MealMenuDevPricePerPerson.Text = "Menü beszerzési ára 1 főre:";
            // 
            // lbl_MenuTotalDevPrice
            // 
            this.lbl_MenuTotalDevPrice.AutoSize = true;
            this.lbl_MenuTotalDevPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MenuTotalDevPrice.Location = new System.Drawing.Point(447, 587);
            this.lbl_MenuTotalDevPrice.Name = "lbl_MenuTotalDevPrice";
            this.lbl_MenuTotalDevPrice.Size = new System.Drawing.Size(283, 19);
            this.lbl_MenuTotalDevPrice.TabIndex = 78;
            this.lbl_MenuTotalDevPrice.Text = "Menü és italok teljes beszerzési ára:";
            // 
            // lbl_DrinkMenuDevPricePerPerson
            // 
            this.lbl_DrinkMenuDevPricePerPerson.AutoSize = true;
            this.lbl_DrinkMenuDevPricePerPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuDevPricePerPerson.Location = new System.Drawing.Point(599, 499);
            this.lbl_DrinkMenuDevPricePerPerson.Name = "lbl_DrinkMenuDevPricePerPerson";
            this.lbl_DrinkMenuDevPricePerPerson.Size = new System.Drawing.Size(131, 19);
            this.lbl_DrinkMenuDevPricePerPerson.TabIndex = 79;
            this.lbl_DrinkMenuDevPricePerPerson.Text = "Italok ára 1 főre:";
            // 
            // lbl_DrinkMenuTotalsDevPrice
            // 
            this.lbl_DrinkMenuTotalsDevPrice.AutoSize = true;
            this.lbl_DrinkMenuTotalsDevPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DrinkMenuTotalsDevPrice.Location = new System.Drawing.Point(423, 528);
            this.lbl_DrinkMenuTotalsDevPrice.Name = "lbl_DrinkMenuTotalsDevPrice";
            this.lbl_DrinkMenuTotalsDevPrice.Size = new System.Drawing.Size(310, 19);
            this.lbl_DrinkMenuTotalsDevPrice.TabIndex = 82;
            this.lbl_DrinkMenuTotalsDevPrice.Text = "Italok beszerzési ára a teljes létszámra: ";
            // 
            // lbl_MealMenuTotalDevPrice
            // 
            this.lbl_MealMenuTotalDevPrice.AutoSize = true;
            this.lbl_MealMenuTotalDevPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MealMenuTotalDevPrice.Location = new System.Drawing.Point(423, 463);
            this.lbl_MealMenuTotalDevPrice.Name = "lbl_MealMenuTotalDevPrice";
            this.lbl_MealMenuTotalDevPrice.Size = new System.Drawing.Size(307, 19);
            this.lbl_MealMenuTotalDevPrice.TabIndex = 81;
            this.lbl_MealMenuTotalDevPrice.Text = "Menü beszerzési ára a teljes létszámra:";
            // 
            // lbl_ProfitResult
            // 
            this.lbl_ProfitResult.AutoSize = true;
            this.lbl_ProfitResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ProfitResult.Location = new System.Drawing.Point(366, 711);
            this.lbl_ProfitResult.Name = "lbl_ProfitResult";
            this.lbl_ProfitResult.Size = new System.Drawing.Size(66, 25);
            this.lbl_ProfitResult.TabIndex = 91;
            this.lbl_ProfitResult.Text = "default";
            // 
            // lbl_Profit
            // 
            this.lbl_Profit.AutoSize = true;
            this.lbl_Profit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Profit.Location = new System.Drawing.Point(294, 711);
            this.lbl_Profit.Name = "lbl_Profit";
            this.lbl_Profit.Size = new System.Drawing.Size(71, 24);
            this.lbl_Profit.TabIndex = 90;
            this.lbl_Profit.Text = "Profit:";
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(12, 715);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(96, 27);
            this.btn_MainMenu.TabIndex = 92;
            this.btn_MainMenu.Text = "Főmenü";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 748);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(96, 27);
            this.btn_Exit.TabIndex = 93;
            this.btn_Exit.Text = "Kilépés";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_NewEventTender
            // 
            this.btn_NewEventTender.Location = new System.Drawing.Point(659, 711);
            this.btn_NewEventTender.Name = "btn_NewEventTender";
            this.btn_NewEventTender.Size = new System.Drawing.Size(165, 33);
            this.btn_NewEventTender.TabIndex = 94;
            this.btn_NewEventTender.Text = "Új árajánlat készítése";
            this.btn_NewEventTender.UseVisualStyleBackColor = true;
            this.btn_NewEventTender.Click += new System.EventHandler(this.btn_NewTender_Click);
            // 
            // btn_Tenders
            // 
            this.btn_Tenders.Location = new System.Drawing.Point(641, 750);
            this.btn_Tenders.Name = "btn_Tenders";
            this.btn_Tenders.Size = new System.Drawing.Size(200, 33);
            this.btn_Tenders.TabIndex = 95;
            this.btn_Tenders.Text = "Árajánlatok megtekintése";
            this.btn_Tenders.UseVisualStyleBackColor = true;
            this.btn_Tenders.Click += new System.EventHandler(this.btn_AllTenders_Click);
            // 
            // frm_CheckTender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(850, 788);
            this.Controls.Add(this.btn_Tenders);
            this.Controls.Add(this.btn_NewEventTender);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.lbl_ProfitResult);
            this.Controls.Add(this.lbl_Profit);
            this.Controls.Add(this.lbl_MenuDevPricePerPersonResult);
            this.Controls.Add(this.lbl_MenuDevPricePerPerson);
            this.Controls.Add(this.lbl_MenuTotalDevPriceResult);
            this.Controls.Add(this.lbl_DrinkMenuTotalDevPriceResult);
            this.Controls.Add(this.lbl_MealMenuTotalDevPriceResult);
            this.Controls.Add(this.lbl_DrinkMenuDevPricePerPersonResult);
            this.Controls.Add(this.lbl_MealMenuDevPricePerPersonResult);
            this.Controls.Add(this.lbl_MealMenuDevPricePerPerson);
            this.Controls.Add(this.lbl_MenuTotalDevPrice);
            this.Controls.Add(this.lbl_DrinkMenuDevPricePerPerson);
            this.Controls.Add(this.lbl_DrinkMenuTotalsDevPrice);
            this.Controls.Add(this.lbl_MealMenuTotalDevPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtgv_Employees);
            this.Controls.Add(this.btn_CreatePDF);
            this.Controls.Add(this.lbl_MenuSalePricePerPersonResult);
            this.Controls.Add(this.lbl_MenuSalePricePerPerson);
            this.Controls.Add(this.lbl_TotalPriceEventResult);
            this.Controls.Add(this.lbl_PlaceRentingPriceResult);
            this.Controls.Add(this.lbl_EmployeePriceResult);
            this.Controls.Add(this.lbl_MenuTotalSalePriceResult);
            this.Controls.Add(this.lbl_DrinkMenuTotalSalePriceResult);
            this.Controls.Add(this.lbl_MealMenuTotalSalePriceResult);
            this.Controls.Add(this.lbl_DrinkMenuSalePricePerPersonResult);
            this.Controls.Add(this.lbl_MealMenuSalePricePerPersonResult);
            this.Controls.Add(this.lbl_TotalPriceEvent);
            this.Controls.Add(this.lbl_MealMenuSalePricePerPerson);
            this.Controls.Add(this.lbl_PlaceRentingPrice);
            this.Controls.Add(this.lbl_MenuTotalSalePrice);
            this.Controls.Add(this.lbl_EmployeePrice);
            this.Controls.Add(this.lbl_DrinkMenuSalePricePerPerson);
            this.Controls.Add(this.lbl_DrinkMenuTotalsSalePrice);
            this.Controls.Add(this.lbl_MealMenuTotalSalePrice);
            this.Controls.Add(this.lbl_DrinksResult);
            this.Controls.Add(this.lbl_Drinks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_ClientEmailResult);
            this.Controls.Add(this.lbl_ClientEmail);
            this.Controls.Add(this.lbl_ClientNameResult);
            this.Controls.Add(this.lbl_ClientName);
            this.Controls.Add(this.lbl_ClientPhoneResult);
            this.Controls.Add(this.lbl_ClientPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_EventDateResult);
            this.Controls.Add(this.lbl_EventDate);
            this.Controls.Add(this.lbl_EventTypeResult);
            this.Controls.Add(this.lbl_EventType);
            this.Controls.Add(this.lbl_NumberOfGuestsResult);
            this.Controls.Add(this.lbl_NumberOfGuests);
            this.Controls.Add(this.dtgv_Meals);
            this.Controls.Add(this.lbl_AppTitle);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 830);
            this.MinimumSize = new System.Drawing.Size(870, 830);
            this.Name = "frm_CheckTender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Árajánlat megtekintése";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Meals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.DataGridView dtgv_Meals;
        private System.Windows.Forms.Label lbl_NumberOfGuests;
        private System.Windows.Forms.Label lbl_NumberOfGuestsResult;
        private System.Windows.Forms.Label lbl_EventTypeResult;
        private System.Windows.Forms.Label lbl_EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealPortion;
        private System.Windows.Forms.Label lbl_EventDateResult;
        private System.Windows.Forms.Label lbl_EventDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ClientEmailResult;
        private System.Windows.Forms.Label lbl_ClientEmail;
        private System.Windows.Forms.Label lbl_ClientNameResult;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.Label lbl_ClientPhoneResult;
        private System.Windows.Forms.Label lbl_ClientPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Drinks;
        private System.Windows.Forms.Label lbl_DrinksResult;
        private System.Windows.Forms.Label lbl_MenuSalePricePerPersonResult;
        private System.Windows.Forms.Label lbl_MenuSalePricePerPerson;
        private System.Windows.Forms.Label lbl_TotalPriceEventResult;
        private System.Windows.Forms.Label lbl_PlaceRentingPriceResult;
        private System.Windows.Forms.Label lbl_EmployeePriceResult;
        private System.Windows.Forms.Label lbl_MenuTotalSalePriceResult;
        private System.Windows.Forms.Label lbl_DrinkMenuTotalSalePriceResult;
        private System.Windows.Forms.Label lbl_MealMenuTotalSalePriceResult;
        private System.Windows.Forms.Label lbl_DrinkMenuSalePricePerPersonResult;
        private System.Windows.Forms.Label lbl_MealMenuSalePricePerPersonResult;
        private System.Windows.Forms.Label lbl_TotalPriceEvent;
        private System.Windows.Forms.Label lbl_MealMenuSalePricePerPerson;
        private System.Windows.Forms.Label lbl_PlaceRentingPrice;
        private System.Windows.Forms.Label lbl_MenuTotalSalePrice;
        private System.Windows.Forms.Label lbl_EmployeePrice;
        private System.Windows.Forms.Label lbl_DrinkMenuSalePricePerPerson;
        private System.Windows.Forms.Label lbl_DrinkMenuTotalsSalePrice;
        private System.Windows.Forms.Label lbl_MealMenuTotalSalePrice;
        private System.Windows.Forms.Button btn_CreatePDF;
        private System.Windows.Forms.DataGridView dtgv_Employees;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfEmployee;
        private System.Windows.Forms.Label lbl_MenuDevPricePerPersonResult;
        private System.Windows.Forms.Label lbl_MenuDevPricePerPerson;
        private System.Windows.Forms.Label lbl_MenuTotalDevPriceResult;
        private System.Windows.Forms.Label lbl_DrinkMenuTotalDevPriceResult;
        private System.Windows.Forms.Label lbl_MealMenuTotalDevPriceResult;
        private System.Windows.Forms.Label lbl_DrinkMenuDevPricePerPersonResult;
        private System.Windows.Forms.Label lbl_MealMenuDevPricePerPersonResult;
        private System.Windows.Forms.Label lbl_MealMenuDevPricePerPerson;
        private System.Windows.Forms.Label lbl_MenuTotalDevPrice;
        private System.Windows.Forms.Label lbl_DrinkMenuDevPricePerPerson;
        private System.Windows.Forms.Label lbl_DrinkMenuTotalsDevPrice;
        private System.Windows.Forms.Label lbl_MealMenuTotalDevPrice;
        private System.Windows.Forms.Label lbl_ProfitResult;
        private System.Windows.Forms.Label lbl_Profit;
        private System.Windows.Forms.SaveFileDialog sfd_SavePDF;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_NewEventTender;
        private System.Windows.Forms.Button btn_Tenders;
    }
}