using Microsoft.Extensions.DependencyInjection;
using Practica3.Models;
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
    public partial class Menu : Form
    {
        public readonly Productos _productos;
        public readonly Categorias _categorias;
        public readonly Suplidores _suplidores;
        public readonly Ordenes _ordenes;
        public readonly OrdenesDetalles _ordenesDetalles;
        public Menu(Productos productos, Categorias categorias, Suplidores suplidores, Ordenes ordenes, OrdenesDetalles ordenesDetalles)
        {
            InitializeComponent();
            _productos = productos;
            _categorias = categorias;
            _suplidores = suplidores;
            _ordenes = ordenes;
            _ordenesDetalles = ordenesDetalles;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _categorias.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _suplidores.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _ordenes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _ordenesDetalles.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
