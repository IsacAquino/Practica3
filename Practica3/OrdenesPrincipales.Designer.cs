namespace Practica3
{
    partial class OrdenesPrincipales
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIDColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIDColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipViaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreightColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipAddressColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipRegionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipPostalCodeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCountryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.shippedDateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.requiredDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.orderDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ProductIdcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdColumn1,
            this.CustomerIDColumn1,
            this.EmployeeIDColumn1,
            this.OrderDateColumn1,
            this.RequiredDateColumn1,
            this.ShippedDateColumn1,
            this.ShipViaColumn1,
            this.FreightColumn1,
            this.ShipNameColumn1,
            this.ShipAddressColumn1,
            this.ShipCityColumn1,
            this.ShipRegionColumn1,
            this.ShipPostalCodeColumn1,
            this.ShipCountryColumn1,
            this.ProductIdColumn1,
            this.UnitPriceColumn1,
            this.QuantityColumn1,
            this.DiscountColumn1});
            this.ordersDataGridView.Location = new System.Drawing.Point(355, 85);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 62;
            this.ordersDataGridView.RowTemplate.Height = 28;
            this.ordersDataGridView.Size = new System.Drawing.Size(890, 384);
            this.ordersDataGridView.TabIndex = 23;
            this.ordersDataGridView.Visible = false;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellClick_1);
            // 
            // OrderIdColumn1
            // 
            this.OrderIdColumn1.DataPropertyName = "OrderID";
            this.OrderIdColumn1.HeaderText = "Orden ID";
            this.OrderIdColumn1.MinimumWidth = 8;
            this.OrderIdColumn1.Name = "OrderIdColumn1";
            this.OrderIdColumn1.Width = 150;
            // 
            // CustomerIDColumn1
            // 
            this.CustomerIDColumn1.DataPropertyName = "CustomerID";
            this.CustomerIDColumn1.HeaderText = "Cliente ID";
            this.CustomerIDColumn1.MinimumWidth = 8;
            this.CustomerIDColumn1.Name = "CustomerIDColumn1";
            this.CustomerIDColumn1.Width = 150;
            // 
            // EmployeeIDColumn1
            // 
            this.EmployeeIDColumn1.DataPropertyName = "EmployeeID";
            this.EmployeeIDColumn1.HeaderText = "EmpleadoID";
            this.EmployeeIDColumn1.MinimumWidth = 8;
            this.EmployeeIDColumn1.Name = "EmployeeIDColumn1";
            this.EmployeeIDColumn1.Width = 150;
            // 
            // OrderDateColumn1
            // 
            this.OrderDateColumn1.DataPropertyName = "OrderDate";
            this.OrderDateColumn1.HeaderText = "Datos de la orden";
            this.OrderDateColumn1.MinimumWidth = 8;
            this.OrderDateColumn1.Name = "OrderDateColumn1";
            this.OrderDateColumn1.Width = 150;
            // 
            // RequiredDateColumn1
            // 
            this.RequiredDateColumn1.DataPropertyName = "RequiredDate";
            this.RequiredDateColumn1.HeaderText = "Fecha requerida";
            this.RequiredDateColumn1.MinimumWidth = 8;
            this.RequiredDateColumn1.Name = "RequiredDateColumn1";
            this.RequiredDateColumn1.Width = 150;
            // 
            // ShippedDateColumn1
            // 
            this.ShippedDateColumn1.DataPropertyName = "ShippedDate";
            this.ShippedDateColumn1.HeaderText = "Fecha del envio";
            this.ShippedDateColumn1.MinimumWidth = 8;
            this.ShippedDateColumn1.Name = "ShippedDateColumn1";
            this.ShippedDateColumn1.Width = 150;
            // 
            // ShipViaColumn1
            // 
            this.ShipViaColumn1.DataPropertyName = "ShipVia";
            this.ShipViaColumn1.HeaderText = "Embarcar via";
            this.ShipViaColumn1.MinimumWidth = 8;
            this.ShipViaColumn1.Name = "ShipViaColumn1";
            this.ShipViaColumn1.Width = 150;
            // 
            // FreightColumn1
            // 
            this.FreightColumn1.DataPropertyName = "Freight";
            this.FreightColumn1.HeaderText = "Precio del transporte";
            this.FreightColumn1.MinimumWidth = 8;
            this.FreightColumn1.Name = "FreightColumn1";
            this.FreightColumn1.Width = 150;
            // 
            // ShipNameColumn1
            // 
            this.ShipNameColumn1.DataPropertyName = "ShipName";
            this.ShipNameColumn1.HeaderText = "Nombre del barco";
            this.ShipNameColumn1.MinimumWidth = 8;
            this.ShipNameColumn1.Name = "ShipNameColumn1";
            this.ShipNameColumn1.Width = 150;
            // 
            // ShipAddressColumn1
            // 
            this.ShipAddressColumn1.DataPropertyName = "ShipAddress";
            this.ShipAddressColumn1.HeaderText = "Direccion del envio";
            this.ShipAddressColumn1.MinimumWidth = 8;
            this.ShipAddressColumn1.Name = "ShipAddressColumn1";
            this.ShipAddressColumn1.Width = 150;
            // 
            // ShipCityColumn1
            // 
            this.ShipCityColumn1.DataPropertyName = "ShipCity";
            this.ShipCityColumn1.HeaderText = "Ciudad del envio";
            this.ShipCityColumn1.MinimumWidth = 8;
            this.ShipCityColumn1.Name = "ShipCityColumn1";
            this.ShipCityColumn1.Width = 150;
            // 
            // ShipRegionColumn1
            // 
            this.ShipRegionColumn1.DataPropertyName = "ShipRegion";
            this.ShipRegionColumn1.HeaderText = "Region del envio";
            this.ShipRegionColumn1.MinimumWidth = 8;
            this.ShipRegionColumn1.Name = "ShipRegionColumn1";
            this.ShipRegionColumn1.Width = 150;
            // 
            // ShipPostalCodeColumn1
            // 
            this.ShipPostalCodeColumn1.DataPropertyName = "ShipPostalCode";
            this.ShipPostalCodeColumn1.HeaderText = "Codigo postal del envio";
            this.ShipPostalCodeColumn1.MinimumWidth = 8;
            this.ShipPostalCodeColumn1.Name = "ShipPostalCodeColumn1";
            this.ShipPostalCodeColumn1.Width = 150;
            // 
            // ShipCountryColumn1
            // 
            this.ShipCountryColumn1.DataPropertyName = "ShipCountry";
            this.ShipCountryColumn1.HeaderText = "Pais del envio";
            this.ShipCountryColumn1.MinimumWidth = 8;
            this.ShipCountryColumn1.Name = "ShipCountryColumn1";
            this.ShipCountryColumn1.Width = 150;
            // 
            // ProductIdColumn1
            // 
            this.ProductIdColumn1.DataPropertyName = "ProductID";
            this.ProductIdColumn1.HeaderText = "ID producto";
            this.ProductIdColumn1.MinimumWidth = 8;
            this.ProductIdColumn1.Name = "ProductIdColumn1";
            this.ProductIdColumn1.Width = 150;
            // 
            // UnitPriceColumn1
            // 
            this.UnitPriceColumn1.DataPropertyName = "UnitPrice";
            this.UnitPriceColumn1.HeaderText = "Precio Unitario";
            this.UnitPriceColumn1.MinimumWidth = 8;
            this.UnitPriceColumn1.Name = "UnitPriceColumn1";
            this.UnitPriceColumn1.Width = 150;
            // 
            // QuantityColumn1
            // 
            this.QuantityColumn1.DataPropertyName = "Quantity";
            this.QuantityColumn1.HeaderText = "Cantidad";
            this.QuantityColumn1.MinimumWidth = 8;
            this.QuantityColumn1.Name = "QuantityColumn1";
            this.QuantityColumn1.Width = 150;
            // 
            // DiscountColumn1
            // 
            this.DiscountColumn1.DataPropertyName = "Discount";
            this.DiscountColumn1.HeaderText = "Descuento";
            this.DiscountColumn1.MinimumWidth = 8;
            this.DiscountColumn1.Name = "DiscountColumn1";
            this.DiscountColumn1.Width = 150;
            // 
            // employeeIdComboBox
            // 
            this.employeeIdComboBox.FormattingEnabled = true;
            this.employeeIdComboBox.Location = new System.Drawing.Point(189, 66);
            this.employeeIdComboBox.Name = "employeeIdComboBox";
            this.employeeIdComboBox.Size = new System.Drawing.Size(137, 28);
            this.employeeIdComboBox.TabIndex = 1;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(189, 29);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(137, 28);
            this.customerIdComboBox.TabIndex = 0;
            this.customerIdComboBox.SelectedIndexChanged += new System.EventHandler(this.customerIdComboBox_SelectedIndexChanged);
            // 
            // shippedDateTimePicker3
            // 
            this.shippedDateTimePicker3.Location = new System.Drawing.Point(189, 189);
            this.shippedDateTimePicker3.Name = "shippedDateTimePicker3";
            this.shippedDateTimePicker3.Size = new System.Drawing.Size(137, 26);
            this.shippedDateTimePicker3.TabIndex = 4;
            // 
            // requiredDateTimePicker2
            // 
            this.requiredDateTimePicker2.Location = new System.Drawing.Point(189, 146);
            this.requiredDateTimePicker2.Name = "requiredDateTimePicker2";
            this.requiredDateTimePicker2.Size = new System.Drawing.Size(137, 26);
            this.requiredDateTimePicker2.TabIndex = 3;
            // 
            // orderDateTimePicker1
            // 
            this.orderDateTimePicker1.Location = new System.Drawing.Point(189, 104);
            this.orderDateTimePicker1.Name = "orderDateTimePicker1";
            this.orderDateTimePicker1.Size = new System.Drawing.Size(137, 26);
            this.orderDateTimePicker1.TabIndex = 2;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.Location = new System.Drawing.Point(185, 526);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipCountryTextBox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 526);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 94;
            this.label14.Text = "Pais del envio:";
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(185, 485);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipPostalCodeTextBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Codigo postal del envio:";
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.Location = new System.Drawing.Point(185, 443);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipRegionTextBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "Region de envio:";
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.Location = new System.Drawing.Point(185, 402);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipCityTextBox.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "Ciudad de envio:";
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.Location = new System.Drawing.Point(185, 360);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipAddressTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "Direccion de envio:";
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.Location = new System.Drawing.Point(185, 316);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipNameTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Nombre del barco:";
            // 
            // freightTextBox
            // 
            this.freightTextBox.Location = new System.Drawing.Point(185, 272);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(141, 26);
            this.freightTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Costo transporte:";
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.Location = new System.Drawing.Point(185, 229);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(141, 26);
            this.shipViaTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Embarcar via ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Fecha de envio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Fecha requerida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Fecha de la orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "EmpleadoId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "ClienteId:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(961, 482);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 70);
            this.button6.TabIndex = 21;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1106, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 70);
            this.button5.TabIndex = 22;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(645, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 70);
            this.button3.TabIndex = 19;
            this.button3.Text = "LEER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(500, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 70);
            this.button4.TabIndex = 18;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(790, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 70);
            this.button2.TabIndex = 20;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(355, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto ID:";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(1147, 28);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(98, 26);
            this.DiscountTextBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1051, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Descuento:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(923, 28);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(122, 26);
            this.QuantityTextBox.TabIndex = 15;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(840, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Cantidad:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(712, 28);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(122, 26);
            this.UnitPriceTextBox.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(593, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Precio unitario:";
            // 
            // ProductIdcomboBox
            // 
            this.ProductIdcomboBox.FormattingEnabled = true;
            this.ProductIdcomboBox.Location = new System.Drawing.Point(466, 28);
            this.ProductIdcomboBox.Name = "ProductIdcomboBox";
            this.ProductIdcomboBox.Size = new System.Drawing.Size(121, 28);
            this.ProductIdcomboBox.TabIndex = 13;
            // 
            // OrdenesPrincipales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 562);
            this.Controls.Add(this.ProductIdcomboBox);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeIdComboBox);
            this.Controls.Add(this.customerIdComboBox);
            this.Controls.Add(this.shippedDateTimePicker3);
            this.Controls.Add(this.requiredDateTimePicker2);
            this.Controls.Add(this.orderDateTimePicker1);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.shipPostalCodeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.shipRegionTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.shipCityTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shipNameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shipViaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrdenesPrincipales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIDColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIDColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipViaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreightColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipAddressColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipRegionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipPostalCodeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCountryColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn1;
        private System.Windows.Forms.ComboBox employeeIdComboBox;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.DateTimePicker shippedDateTimePicker3;
        private System.Windows.Forms.DateTimePicker requiredDateTimePicker2;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker1;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ProductIdcomboBox;
    }
}