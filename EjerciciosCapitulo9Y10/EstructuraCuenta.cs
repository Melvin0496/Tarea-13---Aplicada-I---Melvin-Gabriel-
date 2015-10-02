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
    public partial class EstructuraCuenta : Form
    {
        public EstructuraCuenta()
        {
            InitializeComponent();
        }

        public struct Cuenta
        {
            public string NombreEntidadFinanciera;
            public string TipoCuenta;
            public string NumeroCuenta;

            public Cuenta(string cNombreEntidadFinanciera,string cTipoCuenta,string cNumerocuenta)
            {
                NombreEntidadFinanciera = cNombreEntidadFinanciera;
                TipoCuenta = cTipoCuenta;
                NumeroCuenta = cNumerocuenta;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}\n{1}\n{2}\n",NombreEntidadFinanciera,TipoCuenta,NumeroCuenta);
                return sb.ToString();
            }
        }
        Cuenta cu;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if(AhorroradioButton.Checked)
            {
                cu = new Cuenta(NombreEntidadFinacieratextBox.Text,"Ahorro",NumeroCuentatextBox.Text);
            }
            if(CorrienteradioButton.Checked)
            {
                cu = new Cuenta(NombreEntidadFinacieratextBox.Text,"Corriente",NumeroCuentatextBox.Text);
            }
            MessageBox.Show("Se guardo la cuenta","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            NombreEntidadFinacieratextBox.Clear();
            NumeroCuentatextBox.Clear();
            
        }

        private void Cuentabutton_Click(object sender, EventArgs e)
        {
            DatosrichTextBox.Text = cu.ToString();
        }
    }
}
