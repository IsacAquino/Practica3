using FluentValidation;
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
using System.IO;
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
            LoadProducts();
            var suplidores = _northwindContext.Suppliers.ToList();

            
            suppliersIdcomboBox1.DataSource = suplidores;
            suppliersIdcomboBox1.DisplayMember = "ContactName"; 
            suppliersIdcomboBox1.ValueMember = "SupplierId"; 
            suppliersIdcomboBox1.SelectedIndex = -1;

            var categorias = _northwindContext.Categories.ToList();

            
            categoriescomboBox1.DataSource = categorias;
            categoriescomboBox1.DisplayMember = "CategoryName"; 
            categoriescomboBox1.ValueMember = "CategoryId"; 
            categoriescomboBox1.SelectedIndex = -1;



            
            
        }

        private void LoadProducts()
        {
            ProductsDataGridView.DataSource = _northwindContext.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                    
                };

                if (suppliersIdcomboBox1.SelectedItem != null)
                {
                    product.SupplierId = Convert.ToInt32(suppliersIdcomboBox1.SelectedValue);
                }

                // Asignar los valores ingresados en los campos de texto a la instancia de producto
                
                product.QuantityPerUnit = quantityTextBox.Text;

                if (categoriescomboBox1.SelectedItem != null)
                {
                    product.CategoryId = Convert.ToInt32(categoriescomboBox1.SelectedValue);
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
                    productNameTextBox.Clear();
                    suppliersIdcomboBox1.SelectedIndex = -1;
                    categoriescomboBox1.SelectedIndex = -1;
                    quantityTextBox.Clear();
                    UnitPricesTextBox.Clear();
                    StockTextBox.Clear();
                    OrdenTextBox.Clear();
                    levelTextbox.Clear();

                    Log.Information("Producto insertado: ID: {ProductId}, Nombre: {ProductName}", product.ProductId, product.ProductName);
                }
                else
                {

                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (DbUpdateException ex)
            {
                Log.Error(ex, "Error al insertar producto.");
                MessageBox.Show("Error al insertar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Mostrar mensaje de error al usuario
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Mostrar mensaje adicional para informar al usuario sobre el registro del error
                MessageBox.Show("Se ha producido un error. Por favor, contacte al administrador del sistema para obtener ayuda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
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
            suppliersIdcomboBox1.SelectedIndex = -1;
            categoriescomboBox1.SelectedIndex = -1;
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
                            Log.Information("Producto eliminado: ID {ProductId}", productId);
                        }
                        else
                        {
                            MessageBox.Show("Este producto tiene referencias en otras tablas y no puede ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log.Information("Este producto, tiene referencia en otras tablas: ID {ProductId}", productId);
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
                Log.Error(ex, "Error al eliminar el producto.");
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            productNameTextBox.Clear();
            suppliersIdcomboBox1.SelectedIndex = -1;
            categoriescomboBox1.SelectedIndex = -1;
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
            suppliersIdcomboBox1.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["SupplierIdColumn"].Value);
            categoriescomboBox1.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["CategoryIdColumn"].Value);
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
                    int productId = Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells["ProductIdColumn"].Value);

                    var productToUpdate = _northwindContext.Products.Find(productId);

                    if (productToUpdate != null)
                    {
                        productToUpdate.ProductName = productNameTextBox.Text;
                        productToUpdate.QuantityPerUnit = quantityTextBox.Text;

                        if (suppliersIdcomboBox1.SelectedItem != null)
                        {
                            productToUpdate.SupplierId = Convert.ToInt32(suppliersIdcomboBox1.SelectedValue);
                        }

                        if (categoriescomboBox1.SelectedItem != null)
                        {
                            productToUpdate.CategoryId = Convert.ToInt32(categoriescomboBox1.SelectedValue);
                        }

                        decimal unitPrice;
                        if (decimal.TryParse(UnitPricesTextBox.Text, out unitPrice))
                        {
                            productToUpdate.UnitPrice = unitPrice;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        short unitsInStock;
                        if (short.TryParse(StockTextBox.Text, out unitsInStock))
                        {
                            productToUpdate.UnitsInStock = unitsInStock;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para las unidades en stock.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        short unitsOnOrder;
                        if (short.TryParse(OrdenTextBox.Text, out unitsOnOrder))
                        {
                            productToUpdate.UnitsOnOrder = unitsOnOrder;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para las unidades en orden.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        short reorderLevel;
                        if (short.TryParse(levelTextbox.Text, out reorderLevel))
                        {
                            productToUpdate.ReorderLevel = reorderLevel;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para el nivel de reorden.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validar el producto actualizado
                        var validationResult = _productsValidator.Validate(productToUpdate);

                        if (validationResult.IsValid)
                        {
                            // Guardar los cambios en la base de datos
                            _northwindContext.SaveChanges();
                            LoadProducts();
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Registrar el evento de actualización en el log
                            Log.Information("Producto actualizado: ID {ProductId}", productId);
                        }
                        else
                        {
                            // Si la validación falla, mostrar los mensajes de error de FluentValidation
                            var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                            MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                // Si ocurre un error durante la actualización, registrar el error
                Log.Error("Error al actualizar el producto: {ErrorMessage}", ex.InnerException?.Message);
                MessageBox.Show("Error al actualizar el producto. Consulte el registro para más detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar cualquier otra excepción y mostrar un mensaje genérico
                MessageBox.Show("Se ha producido un error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void suppliersIdcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
