﻿namespace Practica3
{
    partial class Categorias
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
            this.CategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryIdColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesDataGridView
            // 
            this.CategoriesDataGridView.AllowUserToDeleteRows = false;
            this.CategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryIdColumn1,
            this.CategoryNameColumn1,
            this.DescriptionColumn1});
            this.CategoriesDataGridView.Location = new System.Drawing.Point(353, 32);
            this.CategoriesDataGridView.MultiSelect = false;
            this.CategoriesDataGridView.Name = "CategoriesDataGridView";
            this.CategoriesDataGridView.ReadOnly = true;
            this.CategoriesDataGridView.RowHeadersVisible = false;
            this.CategoriesDataGridView.RowHeadersWidth = 62;
            this.CategoriesDataGridView.RowTemplate.Height = 28;
            this.CategoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesDataGridView.Size = new System.Drawing.Size(858, 330);
            this.CategoriesDataGridView.TabIndex = 8;
            this.CategoriesDataGridView.Visible = false;
            // 
            // CategoryIdColumn1
            // 
            this.CategoryIdColumn1.DataPropertyName = "CategoryID";
            this.CategoryIdColumn1.HeaderText = "ID categoria";
            this.CategoryIdColumn1.MinimumWidth = 8;
            this.CategoryIdColumn1.Name = "CategoryIdColumn1";
            this.CategoryIdColumn1.ReadOnly = true;
            this.CategoryIdColumn1.Visible = false;
            this.CategoryIdColumn1.Width = 150;
            // 
            // CategoryNameColumn1
            // 
            this.CategoryNameColumn1.DataPropertyName = "CategoryName";
            this.CategoryNameColumn1.HeaderText = "CategoryName";
            this.CategoryNameColumn1.MinimumWidth = 8;
            this.CategoryNameColumn1.Name = "CategoryNameColumn1";
            this.CategoryNameColumn1.ReadOnly = true;
            this.CategoryNameColumn1.Width = 150;
            // 
            // DescriptionColumn1
            // 
            this.DescriptionColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn1.DataPropertyName = "Description";
            this.DescriptionColumn1.HeaderText = "Description";
            this.DescriptionColumn1.MinimumWidth = 8;
            this.DescriptionColumn1.Name = "DescriptionColumn1";
            this.DescriptionColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de categoria:";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(228, 160);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.categoryNameTextBox.TabIndex = 0;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(228, 206);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(329, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(764, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Picture:";
            this.label4.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(619, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "LEER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(474, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(927, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1072, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 70);
            this.button5.TabIndex = 7;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.Location = new System.Drawing.Point(108, 448);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(193, 149);
            this.picturePictureBox.TabIndex = 9;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.Visible = false;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 476);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriesDataGridView);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIdColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn1;
    }
}