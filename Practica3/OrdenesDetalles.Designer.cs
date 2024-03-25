namespace Practica3
{
    partial class OrdenesDetalles
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
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIdComboBox = new System.Windows.Forms.ComboBox();
            this.ProductIdComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdColumn1,
            this.ProductIdColumn1,
            this.UnitPriceColumn1,
            this.QuantityColumn1,
            this.DiscountColumn1});
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(309, 41);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.RowHeadersWidth = 62;
            this.orderDetailsDataGridView.RowTemplate.Height = 28;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(896, 299);
            this.orderDetailsDataGridView.TabIndex = 0;
            this.orderDetailsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDetailsDataGridView_CellClick);
            // 
            // OrderIdColumn1
            // 
            this.OrderIdColumn1.DataPropertyName = "OrderId";
            this.OrderIdColumn1.HeaderText = "OrderId";
            this.OrderIdColumn1.MinimumWidth = 8;
            this.OrderIdColumn1.Name = "OrderIdColumn1";
            this.OrderIdColumn1.Width = 150;
            // 
            // ProductIdColumn1
            // 
            this.ProductIdColumn1.DataPropertyName = "ProductId";
            this.ProductIdColumn1.HeaderText = "ProductId";
            this.ProductIdColumn1.MinimumWidth = 8;
            this.ProductIdColumn1.Name = "ProductIdColumn1";
            this.ProductIdColumn1.Width = 150;
            // 
            // UnitPriceColumn1
            // 
            this.UnitPriceColumn1.DataPropertyName = "UnitPrice";
            this.UnitPriceColumn1.HeaderText = "UnitPrice";
            this.UnitPriceColumn1.MinimumWidth = 8;
            this.UnitPriceColumn1.Name = "UnitPriceColumn1";
            this.UnitPriceColumn1.Width = 150;
            // 
            // QuantityColumn1
            // 
            this.QuantityColumn1.DataPropertyName = "Quantity";
            this.QuantityColumn1.HeaderText = "Quantity";
            this.QuantityColumn1.MinimumWidth = 8;
            this.QuantityColumn1.Name = "QuantityColumn1";
            this.QuantityColumn1.Width = 150;
            // 
            // DiscountColumn1
            // 
            this.DiscountColumn1.DataPropertyName = "Discount";
            this.DiscountColumn1.HeaderText = "Discount";
            this.DiscountColumn1.MinimumWidth = 8;
            this.DiscountColumn1.Name = "DiscountColumn1";
            this.DiscountColumn1.Width = 150;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(919, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 70);
            this.button6.TabIndex = 39;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1065, 368);
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
            this.button3.Location = new System.Drawing.Point(599, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 70);
            this.button3.TabIndex = 37;
            this.button3.Text = "LEER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(454, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 70);
            this.button4.TabIndex = 36;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(744, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 70);
            this.button2.TabIndex = 35;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(309, 368);
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
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Descuento:";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(144, 242);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(151, 26);
            this.discountTextBox.TabIndex = 46;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(146, 189);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(150, 26);
            this.quantityTextBox.TabIndex = 47;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(146, 137);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(149, 26);
            this.unitPriceTextBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID orden:";
            // 
            // OrderIdComboBox
            // 
            this.OrderIdComboBox.FormattingEnabled = true;
            this.OrderIdComboBox.Location = new System.Drawing.Point(146, 41);
            this.OrderIdComboBox.Name = "OrderIdComboBox";
            this.OrderIdComboBox.Size = new System.Drawing.Size(150, 28);
            this.OrderIdComboBox.TabIndex = 52;
            // 
            // ProductIdComboBox
            // 
            this.ProductIdComboBox.FormattingEnabled = true;
            this.ProductIdComboBox.Location = new System.Drawing.Point(147, 88);
            this.ProductIdComboBox.Name = "ProductIdComboBox";
            this.ProductIdComboBox.Size = new System.Drawing.Size(149, 28);
            this.ProductIdComboBox.TabIndex = 53;
            this.ProductIdComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ProductIdComboBox_DrawItem);
            this.ProductIdComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductIdComboBox_SelectedIndexChanged);
            // 
            // OrdenesDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1238, 460);
            this.Controls.Add(this.ProductIdComboBox);
            this.Controls.Add(this.OrderIdComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.discountTextBox);
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
            this.Controls.Add(this.orderDetailsDataGridView);
            this.Name = "OrdenesDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenesDetalles";
            this.Load += new System.EventHandler(this.OrdenesDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn1;
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
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrderIdComboBox;
        private System.Windows.Forms.ComboBox ProductIdComboBox;
    }
}