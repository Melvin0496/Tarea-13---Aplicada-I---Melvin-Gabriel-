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
    public partial class EjerciciosCapitulo9Y10 : Form
    {
        public EjerciciosCapitulo9Y10()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capituloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio91ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraProductosTienda ep = new EstructuraProductosTienda();
            ep.Show();
        }

        private void ejercicio93ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraMascotaYDueño emd = new EstructuraMascotaYDueño();
            emd.Show();
        }

        private void ejercicio94ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnumNeumaticos en = new EnumNeumaticos();
            en.Show();
        }

        private void ejercicio92ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraCuenta cu = new EstructuraCuenta();
            cu.Show();
        }

        private void ejercicio101ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTienda it = new InventarioTienda();
            it.Show();
        }

        private void ejercicio102ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionEstudiantes ie = new InformacionEstudiantes();
            ie.Show();
        }

        private void ejercicio103ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoligonosForm p = new PoligonosForm();
            p.Show();
        }
    }
}
