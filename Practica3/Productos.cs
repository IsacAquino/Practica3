﻿using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Practica3.Data;
using Practica3.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Productos : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Products> _productsValidator;
        
        public Productos(NorthwindContext northwindContext, IValidator<Products> productsValidator)
        {
            InitializeComponent();
            ProductsDataGridView.AutoGenerateColumns= false;
            this._northwindContext = northwindContext;
            this._productsValidator = productsValidator;
            //ProductsDataGridView.Visible = false;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            //this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            LoadProducts();
            //this.GetService(typeof(Productos));
        }

        private void LoadProducts()
        {
            ProductsDataGridView.DataSource = _northwindContext.Products.ToList();
            
            
        }

        //public Productos? Productos { internal set {

        //        productNameTextBox.Text = value.ProductName;
        //        supplierIDTextBox.Text = value.
        //        CategoryIdTextBox.Text = value.CategoryIdTextBox.Text;
        //    } }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var products = new Products();

            //    //products.ProductName = productNameTextBox.Text;

            //    var productName = productNameTextBox.Text;

            //    var existingProduct = _northwindContext.Products.FirstOrDefault(p => p.ProductName == productName);

            //    if (existingProduct != null)
            //    {
            //        MessageBox.Show("El producto ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return; // Salir del método sin insertar el producto nuevamente
            //    }

            //    // Si el producto no existe, proceder con la inserción
            //    var product = new Products
            //    {
            //        ProductName = productName,
            //        // Asignar el resto de las propiedades del producto aquí...
            //    };



            //    int supplierId;
            //    if (int.TryParse(supplierIDTextBox.Text, out supplierId))
            //    {

            //        products.SupplierId = supplierId;
            //    }
            //    products.QuantityPerUnit = quantityTextBox.Text;
            //    int categoryId;
            //    if (int.TryParse(CategoryIdTextBox.Text, out categoryId))
            //    {
            //        products.CategoryId = categoryId;
            //    }
            //    decimal unitPrice;
            //    if (decimal.TryParse(UnitPricesTextBox.Text, out unitPrice))
            //    {
            //        products.UnitPrice = unitPrice;
            //    }
            //    short unitsInStock;
            //    if (short.TryParse(StockTextBox.Text, out unitsInStock))
            //    {
            //        products.UnitsInStock = unitsInStock;
            //    }
            //    short unitsOnOrder;
            //    if (short.TryParse(OrdenTextBox.Text, out unitsOnOrder))
            //    {
            //        products.UnitsOnOrder = unitsOnOrder;
            //    }
            //    short reorderLevel;
            //    if (short.TryParse(levelTextbox.Text, out reorderLevel))
            //    {
            //        products.ReorderLevel = reorderLevel;
            //    }

            //    var validationResult = _productsValidator
            //        .Validate(products);

            //    if (validationResult.IsValid)
            //    {
            //        _northwindContext.Products.Add(products);
            //        _northwindContext.SaveChanges();
            //        MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadProducts();

            //    }
            //    else
            //    {
            //        try
            //        {
            //            throw new ApplicationException("Some Error");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Lo sentimos. Ocurrio un error inesperado. Intente mas tarde");
            //            Log.Error(ex, ex.Message);
            //        }
            //        var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
            //        MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }


            //    //ProductsDataGridView.Refresh();

            //    productNameTextBox.Clear();
            //    supplierIDTextBox.Clear();
            //    CategoryIdTextBox.Clear();
            //    quantityTextBox.Clear();
            //    UnitPricesTextBox.Clear();
            //    StockTextBox.Clear();
            //    OrdenTextBox.Clear();
            //    levelTextbox.Clear();


            //    //DialogResult = DialogResult.OK;
            //}
            //catch (DbUpdateException ex)
            //{
            //    // Capturar la excepción y mostrar más detalles
            //    MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                var productName = productNameTextBox.Text;

                var existingProduct = _northwindContext.Products.FirstOrDefault(p => p.ProductName == productName);

                if (existingProduct != null)
                {
                    MessageBox.Show("El producto ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin insertar el producto nuevamente
                }

                // Si el producto no existe, proceder con la inserción
                var product = new Products
                {
                    ProductName = productName,
                    // Asignar el resto de las propiedades del producto aquí...
                };

                // Asignar los valores ingresados en los campos de texto a la instancia de producto
                int supplierId;
                if (int.TryParse(supplierIDTextBox.Text, out supplierId))
                {
                    product.SupplierId = supplierId;
                }
                product.QuantityPerUnit = quantityTextBox.Text;
                int categoryId;
                if (int.TryParse(CategoryIdTextBox.Text, out categoryId))
                {
                    product.CategoryId = categoryId;
                }
                decimal unitPrice;
                if (decimal.TryParse(UnitPricesTextBox.Text, out unitPrice))
                {
                    product.UnitPrice = unitPrice;
                }
                short unitsInStock;
                if (short.TryParse(StockTextBox.Text, out unitsInStock))
                {
                    product.UnitsInStock = unitsInStock;
                }
                short unitsOnOrder;
                if (short.TryParse(OrdenTextBox.Text, out unitsOnOrder))
                {
                    product.UnitsOnOrder = unitsOnOrder;
                }
                short reorderLevel;
                if (short.TryParse(levelTextbox.Text, out reorderLevel))
                {
                    product.ReorderLevel = reorderLevel;
                }

                var validationResult = _productsValidator.Validate(product);

                if (validationResult.IsValid)
                {
                    _northwindContext.Products.Add(product);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                else
                {
                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    ProductsDataGridView.DataSource = context.Products.ToList();
                }

                ProductsDataGridView.Visible = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void DeleteProduct(int productId)
        {
            var productToDelete = _northwindContext.Products.Find(productId);
            if (productToDelete != null)
            {
                _northwindContext.Products.Remove(productToDelete);
                _northwindContext.SaveChanges();
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshForm()
        {
            // Limpiar todos los campos de entrada
            productNameTextBox.Clear();
            supplierIDTextBox.Clear();
            CategoryIdTextBox.Clear();
            quantityTextBox.Clear();
            UnitPricesTextBox.Clear();
            StockTextBox.Clear();
            OrdenTextBox.Clear();
            levelTextbox.Clear();

            // Recargar la lista de productos en el DataGridView
            LoadProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsDataGridView.SelectedRows.Count > 0)
                {
                    int productId = Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells["ProductIdColumn"].Value);
                    var productToDelete = _northwindContext.Products.Find(productId);
                    if (productToDelete != null)
                    {
                        // Verificar si el producto tiene referencias en otras tablas
                        bool hasReferences = _northwindContext.OrderDetails.Any(od => od.ProductId == productId);

                        if (!hasReferences)
                        {
                            _northwindContext.Products.Remove(productToDelete);
                            _northwindContext.SaveChanges();

                            // Refrescar todo el formulario
                            RefreshForm();

                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Este producto tiene referencias en otras tablas y no puede ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshForm(); // Refrescar todo el formulario incluso en caso de error
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            productNameTextBox.Clear();
            supplierIDTextBox.Clear();
            CategoryIdTextBox.Clear();
            quantityTextBox.Clear();
            UnitPricesTextBox.Clear();
            StockTextBox.Clear();
            OrdenTextBox.Clear();
            levelTextbox.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productNameTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["ProductNameColumn"].Value);
            supplierIDTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["SupplierIdColumn"].Value);
            CategoryIdTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["CategoryIdColumn"].Value);
            quantityTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["QuantityPerUnitColumn"].Value);
            UnitPricesTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitPriceColumn"].Value);
            StockTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitsInStockColumn"].Value);
            OrdenTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitsOnOrderColumn"].Value);
            levelTextbox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["ReorderLevelColumn"].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int productId = Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells["ProductIdColumn"].Value);

                    // Obtener el producto a modificar
                    var productToUpdate = _northwindContext.Products.Find(productId);
                    if (productToUpdate != null)
                    {
                        // Actualizar las propiedades del producto con los valores de los TextBox
                        productToUpdate.ProductName = productNameTextBox.Text;
                        productToUpdate.SupplierId = Convert.ToInt32(supplierIDTextBox.Text);
                        productToUpdate.CategoryId = Convert.ToInt32(CategoryIdTextBox.Text);
                        productToUpdate.QuantityPerUnit = quantityTextBox.Text;
                        productToUpdate.UnitPrice = Convert.ToDecimal(UnitPricesTextBox.Text);
                        productToUpdate.UnitsInStock = Convert.ToInt16(StockTextBox.Text);
                        productToUpdate.UnitsOnOrder = Convert.ToInt16(OrdenTextBox.Text);
                        productToUpdate.ReorderLevel = Convert.ToInt16(levelTextbox.Text);

                        // Guardar los cambios en la base de datos
                        _northwindContext.SaveChanges();
                        LoadProducts();
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshForm(); // Refrescar todo el formulario incluso en caso de error
            }
        }
    }
}
