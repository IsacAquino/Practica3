using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Practica3.Data;
using Practica3.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class OrdenesDetalles : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<OrderDetails> _orderDetailsValidator;
        public OrdenesDetalles(NorthwindContext northwindContext, IValidator<OrderDetails> orderDetailsValidator)
        {
            InitializeComponent();
            orderDetailsDataGridView.AutoGenerateColumns = false;
            this._northwindContext = northwindContext;
            this._orderDetailsValidator = orderDetailsValidator;
        }




        private void OrdenesDetalles_Load(object sender, EventArgs e)
        {
            OrderIdComboBox.DisplayMember = "OrderId"; // Nombre de la propiedad que quieres mostrar
            OrderIdComboBox.ValueMember = "OrderId"; // Nombre de la propiedad que es el valor real
            OrderIdComboBox.DataSource = _northwindContext.Orders.ToList();

            // Configurar el ComboBox de ProductID
            ProductIdComboBox.DisplayMember = "ProductId"; // Nombre de la propiedad que quieres mostrar
            ProductIdComboBox.ValueMember = "ProductId"; // Nombre de la propiedad que es el valor real
            ProductIdComboBox.DataSource = _northwindContext.Products.ToList();
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {

            orderDetailsDataGridView.DataSource = _northwindContext.OrderDetails.ToList();
            
            //employeeIdComboBox.DisplayMember = "FullName";
            //employeeIdComboBox.ValueMember = "EmployeeId";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var orderDetails = new OrderDetails();
                int orderId;
                if (int.TryParse(OrderIdComboBox.Text, out orderId))
                {

                    orderDetails.OrderId = orderId;
                }
                int productId;
                if (int.TryParse(ProductIdComboBox.Text, out productId))
                {

                    orderDetails.ProductId = productId;
                }
                decimal unitPrice;
                if (decimal.TryParse(unitPriceTextBox.Text, out unitPrice))
                {

                    orderDetails.UnitPrice = unitPrice;
                }
                Int16 quantity;
                if (Int16.TryParse(quantityTextBox.Text, out quantity))
                {

                    orderDetails.Quantity = quantity;
                }
                Single discount;
                if (Single.TryParse(discountTextBox.Text, out discount))
                {

                    orderDetails.Discount = discount;
                }

                var validationResult = _orderDetailsValidator
                    .Validate(orderDetails);

                if (validationResult.IsValid)
                {
                    _northwindContext.OrderDetails.Add(orderDetails);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Orden detalle insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrderDetails();

                }
                else
                {
                    try
                    {
                        throw new ApplicationException("Some Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos. Ocurrio un error inesperado. Intente mas tarde");
                        Log.Error(ex, ex.Message);
                    }
                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                unitPriceTextBox.Clear();
                quantityTextBox.Clear();
                discountTextBox.Clear();

            }
            catch (DbUpdateException ex)
            {
                // Capturar la excepción y mostrar más detalles
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void orderDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderIdComboBox.Text = Convert.ToString(orderDetailsDataGridView.CurrentRow.Cells["OrderIdColumn1"].Value);
            ProductIdComboBox.Text = Convert.ToString(orderDetailsDataGridView.CurrentRow.Cells["ProductIdColumn1"].Value);
            unitPriceTextBox.Text = Convert.ToString(orderDetailsDataGridView.CurrentRow.Cells["UnitPriceColumn1"].Value);
            quantityTextBox.Text = Convert.ToString(orderDetailsDataGridView.CurrentRow.Cells["QuantityColumn1"].Value);
            discountTextBox.Text = Convert.ToString(orderDetailsDataGridView.CurrentRow.Cells["DiscountColumn1"].Value);
        }

        private void ProductIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductIdComboBox.SelectedItem != null)
            {
                int selectedProductId;
                if (int.TryParse(ProductIdComboBox.SelectedItem.ToString(), out selectedProductId))
                {
                    
                }
            }
        }

        private void ProductIdComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var comboBox = sender as ComboBox;
            if (comboBox == null)
                return;

            var empleado = comboBox.Items[e.Index] as OrderDetails;
            if (empleado == null)
                return;

            // Dibujar el nombre y apellido cuando el elemento está seleccionado
            e.DrawBackground();
            //var text = $"{empleado.FirstName} {empleado.LastName}";
            using (var brush = new SolidBrush(e.ForeColor))
            {
                //e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (orderDetailsDataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria de la fila seleccionada
                int orderId = Convert.ToInt32(orderDetailsDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);

                // Obtener el producto a modificar
                var productToUpdate = _northwindContext.Products.Find(orderId);
                if (productToUpdate != null)
                {
                    // Actualizar las propiedades del producto con los valores de los TextBox
                    var orderDetails = new OrderDetails();
                    int productId;
                    if (int.TryParse(ProductIdComboBox.Text, out productId))
                    {
                        // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                        orderDetails.ProductId = productId;
                    }
                    decimal unitPrice;
                    if (decimal.TryParse(unitPriceTextBox.Text, out unitPrice))
                    {
                        // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                        orderDetails.UnitPrice = unitPrice;
                    }
                    Int16 quantity;
                    if (Int16.TryParse(quantityTextBox.Text, out quantity))
                    {
                        // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                        orderDetails.Quantity = quantity;
                    }
                    Single discount;
                    if (Single.TryParse(discountTextBox.Text, out discount))
                    {
                        // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                        orderDetails.Discount = discount;
                    }


                    // Guardar los cambios en la base de datos
                    _northwindContext.SaveChanges();
                    LoadOrderDetails();
                    MessageBox.Show("Orden detalle actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Orden detalle no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden detalle para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
