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
    public partial class Suplidores : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Suppliers> _suppliersValidator;
        public Suplidores(NorthwindContext northwindContext, IValidator<Suppliers> suppliersValidator)
        {
            InitializeComponent();
            this._northwindContext = northwindContext;
            this._suppliersValidator = suppliersValidator;
            SuppliersDataGridView.AutoGenerateColumns = false;
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            SuppliersDataGridView.DataSource = _northwindContext.Suppliers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var suppliers = new Suppliers();
                suppliers.CompanyName = companyNameTextBox.Text;
                suppliers.ContactName = contactNameTextBox.Text;
                suppliers.ContactTitle= contactTitleTextBox.Text;
                suppliers.Address = AddressTextBox.Text;
                suppliers.City = cityTextBox.Text;
                suppliers.Region = regionTextBox.Text;
                suppliers.PostalCode = postalCodeTextBox.Text;
                suppliers.Country = countryTextBox.Text;
                suppliers.Phone = phoneTextBox.Text;
                suppliers.Fax = faxTextBox.Text;
                suppliers.HomePage = homePageTextBox.Text;

                var validationResult = _suppliersValidator
                    .Validate(suppliers);

                if (validationResult.IsValid)
                {
                    _northwindContext.Suppliers.Add(suppliers);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Suplidor insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();

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

                companyNameTextBox.Clear();
                contactTitleTextBox.Clear();
                AddressTextBox.Clear();
                cityTextBox.Clear();
                regionTextBox.Clear();
                postalCodeTextBox.Clear();
                countryTextBox.Clear();
                phoneTextBox.Clear();
                faxTextBox.Clear();
                homePageTextBox.Clear();


            }   



            

            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message, "Error saving products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            companyNameTextBox.Clear();
            contactTitleTextBox.Clear();
            contactNameTextBox.Clear();
            AddressTextBox.Clear();
            cityTextBox.Clear();
            regionTextBox.Clear();
            postalCodeTextBox.Clear();
            countryTextBox.Clear();
            phoneTextBox.Clear();
            faxTextBox.Clear();
            homePageTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    SuppliersDataGridView.DataSource = context.Suppliers.ToList();
                }

                SuppliersDataGridView.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SuppliersDataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria de la fila seleccionada
                int supplierId = Convert.ToInt32(SuppliersDataGridView.SelectedRows[0].Cells["SuppliersIdColumn1"].Value);

                // Obtener el producto a modificar
                var supplierToUpdate = _northwindContext.Suppliers.Find(supplierId);
                if (supplierToUpdate != null)
                {
                    // Actualizar las propiedades del producto con los valores de los TextBox
                    //supplierToUpdate.ProductName = productNameTextBox.Text;
                    //supplierToUpdate.SupplierId = Convert.ToInt32(supplierIDTextBox.Text);
                    //supplierToUpdate.CategoryId = Convert.ToInt32(CategoryIdTextBox.Text);
                    //supplierToUpdate.QuantityPerUnit = quantityTextBox.Text;
                    //supplierToUpdate.UnitPrice = Convert.ToDecimal(UnitPricesTextBox.Text);
                    //supplierToUpdate.UnitsInStock = Convert.ToInt16(StockTextBox.Text);
                    //supplierToUpdate.UnitsOnOrder = Convert.ToInt16(OrdenTextBox.Text);
                    //supplierToUpdate.ReorderLevel = Convert.ToInt16(levelTextbox.Text);

                    supplierToUpdate.CompanyName = companyNameTextBox.Text;
                    supplierToUpdate.ContactName = contactNameTextBox.Text;
                    supplierToUpdate.ContactTitle = contactTitleTextBox.Text;
                    supplierToUpdate.Address = AddressTextBox.Text;
                    supplierToUpdate.City = cityTextBox.Text;
                    supplierToUpdate.Region = regionTextBox.Text;
                    supplierToUpdate.PostalCode = postalCodeTextBox.Text;
                    supplierToUpdate.Country = countryTextBox.Text;
                    supplierToUpdate.Phone = phoneTextBox.Text;
                    supplierToUpdate.Fax = faxTextBox.Text;
                    supplierToUpdate.HomePage = homePageTextBox.Text;

                    // Guardar los cambios en la base de datos
                    _northwindContext.SaveChanges();
                    LoadSuppliers();
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

        private void SuppliersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companyNameTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CompanyNameColumn1"].Value);
            contactNameTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["ContactNameColumn1"].Value);
            contactTitleTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["ContactTitleColumn1"].Value);
            AddressTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["AddressColumn1"].Value);
            cityTextBox.Text= Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CityColumn1"].Value);
            regionTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["RegionColumn1"].Value);
            postalCodeTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["PostalCodeColumn1"].Value);
            countryTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CountryColumn1"].Value);
            phoneTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["PhoneColumn1"].Value);
            faxTextBox.Text= Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["FaxColumn1"].Value);
            homePageTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["HomePageColumn1"].Value);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuppliersDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int supplierId = Convert.ToInt32(SuppliersDataGridView.SelectedRows[0].Cells["SuppliersIdColumn1"].Value);

                    // Buscar el producto por su clave primaria
                    var supplierToDelete = _northwindContext.Suppliers.Find(supplierId);
                    if (supplierToDelete != null)
                    {
                        _northwindContext.Suppliers.Remove(supplierToDelete);
                        _northwindContext.SaveChanges();
                        LoadSuppliers();
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            }
        }
    }
}
