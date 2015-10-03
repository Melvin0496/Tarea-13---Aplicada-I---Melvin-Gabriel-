using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCapitulo9Y10
{
    public partial class EstructuraProductosTienda : Form
    {
        ArrayList arreglo;
        public EstructuraProductosTienda()
        {
            InitializeComponent();
            arreglo = new ArrayList();
        }
       public struct Productos
        {
            public string NombreProducto;
            public string TipoProducto;
            public double Precio;

            public Productos(string pNombreProducto,string pTipoProducto,double pPrecio)
            {
                NombreProducto = pNombreProducto;
                TipoProducto = pTipoProducto;
                Precio = pPrecio;

            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}\n{1}\n{2}\n",NombreProducto,TipoProducto,Precio);
                return (sb.ToString());
            }
        }
        Productos pro;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(PreciotextBox.Text);
            pro = new Productos(NombreProductotextBox.Text,TipotextBox.Text,precio);
            arreglo.Add(pro.ToString());
            NombreProductotextBox.Clear();
            TipotextBox.Clear();
            PreciotextBox.Clear();

            MessageBox.Show("Producto guardado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            foreach (string joder in arreglo)
            {
                ProductosrichTextBox.Text += joder;
            }
            
         
            if(pro.ToString().Length == 0)
            {
                MessageBox.Show("No hay mas Productos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
