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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Categorias: Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Categories> _categoriesValidator;
        public Categorias(NorthwindContext northwindContext, IValidator<Categories> categoriesValidator)
        {
            InitializeComponent();
            CategoriesDataGridView.SelectionChanged += CategoryDataGridView_SelectionChanged;
            CategoriesDataGridView.AutoGenerateColumns = false;
            this._northwindContext = northwindContext;
            this._categoriesValidator = categoriesValidator;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoriesDataGridView.DataSource = _northwindContext.Categories.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Categories();
            category.CategoryName = categoryNameTextBox.Text;
            category.Description = descriptionTextBox.Text;

            var validationResult = _categoriesValidator
                    .Validate(category);

            try
            {
                if (validationResult.IsValid)
                {
                    _northwindContext.Categories.Add(category);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Suplidor insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();

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

                categoryNameTextBox.Clear();
                descriptionTextBox.Clear();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message, "Error saving products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CategoriesDataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria de la fila seleccionada
                string categoryId = Convert.ToString(CategoriesDataGridView.SelectedRows[1].Cells["CategoryNameColumn1"]);

                // Obtener el producto a modificar
                var categoryToUpdate = _northwindContext.Categories.Find(categoryId);
                if (categoryToUpdate != null)
                {
                    

                    categoryToUpdate.CategoryName = categoryNameTextBox.Text;
                    categoryToUpdate.Description = descriptionTextBox.Text;
                    

                    // Guardar los cambios en la base de datos
                    _northwindContext.SaveChanges();
                    LoadCategories();
                    MessageBox.Show("Categoria actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CategoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriesDataGridView.SelectedRows.Count > 0)
            {
                var Category = (Categories)CategoriesDataGridView.SelectedRows[0].DataBoundItem;
                categoryNameTextBox.Text = Category.CategoryName;
                descriptionTextBox.Text = Category.Description;

                try
                {
                    if (Category.Picture != null)
                    {
                        var ms = new MemoryStream(Category.Picture, 78, Category.Picture.Length - 78);
                        var bm = new Bitmap(ms);
                        picturePictureBox.Image = bm;
                    }
                    else
                    {
                        picturePictureBox.Image = null;
                        picturePictureBox.InitialImage = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoryNameTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    CategoriesDataGridView.DataSource = context.Categories.ToList();
                }

                CategoriesDataGridView.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int categoryId = Convert.ToInt32(CategoriesDataGridView.SelectedRows[0].Cells["CategoryId"].Value);

                    // Buscar el producto por su clave primaria
                    var categoryToDelete = _northwindContext.Categories.Find(categoryId);
                    if (categoryToDelete != null)
                    {
                        _northwindContext.Categories.Remove(categoryToDelete);
                        _northwindContext.SaveChanges();
                        LoadCategories();
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
