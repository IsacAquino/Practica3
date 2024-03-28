namespace Practica3
{
    partial class Productos
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Practica3.NorthwindDataSet();
            this.productsTableAdapter = new Practica3.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitPricesTextBox = new System.Windows.Forms.TextBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.OrdenTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.levelTextbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPerUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsInStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsOnOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(369, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdColumn,
            this.ProductNameColumn,
            this.SupplierIdColumn,
            this.CategoryIdColumn,
            this.QuantityPerUnitColumn,
            this.UnitPriceColumn,
            this.UnitsInStockColumn,
            this.UnitsOnOrderColumn,
            this.ReorderLevelColumn});
            this.ProductsDataGridView.Location = new System.Drawing.Point(369, 56);
            this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersWidth = 62;
            this.ProductsDataGridView.Size = new System.Drawing.Size(831, 333);
            this.ProductsDataGridView.TabIndex = 1;
            this.ProductsDataGridView.Visible = false;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(504, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 76);
            this.button2.TabIndex = 2;
            this.button2.Text = "LEER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(199, 58);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(137, 26);
            this.productNameTextBox.TabIndex = 5;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Suplidor:";
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.Location = new System.Drawing.Point(199, 110);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(137, 26);
            this.supplierIDTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Categoria:";
            // 
            // CategoryIdTextBox
            // 
            this.CategoryIdTextBox.Location = new System.Drawing.Point(199, 166);
            this.CategoryIdTextBox.Name = "CategoryIdTextBox";
            this.CategoryIdTextBox.Size = new System.Drawing.Size(137, 26);
            this.CategoryIdTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad por unidad:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(199, 222);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(137, 26);
            this.quantityTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio Unitario:";
            // 
            // UnitPricesTextBox
            // 
            this.UnitPricesTextBox.Location = new System.Drawing.Point(199, 274);
            this.UnitPricesTextBox.Name = "UnitPricesTextBox";
            this.UnitPricesTextBox.Size = new System.Drawing.Size(137, 26);
            this.UnitPricesTextBox.TabIndex = 14;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(199, 324);
            this.StockTextBox.Multiline = true;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(137, 26);
            this.StockTextBox.TabIndex = 15;
            // 
            // OrdenTextBox
            // 
            this.OrdenTextBox.Location = new System.Drawing.Point(199, 376);
            this.OrdenTextBox.Name = "OrdenTextBox";
            this.OrdenTextBox.Size = new System.Drawing.Size(137, 26);
            this.OrdenTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Unidades en stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unidades en orden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Reordenar nivel:";
            // 
            // levelTextbox
            // 
            this.levelTextbox.Location = new System.Drawing.Point(199, 433);
            this.levelTextbox.Name = "levelTextbox";
            this.levelTextbox.Size = new System.Drawing.Size(137, 26);
            this.levelTextbox.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(938, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 76);
            this.button3.TabIndex = 21;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(638, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 76);
            this.button4.TabIndex = 22;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(804, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 76);
            this.button5.TabIndex = 23;
            this.button5.Text = "LIMPIAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(1072, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 76);
            this.button6.TabIndex = 24;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.DataPropertyName = "ProductId";
            this.ProductIdColumn.HeaderText = "ProductId";
            this.ProductIdColumn.MinimumWidth = 8;
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.Visible = false;
            this.ProductIdColumn.Width = 150;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.MinimumWidth = 8;
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.Width = 150;
            // 
            // SupplierIdColumn
            // 
            this.SupplierIdColumn.DataPropertyName = "SupplierId";
            this.SupplierIdColumn.HeaderText = "SupplierId";
            this.SupplierIdColumn.MinimumWidth = 8;
            this.SupplierIdColumn.Name = "SupplierIdColumn";
            this.SupplierIdColumn.Width = 150;
            // 
            // CategoryIdColumn
            // 
            this.CategoryIdColumn.DataPropertyName = "CategoryId";
            this.CategoryIdColumn.HeaderText = "CategoryId";
            this.CategoryIdColumn.MinimumWidth = 8;
            this.CategoryIdColumn.Name = "CategoryIdColumn";
            this.CategoryIdColumn.Width = 150;
            // 
            // QuantityPerUnitColumn
            // 
            this.QuantityPerUnitColumn.DataPropertyName = "QuantityPerUnit";
            this.QuantityPerUnitColumn.HeaderText = "QuantityPerUnit";
            this.QuantityPerUnitColumn.MinimumWidth = 8;
            this.QuantityPerUnitColumn.Name = "QuantityPerUnitColumn";
            this.QuantityPerUnitColumn.Width = 150;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "UnitPrice";
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.MinimumWidth = 8;
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.Width = 150;
            // 
            // UnitsInStockColumn
            // 
            this.UnitsInStockColumn.DataPropertyName = "UnitsInStock";
            this.UnitsInStockColumn.HeaderText = "Units In Stock";
            this.UnitsInStockColumn.MinimumWidth = 8;
            this.UnitsInStockColumn.Name = "UnitsInStockColumn";
            this.UnitsInStockColumn.Width = 150;
            // 
            // UnitsOnOrderColumn
            // 
            this.UnitsOnOrderColumn.DataPropertyName = "UnitsOnOrder";
            this.UnitsOnOrderColumn.HeaderText = "Units On Order";
            this.UnitsOnOrderColumn.MinimumWidth = 8;
            this.UnitsOnOrderColumn.Name = "UnitsOnOrderColumn";
            this.UnitsOnOrderColumn.Width = 150;
            // 
            // ReorderLevelColumn
            // 
            this.ReorderLevelColumn.DataPropertyName = "ReorderLevel";
            this.ReorderLevelColumn.HeaderText = "Reorder Level";
            this.ReorderLevelColumn.MinimumWidth = 8;
            this.ReorderLevelColumn.Name = "ReorderLevelColumn";
            this.ReorderLevelColumn.Width = 150;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 482);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.levelTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrdenTextBox);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.UnitPricesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoryIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CategoryIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.TextBox OrdenTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox levelTextbox;
        private System.Windows.Forms.TextBox UnitPricesTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPerUnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsInStockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsOnOrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevelColumn;
    }
}