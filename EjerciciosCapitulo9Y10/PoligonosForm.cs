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
    public partial class PoligonosForm : Form
    {
        public PoligonosForm()
        {
            InitializeComponent();
        }
        Poligonos p;
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            double longituLado = Convert.ToDouble(LongitudRegulartextBox.Text);
            int numeroLados = Convert.ToInt32(NumLadoRegulartextBox.Text);
            double apotema = Convert.ToDouble(ApotemaRegulartextBox.Text);

            if (PoligonocheckBox.Checked)
            {
                p = new Poligonos(longituLado,numeroLados,apotema);
                AreaRegulartextBox.Text = Convert.ToString(p.AreaPoligonoRegular(longituLado,numeroLados,apotema));
                PerimetroRegulartextBox.Text = Convert.ToString(p.PerimetroPoligonoRegunlar(longituLado,numeroLados));
            }
            if (CuadradocheckBox.Checked)
            { 

                p = new Poligonos(longituLado);
                AreaCuadradotextBox.Text = Convert.ToString(p.AreaCuadrado(longituLado));
                PerimetroCuadradotextBox.Text = Convert.ToString(p.PerimetroCuadrado(longituLado));
            }
        }

        private void Calcular2button_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(BaseEquilaterotextBox.Text);
            double altura = Convert.ToDouble(AlturaEquilaterotextBox.Text);
            double longitudLado = Convert.ToDouble(LongitudLadoEquilaterotextBox.Text);

            if (EquilaterocheckBox.Checked)
            {
                p = new Poligonos(Base,altura,longitudLado);
                PerimetroEquilaterotextBox.Text = Convert.ToString(p.PerimetroEquilatero(longitudLado));
                AreaEquilaterotextBox.Text = Convert.ToString(p.AreaEquilatero(Base,altura));
            }
            if (RectangulocheckBox.Checked)
            {
                p = new Poligonos(Base,altura);
                PerimetroRectangulotextBox.Text = Convert.ToString(p.PerimetroRectangulo(Base,altura));
                AreaRectangulotextBox.Text = Convert.ToString(p.AreaRectangulo(Base,altura));
            } 
        }

      
    }
}
