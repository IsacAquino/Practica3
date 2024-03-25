namespace Practica3
{
    partial class Ordenes
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.requiredDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.shippedDateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.northwindDataSet = new Practica3.NorthwindDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Practica3.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.northwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipViaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreightColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipAddressColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCountryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipRegionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipPostalCodeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdColumn1,
            this.CustomerIdColumn1,
            this.EmployeeIdColumn1,
            this.OrderDateColumn1,
            this.RequiredDateColumn1,
            this.ShippedDateColumn1,
            this.ShipViaColumn1,
            this.FreightColumn1,
            this.ShipNameColumn1,
            this.ShipAddressColumn1,
            this.ShipCityColumn1,
            this.ShipCountryColumn1,
            this.ShipRegionColumn1,
            this.ShipPostalCodeColumn1});
            this.ordersDataGridView.Location = new System.Drawing.Point(376, 40);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 62;
            this.ordersDataGridView.RowTemplate.Height = 28;
            this.ordersDataGridView.Size = new System.Drawing.Size(890, 466);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.Visible = false;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellClick);
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(982, 517);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 70);
            this.button6.TabIndex = 39;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1127, 517);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 70);
            this.button5.TabIndex = 38;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(666, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 70);
            this.button3.TabIndex = 37;
            this.button3.Text = "LEER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(521, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 70);
            this.button4.TabIndex = 36;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(811, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 70);
            this.button2.TabIndex = 35;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(376, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 70);
            this.button1.TabIndex = 34;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "ClienteId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "EmpleadoId:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha de la orden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fecha requerida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fecha de envio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Embarcar via ID:";
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.Location = new System.Drawing.Point(198, 242);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipViaTextBox.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Costo transporte:";
            // 
            // freightTextBox
            // 
            this.freightTextBox.Location = new System.Drawing.Point(198, 278);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(122, 26);
            this.freightTextBox.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Nombre del barco:";
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.Location = new System.Drawing.Point(198, 317);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipNameTextBox.TabIndex = 57;
            this.shipNameTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Direccion de envio:";
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.Location = new System.Drawing.Point(198, 361);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipAddressTextBox.TabIndex = 59;
            this.shipAddressTextBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Ciudad de envio:";
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.Location = new System.Drawing.Point(198, 403);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipCityTextBox.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Region de envio:";
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.Location = new System.Drawing.Point(198, 444);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipRegionTextBox.TabIndex = 63;
            this.shipRegionTextBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "Codigo postal del envio:";
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(198, 486);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipPostalCodeTextBox.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Pais del envio:";
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.Location = new System.Drawing.Point(198, 527);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(122, 26);
            this.shipCountryTextBox.TabIndex = 67;
            // 
            // orderDateTimePicker1
            // 
            this.orderDateTimePicker1.Location = new System.Drawing.Point(198, 117);
            this.orderDateTimePicker1.Name = "orderDateTimePicker1";
            this.orderDateTimePicker1.Size = new System.Drawing.Size(126, 26);
            this.orderDateTimePicker1.TabIndex = 68;
            // 
            // requiredDateTimePicker2
            // 
            this.requiredDateTimePicker2.Location = new System.Drawing.Point(198, 159);
            this.requiredDateTimePicker2.Name = "requiredDateTimePicker2";
            this.requiredDateTimePicker2.Size = new System.Drawing.Size(126, 26);
            this.requiredDateTimePicker2.TabIndex = 69;
            // 
            // shippedDateTimePicker3
            // 
            this.shippedDateTimePicker3.Location = new System.Drawing.Point(198, 200);
            this.shippedDateTimePicker3.Name = "shippedDateTimePicker3";
            this.shippedDateTimePicker3.Size = new System.Drawing.Size(126, 26);
            this.shippedDateTimePicker3.TabIndex = 70;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(202, 42);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(122, 28);
            this.customerIdComboBox.TabIndex = 73;
            this.customerIdComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIdComboBox
            // 
            this.employeeIdComboBox.FormattingEnabled = true;
            this.employeeIdComboBox.Location = new System.Drawing.Point(202, 79);
            this.employeeIdComboBox.Name = "employeeIdComboBox";
            this.employeeIdComboBox.Size = new System.Drawing.Size(122, 28);
            this.employeeIdComboBox.TabIndex = 74;
            this.employeeIdComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.employeeIdComboBox_DrawItem);
            this.employeeIdComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeIdComboBox_SelectedIndexChanged);
            // 
            // northwindDataSetBindingSource
            // 
            this.northwindDataSetBindingSource.DataSource = this.northwindDataSet;
            this.northwindDataSetBindingSource.Position = 0;
            // 
            // OrderIdColumn1
            // 
            this.OrderIdColumn1.DataPropertyName = "OrderId";
            this.OrderIdColumn1.HeaderText = "ID orden";
            this.OrderIdColumn1.MinimumWidth = 8;
            this.OrderIdColumn1.Name = "OrderIdColumn1";
            this.OrderIdColumn1.Width = 150;
            // 
            // CustomerIdColumn1
            // 
            this.CustomerIdColumn1.DataPropertyName = "CustomerId";
            this.CustomerIdColumn1.HeaderText = "Id cliente";
            this.CustomerIdColumn1.MinimumWidth = 8;
            this.CustomerIdColumn1.Name = "CustomerIdColumn1";
            this.CustomerIdColumn1.Width = 150;
            // 
            // EmployeeIdColumn1
            // 
            this.EmployeeIdColumn1.DataPropertyName = "EmployeeId";
            this.EmployeeIdColumn1.HeaderText = "Id empleado";
            this.EmployeeIdColumn1.MinimumWidth = 8;
            this.EmployeeIdColumn1.Name = "EmployeeIdColumn1";
            this.EmployeeIdColumn1.Width = 150;
            // 
            // OrderDateColumn1
            // 
            this.OrderDateColumn1.DataPropertyName = "OrderDate";
            this.OrderDateColumn1.HeaderText = "Fecha Orden";
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
            this.ShippedDateColumn1.HeaderText = "Fecha de envio";
            this.ShippedDateColumn1.MinimumWidth = 8;
            this.ShippedDateColumn1.Name = "ShippedDateColumn1";
            this.ShippedDateColumn1.Width = 150;
            // 
            // ShipViaColumn1
            // 
            this.ShipViaColumn1.DataPropertyName = "ShipVia";
            this.ShipViaColumn1.HeaderText = "Embarcar via ID";
            this.ShipViaColumn1.MinimumWidth = 8;
            this.ShipViaColumn1.Name = "ShipViaColumn1";
            this.ShipViaColumn1.Width = 150;
            // 
            // FreightColumn1
            // 
            this.FreightColumn1.DataPropertyName = "Freight";
            this.FreightColumn1.HeaderText = "Costo Transporte";
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
            this.ShipCityColumn1.HeaderText = "Ciudad de envio";
            this.ShipCityColumn1.MinimumWidth = 8;
            this.ShipCityColumn1.Name = "ShipCityColumn1";
            this.ShipCityColumn1.Width = 150;
            // 
            // ShipCountryColumn1
            // 
            this.ShipCountryColumn1.DataPropertyName = "ShipCountry";
            this.ShipCountryColumn1.HeaderText = "Pais de envio";
            this.ShipCountryColumn1.MinimumWidth = 8;
            this.ShipCountryColumn1.Name = "ShipCountryColumn1";
            this.ShipCountryColumn1.Width = 150;
            // 
            // ShipRegionColumn1
            // 
            this.ShipRegionColumn1.DataPropertyName = "ShipRegion";
            this.ShipRegionColumn1.HeaderText = "Region de envio";
            this.ShipRegionColumn1.MinimumWidth = 8;
            this.ShipRegionColumn1.Name = "ShipRegionColumn1";
            this.ShipRegionColumn1.Width = 150;
            // 
            // ShipPostalCodeColumn1
            // 
            this.ShipPostalCodeColumn1.DataPropertyName = "ShipPostalCode";
            this.ShipPostalCodeColumn1.HeaderText = "Envio codigo postal";
            this.ShipPostalCodeColumn1.MinimumWidth = 8;
            this.ShipPostalCodeColumn1.Name = "ShipPostalCodeColumn1";
            this.ShipPostalCodeColumn1.Width = 150;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1315, 599);
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
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker1;
        private System.Windows.Forms.DateTimePicker requiredDateTimePicker2;
        private System.Windows.Forms.DateTimePicker shippedDateTimePicker3;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox employeeIdComboBox;
        private System.Windows.Forms.BindingSource northwindDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipViaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreightColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipAddressColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCountryColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipRegionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipPostalCodeColumn1;
    }
}