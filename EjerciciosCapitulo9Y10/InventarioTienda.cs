using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EjerciciosCapitulo9Y10
{
    public partial class InventarioTienda : Form
    {
        Inventario i;
        public InventarioTienda()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(CodigotextBox.Text);
            double precio = Convert.ToDouble(PreciotextBox.Text);
            int cantidad = Convert.ToInt32(CantidadtextBox.Text);

            i = new Inventario(codigo, ProductotextBox.Text, precio, cantidad);
            i.Importe(precio, cantidad);

            dataGridView1.Rows.Add(i.codigo, i.producto, i.precio, i.cantidad, i.Importe(i.precio, i.cantidad));
            MessageBox.Show("Productos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CodigotextBox.Clear();
            ProductotextBox.Clear();
            PreciotextBox.Clear();
            CantidadtextBox.Clear();
        }

       
    }
}
