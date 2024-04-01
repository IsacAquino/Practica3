namespace Practica3
{
    partial class Suplidores
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
            this.SuppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.SuppliersIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitleColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCodeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePageColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.homePageTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SuppliersDataGridView
            // 
            this.SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuppliersIdColumn1,
            this.CompanyNameColumn1,
            this.ContactNameColumn1,
            this.ContactTitleColumn1,
            this.AddressColumn1,
            this.CityColumn1,
            this.RegionColumn1,
            this.PostalCodeColumn1,
            this.CountryColumn1,
            this.PhoneColumn1,
            this.FaxColumn1,
            this.HomePageColumn1});
            this.SuppliersDataGridView.Location = new System.Drawing.Point(404, 45);
            this.SuppliersDataGridView.Name = "SuppliersDataGridView";
            this.SuppliersDataGridView.RowHeadersWidth = 62;
            this.SuppliersDataGridView.RowTemplate.Height = 28;
            this.SuppliersDataGridView.Size = new System.Drawing.Size(882, 408);
            this.SuppliersDataGridView.TabIndex = 17;
            this.SuppliersDataGridView.Visible = false;
            this.SuppliersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersDataGridView_CellClick);
            // 
            // SuppliersIdColumn1
            // 
            this.SuppliersIdColumn1.DataPropertyName = "SupplierId";
            this.SuppliersIdColumn1.HeaderText = "Id Suplidores";
            this.SuppliersIdColumn1.MinimumWidth = 8;
            this.SuppliersIdColumn1.Name = "SuppliersIdColumn1";
            this.SuppliersIdColumn1.Visible = false;
            this.SuppliersIdColumn1.Width = 150;
            // 
            // CompanyNameColumn1
            // 
            this.CompanyNameColumn1.DataPropertyName = "CompanyName";
            this.CompanyNameColumn1.HeaderText = "Nombre compañía";
            this.CompanyNameColumn1.MinimumWidth = 8;
            this.CompanyNameColumn1.Name = "CompanyNameColumn1";
            this.CompanyNameColumn1.Width = 150;
            // 
            // ContactNameColumn1
            // 
            this.ContactNameColumn1.DataPropertyName = "ContactName";
            this.ContactNameColumn1.HeaderText = "Nombre contacto";
            this.ContactNameColumn1.MinimumWidth = 8;
            this.ContactNameColumn1.Name = "ContactNameColumn1";
            this.ContactNameColumn1.Width = 150;
            // 
            // ContactTitleColumn1
            // 
            this.ContactTitleColumn1.DataPropertyName = "ContactTitle";
            this.ContactTitleColumn1.HeaderText = "Titulo de contacto";
            this.ContactTitleColumn1.MinimumWidth = 8;
            this.ContactTitleColumn1.Name = "ContactTitleColumn1";
            this.ContactTitleColumn1.Width = 150;
            // 
            // AddressColumn1
            // 
            this.AddressColumn1.DataPropertyName = "Address";
            this.AddressColumn1.HeaderText = "Direccion";
            this.AddressColumn1.MinimumWidth = 8;
            this.AddressColumn1.Name = "AddressColumn1";
            this.AddressColumn1.Width = 150;
            // 
            // CityColumn1
            // 
            this.CityColumn1.DataPropertyName = "City";
            this.CityColumn1.HeaderText = "Ciudad";
            this.CityColumn1.MinimumWidth = 8;
            this.CityColumn1.Name = "CityColumn1";
            this.CityColumn1.Width = 150;
            // 
            // RegionColumn1
            // 
            this.RegionColumn1.DataPropertyName = "Region";
            this.RegionColumn1.HeaderText = "Región";
            this.RegionColumn1.MinimumWidth = 8;
            this.RegionColumn1.Name = "RegionColumn1";
            this.RegionColumn1.Width = 150;
            // 
            // PostalCodeColumn1
            // 
            this.PostalCodeColumn1.DataPropertyName = "PostalCode";
            this.PostalCodeColumn1.HeaderText = "Codigo postal";
            this.PostalCodeColumn1.MinimumWidth = 8;
            this.PostalCodeColumn1.Name = "PostalCodeColumn1";
            this.PostalCodeColumn1.Width = 150;
            // 
            // CountryColumn1
            // 
            this.CountryColumn1.DataPropertyName = "Country";
            this.CountryColumn1.HeaderText = "Pais";
            this.CountryColumn1.MinimumWidth = 8;
            this.CountryColumn1.Name = "CountryColumn1";
            this.CountryColumn1.Width = 150;
            // 
            // PhoneColumn1
            // 
            this.PhoneColumn1.DataPropertyName = "Phone";
            this.PhoneColumn1.HeaderText = "Celular";
            this.PhoneColumn1.MinimumWidth = 8;
            this.PhoneColumn1.Name = "PhoneColumn1";
            this.PhoneColumn1.Width = 150;
            // 
            // FaxColumn1
            // 
            this.FaxColumn1.DataPropertyName = "Fax";
            this.FaxColumn1.HeaderText = "Fax";
            this.FaxColumn1.MinimumWidth = 8;
            this.FaxColumn1.Name = "FaxColumn1";
            this.FaxColumn1.Width = 150;
            // 
            // HomePageColumn1
            // 
            this.HomePageColumn1.DataPropertyName = "HomePage";
            this.HomePageColumn1.HeaderText = "Pagina principal";
            this.HomePageColumn1.MinimumWidth = 8;
            this.HomePageColumn1.Name = "HomePageColumn1";
            this.HomePageColumn1.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(256, 45);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(118, 26);
            this.companyNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de la compania:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de contacto:";
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.Location = new System.Drawing.Point(256, 90);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(118, 26);
            this.contactNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titulo de contacto:";
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.Location = new System.Drawing.Point(256, 136);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(118, 26);
            this.contactTitleTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Direccion:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(256, 184);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(118, 26);
            this.AddressTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ciudad:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(256, 232);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(118, 26);
            this.cityTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo Postal:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(256, 279);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(118, 26);
            this.postalCodeTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pais:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Celular:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(256, 324);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(118, 26);
            this.countryTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(256, 371);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(118, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pagina Principal";
            // 
            // homePageTextBox
            // 
            this.homePageTextBox.Location = new System.Drawing.Point(256, 416);
            this.homePageTextBox.Name = "homePageTextBox";
            this.homePageTextBox.Size = new System.Drawing.Size(118, 26);
            this.homePageTextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fax";
            // 
            // faxTextBox
            // 
            this.faxTextBox.Location = new System.Drawing.Point(256, 461);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(118, 26);
            this.faxTextBox.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Region:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.Location = new System.Drawing.Point(256, 507);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(118, 26);
            this.regionTextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 70);
            this.button2.TabIndex = 12;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(694, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 70);
            this.button3.TabIndex = 13;
            this.button3.Text = "LEER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(839, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 70);
            this.button4.TabIndex = 14;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1145, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 70);
            this.button5.TabIndex = 16;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(998, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 70);
            this.button6.TabIndex = 15;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.homePageTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuppliersDataGridView);
            this.Name = "Suplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplidores";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SuppliersDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox homePageTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppliersIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitleColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCodeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePageColumn1;
    }
}