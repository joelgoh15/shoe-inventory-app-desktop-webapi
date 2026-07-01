namespace desktop_web_proj1
{
    partial class formShoeInventoryApplication
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
            this.components = new System.ComponentModel.Container();
            this.tabControlShoeInventoryApplication = new System.Windows.Forms.TabControl();
            this.tabPageGetAllShoeItem = new System.Windows.Forms.TabPage();
            this.labelGetAllShoeItemsSectionDetailsData = new System.Windows.Forms.Label();
            this.labelGetAllShoeItemsSectionDetails = new System.Windows.Forms.Label();
            this.buttonGetAllShoeItemSeectionGetShoeList = new System.Windows.Forms.Button();
            this.dataGridViewGetAAllShoeItem = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeInventoryTableModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageGetShoeItemById = new System.Windows.Forms.TabPage();
            this.labelGetShoeItemByIdSectionDetailsData = new System.Windows.Forms.Label();
            this.labelGetShoeItemByIdSectionDetails = new System.Windows.Forms.Label();
            this.buttonGetShoeItemByIdSubmit = new System.Windows.Forms.Button();
            this.buttonGetShoeItemByIdClearAll = new System.Windows.Forms.Button();
            this.textBoxoGetShoeItemByIdSectionEnterShoeId = new System.Windows.Forms.TextBox();
            this.labelEnterShoeId = new System.Windows.Forms.Label();
            this.tabPageAddShoeItem = new System.Windows.Forms.TabPage();
            this.textBoxAddShoeItemSectionShoeId = new System.Windows.Forms.TextBox();
            this.labelAddShoeItemSectionShoeId = new System.Windows.Forms.Label();
            this.textBoxAddShoeItemSectionShoeSize = new System.Windows.Forms.TextBox();
            this.labelAddShoeItemSectionShoeSize = new System.Windows.Forms.Label();
            this.labelAddShoeItemSectionDetailsData = new System.Windows.Forms.Label();
            this.labelAddShoeItemSectionDetails = new System.Windows.Forms.Label();
            this.buttonAddShoeItemSectionClearAll = new System.Windows.Forms.Button();
            this.buttonAddShoeItemSectionSubmit = new System.Windows.Forms.Button();
            this.labelAddShoeQuantity = new System.Windows.Forms.Label();
            this.textBoxAddShoeItemSectionQuantity = new System.Windows.Forms.TextBox();
            this.labelAddShoePrice = new System.Windows.Forms.Label();
            this.textBoxAddShoeItemSectionShoePrice = new System.Windows.Forms.TextBox();
            this.textBoxAddShoeItemSectionShoeDescription = new System.Windows.Forms.TextBox();
            this.labelAddShoeDescription = new System.Windows.Forms.Label();
            this.textBoxAddShoeItemSectionShoeName = new System.Windows.Forms.TextBox();
            this.labAddShoeName = new System.Windows.Forms.Label();
            this.tabPageEditShoeItem = new System.Windows.Forms.TabPage();
            this.textBoxEditShoeItemSectionQuantity = new System.Windows.Forms.TextBox();
            this.labelEditShoeItemSectionQuantity = new System.Windows.Forms.Label();
            this.textBoxEditShoeItemSectionShoeSize = new System.Windows.Forms.TextBox();
            this.labelEditShoeItemSectionShoeSize = new System.Windows.Forms.Label();
            this.labelEditShoeItemSectionDetailsData = new System.Windows.Forms.Label();
            this.labelEditShoeItemSectionDetails = new System.Windows.Forms.Label();
            this.buttonEditSectionClearAll = new System.Windows.Forms.Button();
            this.buttonEditSectionSubmit = new System.Windows.Forms.Button();
            this.textBoxEditShoeItemSectionShoePrice = new System.Windows.Forms.TextBox();
            this.labelEditSectionShoePrice = new System.Windows.Forms.Label();
            this.textBoxEditShoeItemSectionShoeDescription = new System.Windows.Forms.TextBox();
            this.labelEditSectionShoeDescription = new System.Windows.Forms.Label();
            this.labelEditSectionShoeName = new System.Windows.Forms.Label();
            this.textBoxEditShoeItemSectionShoeName = new System.Windows.Forms.TextBox();
            this.textBoxEditShoeItemSectionShoeId = new System.Windows.Forms.TextBox();
            this.labelEditSectionShoeId = new System.Windows.Forms.Label();
            this.tabPageDeleteShoeItem = new System.Windows.Forms.TabPage();
            this.labelDeleteShoeItemByIdSectionMessageData = new System.Windows.Forms.Label();
            this.labelDeleteShoeItemByIdMessage = new System.Windows.Forms.Label();
            this.buttonDeleteShoeItemClearAll = new System.Windows.Forms.Button();
            this.buttonDeleteShoeItemSubmit = new System.Windows.Forms.Button();
            this.textBoxDeleteShoeItemSectionEnterShoeId = new System.Windows.Forms.TextBox();
            this.labelDeleteSectionEnterShoeId = new System.Windows.Forms.Label();
            this.tabControlShoeInventoryApplication.SuspendLayout();
            this.tabPageGetAllShoeItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAAllShoeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeInventoryTableModelBindingSource)).BeginInit();
            this.tabPageGetShoeItemById.SuspendLayout();
            this.tabPageAddShoeItem.SuspendLayout();
            this.tabPageEditShoeItem.SuspendLayout();
            this.tabPageDeleteShoeItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlShoeInventoryApplication
            // 
            this.tabControlShoeInventoryApplication.Controls.Add(this.tabPageGetAllShoeItem);
            this.tabControlShoeInventoryApplication.Controls.Add(this.tabPageGetShoeItemById);
            this.tabControlShoeInventoryApplication.Controls.Add(this.tabPageAddShoeItem);
            this.tabControlShoeInventoryApplication.Controls.Add(this.tabPageEditShoeItem);
            this.tabControlShoeInventoryApplication.Controls.Add(this.tabPageDeleteShoeItem);
            this.tabControlShoeInventoryApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlShoeInventoryApplication.Location = new System.Drawing.Point(0, 0);
            this.tabControlShoeInventoryApplication.Name = "tabControlShoeInventoryApplication";
            this.tabControlShoeInventoryApplication.SelectedIndex = 0;
            this.tabControlShoeInventoryApplication.Size = new System.Drawing.Size(800, 450);
            this.tabControlShoeInventoryApplication.TabIndex = 0;
            // 
            // tabPageGetAllShoeItem
            // 
            this.tabPageGetAllShoeItem.Controls.Add(this.labelGetAllShoeItemsSectionDetailsData);
            this.tabPageGetAllShoeItem.Controls.Add(this.labelGetAllShoeItemsSectionDetails);
            this.tabPageGetAllShoeItem.Controls.Add(this.buttonGetAllShoeItemSeectionGetShoeList);
            this.tabPageGetAllShoeItem.Controls.Add(this.dataGridViewGetAAllShoeItem);
            this.tabPageGetAllShoeItem.Location = new System.Drawing.Point(4, 29);
            this.tabPageGetAllShoeItem.Name = "tabPageGetAllShoeItem";
            this.tabPageGetAllShoeItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetAllShoeItem.Size = new System.Drawing.Size(792, 417);
            this.tabPageGetAllShoeItem.TabIndex = 0;
            this.tabPageGetAllShoeItem.Text = "Get All Shoe Item";
            this.tabPageGetAllShoeItem.UseVisualStyleBackColor = true;
            // 
            // labelGetAllShoeItemsSectionDetailsData
            // 
            this.labelGetAllShoeItemsSectionDetailsData.AutoSize = true;
            this.labelGetAllShoeItemsSectionDetailsData.Location = new System.Drawing.Point(6, 314);
            this.labelGetAllShoeItemsSectionDetailsData.Name = "labelGetAllShoeItemsSectionDetailsData";
            this.labelGetAllShoeItemsSectionDetailsData.Size = new System.Drawing.Size(138, 20);
            this.labelGetAllShoeItemsSectionDetailsData.TabIndex = 4;
            this.labelGetAllShoeItemsSectionDetailsData.Text = "label_details_data";
            // 
            // labelGetAllShoeItemsSectionDetails
            // 
            this.labelGetAllShoeItemsSectionDetails.AutoSize = true;
            this.labelGetAllShoeItemsSectionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetAllShoeItemsSectionDetails.Location = new System.Drawing.Point(6, 284);
            this.labelGetAllShoeItemsSectionDetails.Name = "labelGetAllShoeItemsSectionDetails";
            this.labelGetAllShoeItemsSectionDetails.Size = new System.Drawing.Size(62, 20);
            this.labelGetAllShoeItemsSectionDetails.TabIndex = 3;
            this.labelGetAllShoeItemsSectionDetails.Text = "Details:";
            // 
            // buttonGetAllShoeItemSeectionGetShoeList
            // 
            this.buttonGetAllShoeItemSeectionGetShoeList.Location = new System.Drawing.Point(628, 248);
            this.buttonGetAllShoeItemSeectionGetShoeList.Name = "buttonGetAllShoeItemSeectionGetShoeList";
            this.buttonGetAllShoeItemSeectionGetShoeList.Size = new System.Drawing.Size(158, 32);
            this.buttonGetAllShoeItemSeectionGetShoeList.TabIndex = 1;
            this.buttonGetAllShoeItemSeectionGetShoeList.Text = "Get Shoe List";
            this.buttonGetAllShoeItemSeectionGetShoeList.UseVisualStyleBackColor = true;
            this.buttonGetAllShoeItemSeectionGetShoeList.Click += new System.EventHandler(this.buttonGetAllShoeItemSeectionGetShoeList_Click);
            // 
            // dataGridViewGetAAllShoeItem
            // 
            this.dataGridViewGetAAllShoeItem.AllowUserToAddRows = false;
            this.dataGridViewGetAAllShoeItem.AllowUserToDeleteRows = false;
            this.dataGridViewGetAAllShoeItem.AllowUserToResizeRows = false;
            this.dataGridViewGetAAllShoeItem.AutoGenerateColumns = false;
            this.dataGridViewGetAAllShoeItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGetAAllShoeItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetAAllShoeItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shoeNameDataGridViewTextBoxColumn,
            this.shoeDescriptionDataGridViewTextBoxColumn,
            this.shoePriceDataGridViewTextBoxColumn,
            this.shoeSizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridViewGetAAllShoeItem.DataSource = this.shoeInventoryTableModelBindingSource;
            this.dataGridViewGetAAllShoeItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGetAAllShoeItem.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGetAAllShoeItem.MultiSelect = false;
            this.dataGridViewGetAAllShoeItem.Name = "dataGridViewGetAAllShoeItem";
            this.dataGridViewGetAAllShoeItem.ReadOnly = true;
            this.dataGridViewGetAAllShoeItem.RowHeadersWidth = 62;
            this.dataGridViewGetAAllShoeItem.RowTemplate.Height = 28;
            this.dataGridViewGetAAllShoeItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGetAAllShoeItem.Size = new System.Drawing.Size(786, 239);
            this.dataGridViewGetAAllShoeItem.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 59;
            // 
            // shoeNameDataGridViewTextBoxColumn
            // 
            this.shoeNameDataGridViewTextBoxColumn.DataPropertyName = "shoeName";
            this.shoeNameDataGridViewTextBoxColumn.HeaderText = "Shoe Name";
            this.shoeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shoeNameDataGridViewTextBoxColumn.Name = "shoeNameDataGridViewTextBoxColumn";
            this.shoeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoeDescriptionDataGridViewTextBoxColumn
            // 
            this.shoeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "shoeDescription";
            this.shoeDescriptionDataGridViewTextBoxColumn.HeaderText = "shoe Description";
            this.shoeDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shoeDescriptionDataGridViewTextBoxColumn.Name = "shoeDescriptionDataGridViewTextBoxColumn";
            this.shoeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoePriceDataGridViewTextBoxColumn
            // 
            this.shoePriceDataGridViewTextBoxColumn.DataPropertyName = "shoePrice";
            this.shoePriceDataGridViewTextBoxColumn.HeaderText = "Shoe Price";
            this.shoePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shoePriceDataGridViewTextBoxColumn.Name = "shoePriceDataGridViewTextBoxColumn";
            this.shoePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoeSizeDataGridViewTextBoxColumn
            // 
            this.shoeSizeDataGridViewTextBoxColumn.DataPropertyName = "shoeSize";
            this.shoeSizeDataGridViewTextBoxColumn.HeaderText = "Shoe Size";
            this.shoeSizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shoeSizeDataGridViewTextBoxColumn.Name = "shoeSizeDataGridViewTextBoxColumn";
            this.shoeSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoeInventoryTableModelBindingSource
            // 
            this.shoeInventoryTableModelBindingSource.DataSource = typeof(desktop_web_proj1.Model.ShoeInventoryTableModel);
            // 
            // tabPageGetShoeItemById
            // 
            this.tabPageGetShoeItemById.Controls.Add(this.labelGetShoeItemByIdSectionDetailsData);
            this.tabPageGetShoeItemById.Controls.Add(this.labelGetShoeItemByIdSectionDetails);
            this.tabPageGetShoeItemById.Controls.Add(this.buttonGetShoeItemByIdSubmit);
            this.tabPageGetShoeItemById.Controls.Add(this.buttonGetShoeItemByIdClearAll);
            this.tabPageGetShoeItemById.Controls.Add(this.textBoxoGetShoeItemByIdSectionEnterShoeId);
            this.tabPageGetShoeItemById.Controls.Add(this.labelEnterShoeId);
            this.tabPageGetShoeItemById.Location = new System.Drawing.Point(4, 29);
            this.tabPageGetShoeItemById.Name = "tabPageGetShoeItemById";
            this.tabPageGetShoeItemById.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetShoeItemById.Size = new System.Drawing.Size(792, 417);
            this.tabPageGetShoeItemById.TabIndex = 1;
            this.tabPageGetShoeItemById.Text = "Get  Shoe Item By Id";
            this.tabPageGetShoeItemById.UseVisualStyleBackColor = true;
            this.tabPageGetShoeItemById.Click += new System.EventHandler(this.tabPageGetShoeItemById_Click);
            // 
            // labelGetShoeItemByIdSectionDetailsData
            // 
            this.labelGetShoeItemByIdSectionDetailsData.AutoSize = true;
            this.labelGetShoeItemByIdSectionDetailsData.Location = new System.Drawing.Point(8, 110);
            this.labelGetShoeItemByIdSectionDetailsData.Name = "labelGetShoeItemByIdSectionDetailsData";
            this.labelGetShoeItemByIdSectionDetailsData.Size = new System.Drawing.Size(138, 20);
            this.labelGetShoeItemByIdSectionDetailsData.TabIndex = 7;
            this.labelGetShoeItemByIdSectionDetailsData.Text = "label_details_data";
            // 
            // labelGetShoeItemByIdSectionDetails
            // 
            this.labelGetShoeItemByIdSectionDetails.AutoSize = true;
            this.labelGetShoeItemByIdSectionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetShoeItemByIdSectionDetails.Location = new System.Drawing.Point(8, 90);
            this.labelGetShoeItemByIdSectionDetails.Name = "labelGetShoeItemByIdSectionDetails";
            this.labelGetShoeItemByIdSectionDetails.Size = new System.Drawing.Size(62, 20);
            this.labelGetShoeItemByIdSectionDetails.TabIndex = 6;
            this.labelGetShoeItemByIdSectionDetails.Text = "Details:";
            this.labelGetShoeItemByIdSectionDetails.Click += new System.EventHandler(this.labelGetShoeItemByIdSectionDetails_Click);
            // 
            // buttonGetShoeItemByIdSubmit
            // 
            this.buttonGetShoeItemByIdSubmit.Location = new System.Drawing.Point(480, 45);
            this.buttonGetShoeItemByIdSubmit.Name = "buttonGetShoeItemByIdSubmit";
            this.buttonGetShoeItemByIdSubmit.Size = new System.Drawing.Size(150, 32);
            this.buttonGetShoeItemByIdSubmit.TabIndex = 5;
            this.buttonGetShoeItemByIdSubmit.Text = "Submit";
            this.buttonGetShoeItemByIdSubmit.UseVisualStyleBackColor = true;
            this.buttonGetShoeItemByIdSubmit.Click += new System.EventHandler(this.buttonGetShoeItemByIdSubmit_Click);
            // 
            // buttonGetShoeItemByIdClearAll
            // 
            this.buttonGetShoeItemByIdClearAll.Location = new System.Drawing.Point(636, 45);
            this.buttonGetShoeItemByIdClearAll.Name = "buttonGetShoeItemByIdClearAll";
            this.buttonGetShoeItemByIdClearAll.Size = new System.Drawing.Size(150, 32);
            this.buttonGetShoeItemByIdClearAll.TabIndex = 4;
            this.buttonGetShoeItemByIdClearAll.Text = "Clear All";
            this.buttonGetShoeItemByIdClearAll.UseVisualStyleBackColor = true;
            this.buttonGetShoeItemByIdClearAll.Click += new System.EventHandler(this.buttonGetShoeItemByIdClearAll_Click);
            // 
            // textBoxoGetShoeItemByIdSectionEnterShoeId
            // 
            this.textBoxoGetShoeItemByIdSectionEnterShoeId.Location = new System.Drawing.Point(126, 13);
            this.textBoxoGetShoeItemByIdSectionEnterShoeId.Name = "textBoxoGetShoeItemByIdSectionEnterShoeId";
            this.textBoxoGetShoeItemByIdSectionEnterShoeId.Size = new System.Drawing.Size(660, 26);
            this.textBoxoGetShoeItemByIdSectionEnterShoeId.TabIndex = 1;
            this.textBoxoGetShoeItemByIdSectionEnterShoeId.TextChanged += new System.EventHandler(this.textBoxoGetShoeItemByIdSectionEnterShoeId_TextChanged);
            // 
            // labelEnterShoeId
            // 
            this.labelEnterShoeId.AutoSize = true;
            this.labelEnterShoeId.Location = new System.Drawing.Point(8, 16);
            this.labelEnterShoeId.Name = "labelEnterShoeId";
            this.labelEnterShoeId.Size = new System.Drawing.Size(112, 20);
            this.labelEnterShoeId.TabIndex = 0;
            this.labelEnterShoeId.Text = "Enter Shoe Id:";
            // 
            // tabPageAddShoeItem
            // 
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionShoeId);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeItemSectionShoeId);
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionShoeSize);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeItemSectionShoeSize);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeItemSectionDetailsData);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeItemSectionDetails);
            this.tabPageAddShoeItem.Controls.Add(this.buttonAddShoeItemSectionClearAll);
            this.tabPageAddShoeItem.Controls.Add(this.buttonAddShoeItemSectionSubmit);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeQuantity);
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionQuantity);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoePrice);
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionShoePrice);
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionShoeDescription);
            this.tabPageAddShoeItem.Controls.Add(this.labelAddShoeDescription);
            this.tabPageAddShoeItem.Controls.Add(this.textBoxAddShoeItemSectionShoeName);
            this.tabPageAddShoeItem.Controls.Add(this.labAddShoeName);
            this.tabPageAddShoeItem.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddShoeItem.Name = "tabPageAddShoeItem";
            this.tabPageAddShoeItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddShoeItem.Size = new System.Drawing.Size(792, 417);
            this.tabPageAddShoeItem.TabIndex = 2;
            this.tabPageAddShoeItem.Text = "Add Shoe Item";
            this.tabPageAddShoeItem.UseVisualStyleBackColor = true;
            // 
            // textBoxAddShoeItemSectionShoeId
            // 
            this.textBoxAddShoeItemSectionShoeId.Location = new System.Drawing.Point(149, 14);
            this.textBoxAddShoeItemSectionShoeId.Name = "textBoxAddShoeItemSectionShoeId";
            this.textBoxAddShoeItemSectionShoeId.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionShoeId.TabIndex = 15;
            // 
            // labelAddShoeItemSectionShoeId
            // 
            this.labelAddShoeItemSectionShoeId.AutoSize = true;
            this.labelAddShoeItemSectionShoeId.Location = new System.Drawing.Point(8, 17);
            this.labelAddShoeItemSectionShoeId.Name = "labelAddShoeItemSectionShoeId";
            this.labelAddShoeItemSectionShoeId.Size = new System.Drawing.Size(69, 20);
            this.labelAddShoeItemSectionShoeId.TabIndex = 14;
            this.labelAddShoeItemSectionShoeId.Text = "Shoe Id:";
            // 
            // textBoxAddShoeItemSectionShoeSize
            // 
            this.textBoxAddShoeItemSectionShoeSize.Location = new System.Drawing.Point(149, 142);
            this.textBoxAddShoeItemSectionShoeSize.Name = "textBoxAddShoeItemSectionShoeSize";
            this.textBoxAddShoeItemSectionShoeSize.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionShoeSize.TabIndex = 13;
            // 
            // labelAddShoeItemSectionShoeSize
            // 
            this.labelAddShoeItemSectionShoeSize.AutoSize = true;
            this.labelAddShoeItemSectionShoeSize.Location = new System.Drawing.Point(8, 145);
            this.labelAddShoeItemSectionShoeSize.Name = "labelAddShoeItemSectionShoeSize";
            this.labelAddShoeItemSectionShoeSize.Size = new System.Drawing.Size(86, 20);
            this.labelAddShoeItemSectionShoeSize.TabIndex = 12;
            this.labelAddShoeItemSectionShoeSize.Text = "Shoe Size:";
            this.labelAddShoeItemSectionShoeSize.Click += new System.EventHandler(this.labelAddShoeItemSectionShoeSize_Click);
            // 
            // labelAddShoeItemSectionDetailsData
            // 
            this.labelAddShoeItemSectionDetailsData.AutoSize = true;
            this.labelAddShoeItemSectionDetailsData.Location = new System.Drawing.Point(8, 268);
            this.labelAddShoeItemSectionDetailsData.Name = "labelAddShoeItemSectionDetailsData";
            this.labelAddShoeItemSectionDetailsData.Size = new System.Drawing.Size(138, 20);
            this.labelAddShoeItemSectionDetailsData.TabIndex = 11;
            this.labelAddShoeItemSectionDetailsData.Text = "label_details_data";
            // 
            // labelAddShoeItemSectionDetails
            // 
            this.labelAddShoeItemSectionDetails.AutoSize = true;
            this.labelAddShoeItemSectionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddShoeItemSectionDetails.Location = new System.Drawing.Point(8, 238);
            this.labelAddShoeItemSectionDetails.Name = "labelAddShoeItemSectionDetails";
            this.labelAddShoeItemSectionDetails.Size = new System.Drawing.Size(62, 20);
            this.labelAddShoeItemSectionDetails.TabIndex = 10;
            this.labelAddShoeItemSectionDetails.Text = "Details:";
            // 
            // buttonAddShoeItemSectionClearAll
            // 
            this.buttonAddShoeItemSectionClearAll.Location = new System.Drawing.Point(634, 203);
            this.buttonAddShoeItemSectionClearAll.Name = "buttonAddShoeItemSectionClearAll";
            this.buttonAddShoeItemSectionClearAll.Size = new System.Drawing.Size(150, 32);
            this.buttonAddShoeItemSectionClearAll.TabIndex = 9;
            this.buttonAddShoeItemSectionClearAll.Text = "Clear All";
            this.buttonAddShoeItemSectionClearAll.UseVisualStyleBackColor = true;
            this.buttonAddShoeItemSectionClearAll.Click += new System.EventHandler(this.buttonAddShoeItemSectionClearAll_Click);
            // 
            // buttonAddShoeItemSectionSubmit
            // 
            this.buttonAddShoeItemSectionSubmit.Location = new System.Drawing.Point(478, 203);
            this.buttonAddShoeItemSectionSubmit.Name = "buttonAddShoeItemSectionSubmit";
            this.buttonAddShoeItemSectionSubmit.Size = new System.Drawing.Size(150, 32);
            this.buttonAddShoeItemSectionSubmit.TabIndex = 8;
            this.buttonAddShoeItemSectionSubmit.Text = "Submit";
            this.buttonAddShoeItemSectionSubmit.UseVisualStyleBackColor = true;
            this.buttonAddShoeItemSectionSubmit.Click += new System.EventHandler(this.buttonAddShoeSubmit_Click);
            // 
            // labelAddShoeQuantity
            // 
            this.labelAddShoeQuantity.AutoSize = true;
            this.labelAddShoeQuantity.Location = new System.Drawing.Point(8, 174);
            this.labelAddShoeQuantity.Name = "labelAddShoeQuantity";
            this.labelAddShoeQuantity.Size = new System.Drawing.Size(72, 20);
            this.labelAddShoeQuantity.TabIndex = 7;
            this.labelAddShoeQuantity.Text = "Quantity:";
            // 
            // textBoxAddShoeItemSectionQuantity
            // 
            this.textBoxAddShoeItemSectionQuantity.Location = new System.Drawing.Point(149, 174);
            this.textBoxAddShoeItemSectionQuantity.Name = "textBoxAddShoeItemSectionQuantity";
            this.textBoxAddShoeItemSectionQuantity.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionQuantity.TabIndex = 6;
            // 
            // labelAddShoePrice
            // 
            this.labelAddShoePrice.AutoSize = true;
            this.labelAddShoePrice.Location = new System.Drawing.Point(8, 113);
            this.labelAddShoePrice.Name = "labelAddShoePrice";
            this.labelAddShoePrice.Size = new System.Drawing.Size(90, 20);
            this.labelAddShoePrice.TabIndex = 5;
            this.labelAddShoePrice.Text = "Shoe Price:";
            // 
            // textBoxAddShoeItemSectionShoePrice
            // 
            this.textBoxAddShoeItemSectionShoePrice.Location = new System.Drawing.Point(149, 110);
            this.textBoxAddShoeItemSectionShoePrice.Name = "textBoxAddShoeItemSectionShoePrice";
            this.textBoxAddShoeItemSectionShoePrice.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionShoePrice.TabIndex = 4;
            // 
            // textBoxAddShoeItemSectionShoeDescription
            // 
            this.textBoxAddShoeItemSectionShoeDescription.Location = new System.Drawing.Point(149, 78);
            this.textBoxAddShoeItemSectionShoeDescription.Name = "textBoxAddShoeItemSectionShoeDescription";
            this.textBoxAddShoeItemSectionShoeDescription.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionShoeDescription.TabIndex = 3;
            // 
            // labelAddShoeDescription
            // 
            this.labelAddShoeDescription.AutoSize = true;
            this.labelAddShoeDescription.Location = new System.Drawing.Point(8, 81);
            this.labelAddShoeDescription.Name = "labelAddShoeDescription";
            this.labelAddShoeDescription.Size = new System.Drawing.Size(135, 20);
            this.labelAddShoeDescription.TabIndex = 2;
            this.labelAddShoeDescription.Text = "Shoe Description:";
            // 
            // textBoxAddShoeItemSectionShoeName
            // 
            this.textBoxAddShoeItemSectionShoeName.Location = new System.Drawing.Point(149, 46);
            this.textBoxAddShoeItemSectionShoeName.Name = "textBoxAddShoeItemSectionShoeName";
            this.textBoxAddShoeItemSectionShoeName.Size = new System.Drawing.Size(635, 26);
            this.textBoxAddShoeItemSectionShoeName.TabIndex = 1;
            // 
            // labAddShoeName
            // 
            this.labAddShoeName.AutoSize = true;
            this.labAddShoeName.Location = new System.Drawing.Point(8, 49);
            this.labAddShoeName.Name = "labAddShoeName";
            this.labAddShoeName.Size = new System.Drawing.Size(97, 20);
            this.labAddShoeName.TabIndex = 0;
            this.labAddShoeName.Text = "Shoe Name:";
            // 
            // tabPageEditShoeItem
            // 
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionQuantity);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditShoeItemSectionQuantity);
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionShoeSize);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditShoeItemSectionShoeSize);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditShoeItemSectionDetailsData);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditShoeItemSectionDetails);
            this.tabPageEditShoeItem.Controls.Add(this.buttonEditSectionClearAll);
            this.tabPageEditShoeItem.Controls.Add(this.buttonEditSectionSubmit);
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionShoePrice);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditSectionShoePrice);
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionShoeDescription);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditSectionShoeDescription);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditSectionShoeName);
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionShoeName);
            this.tabPageEditShoeItem.Controls.Add(this.textBoxEditShoeItemSectionShoeId);
            this.tabPageEditShoeItem.Controls.Add(this.labelEditSectionShoeId);
            this.tabPageEditShoeItem.Location = new System.Drawing.Point(4, 29);
            this.tabPageEditShoeItem.Name = "tabPageEditShoeItem";
            this.tabPageEditShoeItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditShoeItem.Size = new System.Drawing.Size(792, 417);
            this.tabPageEditShoeItem.TabIndex = 3;
            this.tabPageEditShoeItem.Text = "Edit Shoe Item";
            this.tabPageEditShoeItem.UseVisualStyleBackColor = true;
            // 
            // textBoxEditShoeItemSectionQuantity
            // 
            this.textBoxEditShoeItemSectionQuantity.Location = new System.Drawing.Point(149, 173);
            this.textBoxEditShoeItemSectionQuantity.Name = "textBoxEditShoeItemSectionQuantity";
            this.textBoxEditShoeItemSectionQuantity.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionQuantity.TabIndex = 16;
            // 
            // labelEditShoeItemSectionQuantity
            // 
            this.labelEditShoeItemSectionQuantity.AutoSize = true;
            this.labelEditShoeItemSectionQuantity.Location = new System.Drawing.Point(8, 176);
            this.labelEditShoeItemSectionQuantity.Name = "labelEditShoeItemSectionQuantity";
            this.labelEditShoeItemSectionQuantity.Size = new System.Drawing.Size(72, 20);
            this.labelEditShoeItemSectionQuantity.TabIndex = 15;
            this.labelEditShoeItemSectionQuantity.Text = "Quantity:";
            // 
            // textBoxEditShoeItemSectionShoeSize
            // 
            this.textBoxEditShoeItemSectionShoeSize.Location = new System.Drawing.Point(149, 141);
            this.textBoxEditShoeItemSectionShoeSize.Name = "textBoxEditShoeItemSectionShoeSize";
            this.textBoxEditShoeItemSectionShoeSize.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionShoeSize.TabIndex = 14;
            // 
            // labelEditShoeItemSectionShoeSize
            // 
            this.labelEditShoeItemSectionShoeSize.AutoSize = true;
            this.labelEditShoeItemSectionShoeSize.Location = new System.Drawing.Point(8, 144);
            this.labelEditShoeItemSectionShoeSize.Name = "labelEditShoeItemSectionShoeSize";
            this.labelEditShoeItemSectionShoeSize.Size = new System.Drawing.Size(86, 20);
            this.labelEditShoeItemSectionShoeSize.TabIndex = 13;
            this.labelEditShoeItemSectionShoeSize.Text = "Shoe Size:";
            // 
            // labelEditShoeItemSectionDetailsData
            // 
            this.labelEditShoeItemSectionDetailsData.AutoSize = true;
            this.labelEditShoeItemSectionDetailsData.Location = new System.Drawing.Point(8, 270);
            this.labelEditShoeItemSectionDetailsData.Name = "labelEditShoeItemSectionDetailsData";
            this.labelEditShoeItemSectionDetailsData.Size = new System.Drawing.Size(138, 20);
            this.labelEditShoeItemSectionDetailsData.TabIndex = 12;
            this.labelEditShoeItemSectionDetailsData.Text = "label_details_data";
            // 
            // labelEditShoeItemSectionDetails
            // 
            this.labelEditShoeItemSectionDetails.AutoSize = true;
            this.labelEditShoeItemSectionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditShoeItemSectionDetails.Location = new System.Drawing.Point(8, 240);
            this.labelEditShoeItemSectionDetails.Name = "labelEditShoeItemSectionDetails";
            this.labelEditShoeItemSectionDetails.Size = new System.Drawing.Size(62, 20);
            this.labelEditShoeItemSectionDetails.TabIndex = 10;
            this.labelEditShoeItemSectionDetails.Text = "Details:";
            // 
            // buttonEditSectionClearAll
            // 
            this.buttonEditSectionClearAll.Location = new System.Drawing.Point(634, 205);
            this.buttonEditSectionClearAll.Name = "buttonEditSectionClearAll";
            this.buttonEditSectionClearAll.Size = new System.Drawing.Size(150, 32);
            this.buttonEditSectionClearAll.TabIndex = 9;
            this.buttonEditSectionClearAll.Text = "Clear All";
            this.buttonEditSectionClearAll.UseVisualStyleBackColor = true;
            this.buttonEditSectionClearAll.Click += new System.EventHandler(this.buttonEditSectionClearAll_Click);
            // 
            // buttonEditSectionSubmit
            // 
            this.buttonEditSectionSubmit.Location = new System.Drawing.Point(478, 205);
            this.buttonEditSectionSubmit.Name = "buttonEditSectionSubmit";
            this.buttonEditSectionSubmit.Size = new System.Drawing.Size(150, 32);
            this.buttonEditSectionSubmit.TabIndex = 8;
            this.buttonEditSectionSubmit.Text = "Submit";
            this.buttonEditSectionSubmit.UseVisualStyleBackColor = true;
            this.buttonEditSectionSubmit.Click += new System.EventHandler(this.buttonEditSectionSubmit_Click);
            // 
            // textBoxEditShoeItemSectionShoePrice
            // 
            this.textBoxEditShoeItemSectionShoePrice.Location = new System.Drawing.Point(149, 109);
            this.textBoxEditShoeItemSectionShoePrice.Name = "textBoxEditShoeItemSectionShoePrice";
            this.textBoxEditShoeItemSectionShoePrice.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionShoePrice.TabIndex = 7;
            // 
            // labelEditSectionShoePrice
            // 
            this.labelEditSectionShoePrice.AutoSize = true;
            this.labelEditSectionShoePrice.Location = new System.Drawing.Point(8, 112);
            this.labelEditSectionShoePrice.Name = "labelEditSectionShoePrice";
            this.labelEditSectionShoePrice.Size = new System.Drawing.Size(90, 20);
            this.labelEditSectionShoePrice.TabIndex = 6;
            this.labelEditSectionShoePrice.Text = "Shoe Price:";
            // 
            // textBoxEditShoeItemSectionShoeDescription
            // 
            this.textBoxEditShoeItemSectionShoeDescription.Location = new System.Drawing.Point(149, 77);
            this.textBoxEditShoeItemSectionShoeDescription.Name = "textBoxEditShoeItemSectionShoeDescription";
            this.textBoxEditShoeItemSectionShoeDescription.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionShoeDescription.TabIndex = 5;
            // 
            // labelEditSectionShoeDescription
            // 
            this.labelEditSectionShoeDescription.AutoSize = true;
            this.labelEditSectionShoeDescription.Location = new System.Drawing.Point(8, 80);
            this.labelEditSectionShoeDescription.Name = "labelEditSectionShoeDescription";
            this.labelEditSectionShoeDescription.Size = new System.Drawing.Size(135, 20);
            this.labelEditSectionShoeDescription.TabIndex = 4;
            this.labelEditSectionShoeDescription.Text = "Shoe Description:";
            // 
            // labelEditSectionShoeName
            // 
            this.labelEditSectionShoeName.AutoSize = true;
            this.labelEditSectionShoeName.Location = new System.Drawing.Point(8, 48);
            this.labelEditSectionShoeName.Name = "labelEditSectionShoeName";
            this.labelEditSectionShoeName.Size = new System.Drawing.Size(97, 20);
            this.labelEditSectionShoeName.TabIndex = 3;
            this.labelEditSectionShoeName.Text = "Shoe Name:";
            // 
            // textBoxEditShoeItemSectionShoeName
            // 
            this.textBoxEditShoeItemSectionShoeName.Location = new System.Drawing.Point(149, 45);
            this.textBoxEditShoeItemSectionShoeName.Name = "textBoxEditShoeItemSectionShoeName";
            this.textBoxEditShoeItemSectionShoeName.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionShoeName.TabIndex = 2;
            // 
            // textBoxEditShoeItemSectionShoeId
            // 
            this.textBoxEditShoeItemSectionShoeId.Location = new System.Drawing.Point(149, 13);
            this.textBoxEditShoeItemSectionShoeId.Name = "textBoxEditShoeItemSectionShoeId";
            this.textBoxEditShoeItemSectionShoeId.Size = new System.Drawing.Size(635, 26);
            this.textBoxEditShoeItemSectionShoeId.TabIndex = 1;
            // 
            // labelEditSectionShoeId
            // 
            this.labelEditSectionShoeId.AutoSize = true;
            this.labelEditSectionShoeId.Location = new System.Drawing.Point(8, 16);
            this.labelEditSectionShoeId.Name = "labelEditSectionShoeId";
            this.labelEditSectionShoeId.Size = new System.Drawing.Size(69, 20);
            this.labelEditSectionShoeId.TabIndex = 0;
            this.labelEditSectionShoeId.Text = "Shoe Id:";
            // 
            // tabPageDeleteShoeItem
            // 
            this.tabPageDeleteShoeItem.Controls.Add(this.labelDeleteShoeItemByIdSectionMessageData);
            this.tabPageDeleteShoeItem.Controls.Add(this.labelDeleteShoeItemByIdMessage);
            this.tabPageDeleteShoeItem.Controls.Add(this.buttonDeleteShoeItemClearAll);
            this.tabPageDeleteShoeItem.Controls.Add(this.buttonDeleteShoeItemSubmit);
            this.tabPageDeleteShoeItem.Controls.Add(this.textBoxDeleteShoeItemSectionEnterShoeId);
            this.tabPageDeleteShoeItem.Controls.Add(this.labelDeleteSectionEnterShoeId);
            this.tabPageDeleteShoeItem.Location = new System.Drawing.Point(4, 29);
            this.tabPageDeleteShoeItem.Name = "tabPageDeleteShoeItem";
            this.tabPageDeleteShoeItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteShoeItem.Size = new System.Drawing.Size(792, 417);
            this.tabPageDeleteShoeItem.TabIndex = 4;
            this.tabPageDeleteShoeItem.Text = "Delete Shoe Item";
            this.tabPageDeleteShoeItem.UseVisualStyleBackColor = true;
            // 
            // labelDeleteShoeItemByIdSectionMessageData
            // 
            this.labelDeleteShoeItemByIdSectionMessageData.AutoSize = true;
            this.labelDeleteShoeItemByIdSectionMessageData.Location = new System.Drawing.Point(8, 110);
            this.labelDeleteShoeItemByIdSectionMessageData.Name = "labelDeleteShoeItemByIdSectionMessageData";
            this.labelDeleteShoeItemByIdSectionMessageData.Size = new System.Drawing.Size(138, 20);
            this.labelDeleteShoeItemByIdSectionMessageData.TabIndex = 13;
            this.labelDeleteShoeItemByIdSectionMessageData.Text = "label_details_data";
            // 
            // labelDeleteShoeItemByIdMessage
            // 
            this.labelDeleteShoeItemByIdMessage.AutoSize = true;
            this.labelDeleteShoeItemByIdMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteShoeItemByIdMessage.Location = new System.Drawing.Point(8, 80);
            this.labelDeleteShoeItemByIdMessage.Name = "labelDeleteShoeItemByIdMessage";
            this.labelDeleteShoeItemByIdMessage.Size = new System.Drawing.Size(78, 20);
            this.labelDeleteShoeItemByIdMessage.TabIndex = 4;
            this.labelDeleteShoeItemByIdMessage.Text = "Message:";
            // 
            // buttonDeleteShoeItemClearAll
            // 
            this.buttonDeleteShoeItemClearAll.Location = new System.Drawing.Point(634, 45);
            this.buttonDeleteShoeItemClearAll.Name = "buttonDeleteShoeItemClearAll";
            this.buttonDeleteShoeItemClearAll.Size = new System.Drawing.Size(150, 32);
            this.buttonDeleteShoeItemClearAll.TabIndex = 3;
            this.buttonDeleteShoeItemClearAll.Text = "Clear All";
            this.buttonDeleteShoeItemClearAll.UseVisualStyleBackColor = true;
            this.buttonDeleteShoeItemClearAll.Click += new System.EventHandler(this.buttonDeleteShoeItemClearAll_Click);
            // 
            // buttonDeleteShoeItemSubmit
            // 
            this.buttonDeleteShoeItemSubmit.Location = new System.Drawing.Point(478, 45);
            this.buttonDeleteShoeItemSubmit.Name = "buttonDeleteShoeItemSubmit";
            this.buttonDeleteShoeItemSubmit.Size = new System.Drawing.Size(150, 32);
            this.buttonDeleteShoeItemSubmit.TabIndex = 2;
            this.buttonDeleteShoeItemSubmit.Text = "Submit";
            this.buttonDeleteShoeItemSubmit.UseVisualStyleBackColor = true;
            this.buttonDeleteShoeItemSubmit.Click += new System.EventHandler(this.buttonDeleteShoeItemSubmit_Click);
            // 
            // textBoxDeleteShoeItemSectionEnterShoeId
            // 
            this.textBoxDeleteShoeItemSectionEnterShoeId.Location = new System.Drawing.Point(126, 13);
            this.textBoxDeleteShoeItemSectionEnterShoeId.Name = "textBoxDeleteShoeItemSectionEnterShoeId";
            this.textBoxDeleteShoeItemSectionEnterShoeId.Size = new System.Drawing.Size(658, 26);
            this.textBoxDeleteShoeItemSectionEnterShoeId.TabIndex = 1;
            // 
            // labelDeleteSectionEnterShoeId
            // 
            this.labelDeleteSectionEnterShoeId.AutoSize = true;
            this.labelDeleteSectionEnterShoeId.Location = new System.Drawing.Point(8, 16);
            this.labelDeleteSectionEnterShoeId.Name = "labelDeleteSectionEnterShoeId";
            this.labelDeleteSectionEnterShoeId.Size = new System.Drawing.Size(112, 20);
            this.labelDeleteSectionEnterShoeId.TabIndex = 0;
            this.labelDeleteSectionEnterShoeId.Text = "Enter Shoe Id:";
            // 
            // formShoeInventoryApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlShoeInventoryApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formShoeInventoryApplication";
            this.Text = "Shoe Inventory Application (Desktop)";
            this.Load += new System.EventHandler(this.formShoeInventoryApplication_Load);
            this.tabControlShoeInventoryApplication.ResumeLayout(false);
            this.tabPageGetAllShoeItem.ResumeLayout(false);
            this.tabPageGetAllShoeItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAAllShoeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeInventoryTableModelBindingSource)).EndInit();
            this.tabPageGetShoeItemById.ResumeLayout(false);
            this.tabPageGetShoeItemById.PerformLayout();
            this.tabPageAddShoeItem.ResumeLayout(false);
            this.tabPageAddShoeItem.PerformLayout();
            this.tabPageEditShoeItem.ResumeLayout(false);
            this.tabPageEditShoeItem.PerformLayout();
            this.tabPageDeleteShoeItem.ResumeLayout(false);
            this.tabPageDeleteShoeItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlShoeInventoryApplication;
        private System.Windows.Forms.TabPage tabPageGetAllShoeItem;
        private System.Windows.Forms.TabPage tabPageGetShoeItemById;
        private System.Windows.Forms.TabPage tabPageAddShoeItem;
        private System.Windows.Forms.TabPage tabPageEditShoeItem;
        private System.Windows.Forms.TabPage tabPageDeleteShoeItem;
        private System.Windows.Forms.DataGridView dataGridViewGetAAllShoeItem;
        private System.Windows.Forms.BindingSource shoeInventoryTableModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonGetAllShoeItemSeectionGetShoeList;
        private System.Windows.Forms.TextBox textBoxoGetShoeItemByIdSectionEnterShoeId;
        private System.Windows.Forms.Label labelEnterShoeId;
        private System.Windows.Forms.Label labAddShoeName;
        private System.Windows.Forms.Label labelAddShoeDescription;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionShoeName;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionShoePrice;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionShoeDescription;
        private System.Windows.Forms.Button buttonAddShoeItemSectionSubmit;
        private System.Windows.Forms.Label labelAddShoeQuantity;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionQuantity;
        private System.Windows.Forms.Label labelAddShoePrice;
        private System.Windows.Forms.Button buttonAddShoeItemSectionClearAll;
        private System.Windows.Forms.Label labelEditSectionShoeId;
        private System.Windows.Forms.Label labelEditSectionShoeName;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionShoeName;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionShoeId;
        private System.Windows.Forms.Button buttonEditSectionSubmit;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionShoePrice;
        private System.Windows.Forms.Label labelEditSectionShoePrice;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionShoeDescription;
        private System.Windows.Forms.Label labelEditSectionShoeDescription;
        private System.Windows.Forms.Button buttonEditSectionClearAll;
        private System.Windows.Forms.Label labelDeleteSectionEnterShoeId;
        private System.Windows.Forms.TextBox textBoxDeleteShoeItemSectionEnterShoeId;
        private System.Windows.Forms.Label labelAddShoeItemSectionDetails;
        private System.Windows.Forms.Label labelEditShoeItemSectionDetails;
        private System.Windows.Forms.Button buttonDeleteShoeItemSubmit;
        private System.Windows.Forms.Label labelDeleteShoeItemByIdMessage;
        private System.Windows.Forms.Button buttonDeleteShoeItemClearAll;
        private System.Windows.Forms.Button buttonGetShoeItemByIdSubmit;
        private System.Windows.Forms.Button buttonGetShoeItemByIdClearAll;
        private System.Windows.Forms.Label labelGetShoeItemByIdSectionDetails;
        private System.Windows.Forms.Label labelGetShoeItemByIdSectionDetailsData;
        private System.Windows.Forms.Label labelAddShoeItemSectionDetailsData;
        private System.Windows.Forms.Label labelEditShoeItemSectionDetailsData;
        private System.Windows.Forms.Label labelDeleteShoeItemByIdSectionMessageData;
        private System.Windows.Forms.Label labelGetAllShoeItemsSectionDetailsData;
        private System.Windows.Forms.Label labelGetAllShoeItemsSectionDetails;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionShoeSize;
        private System.Windows.Forms.Label labelAddShoeItemSectionShoeSize;
        private System.Windows.Forms.Label labelAddShoeItemSectionShoeId;
        private System.Windows.Forms.TextBox textBoxAddShoeItemSectionShoeId;
        private System.Windows.Forms.Label labelEditShoeItemSectionShoeSize;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionQuantity;
        private System.Windows.Forms.Label labelEditShoeItemSectionQuantity;
        private System.Windows.Forms.TextBox textBoxEditShoeItemSectionShoeSize;
    }
}

