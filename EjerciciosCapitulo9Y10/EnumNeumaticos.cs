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
    public partial class EnumNeumaticos : Form
    {
        public EnumNeumaticos()
        {
            InitializeComponent();
        }
        enum Neumatico {Diagonal,Verano,Invierno,AllSeason,Asimetricos,Tubuless,PerfilBajo,Verdes,Runflat}

        private void EnumNeumaticos_Load(object sender, EventArgs e)
        {

        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            Neumatico N;

            if (TipocomboBox.Text.Equals("Diagonal"))
            {
               N = Neumatico.Diagonal;
               NeumaticosrichTextBox.Text = N.ToString() + ": " + "se componen de capas de tejido alternas y creuxadas colocadas diagonalmente en la carcasa formando un angulo que suele estar entre 40 y 45 grados.";
            }
            if (TipocomboBox.Text.Equals("Verano"))
            {
                N = Neumatico.Verano;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "Pueden utilizarse en cualquier epoca del año, pero su diseño y sus caracteristicas constructivas estan optimizadas para mejor agarre.";
            }
            if (TipocomboBox.Text.Equals("Invierno"))
            {
                N = Neumatico.Invierno;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "cuentan con compuestos especiales para mejorar el agarre a bajas temperaturas, y una banda de rodadura con unas laminillas que se agarran a la nieve.";
            }
            if(TipocomboBox.Text.Equals("All Season"))
            {
                N = Neumatico.AllSeason;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + " que no llegan a ofrecer la prestaciones de los neumáticos de invierno en carreteras nevadas o heladas, pero aportan más ranuras y mayor profundidad en el dibujo que un neumático de verano, para conseguir un buen compromiso para usuarios que conducen en zonas invernales donde la temperatura exterior no es muy baja y las temporadas de nieve son breves.";
            }
            if (TipocomboBox.Text.Equals("Asimetricos"))
            {
                N = Neumatico.Asimetricos;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "tienen diferente dibujo en la parte interior y la parte exterior del neumático, por ejemplo una parte optimizada para drenar el agua, y otra para mejorar el agarre en seco.";
            }
            if (TipocomboBox.Text.Equals("Tubuless"))
            {
                N = Neumatico.Tubuless;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "Se llaman neumáticos tubuless a los que no necesitan una cámara interior para encerrar el aire.";
            }
            if(TipocomboBox.Text.Equals("Perfil bajo"))
            {
                N = Neumatico.PerfilBajo;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "El perfil de un neumático es la altura de su flanco en milímetros. En la nomenclatura de un neumático, cuando nos dan sus dimensiones, viene determinado por la segunda cifra, que no indica la altura en sí, sino la relación entre la anchura –la primera cifra– y la altura.";
            }
            if (TipocomboBox.Text.Equals("Verdes"))
            {
                N = Neumatico.Verdes;
                NeumaticosrichTextBox.Text = N.ToString() + ": " + "Cada vez son más frecuentes en las gamas de los fabricantes de neumáticos los denominados neumáticos ecológicos, fabricados con compuestos especiales y con un diseño de su dibujo en la banda de rodadura pensado para mejorar la resistencia al rodamiento y disminuir así el consumo de combustible.";
            }
            if(TipocomboBox.Text.Equals("Run Flat"))
            {
                N = Neumatico.Runflat;
                NeumaticosrichTextBox.Text = N.ToString() + "" + "Los neumáticos runflat son un tipo especial de neumático con refuerzos en los flancos y los hombros, lo que les permite rodar una cierta distancia –entre unos 50 y 100 km– y a cierta velocidad –normalmente hasta 80 km/h– sin aire cuando se produce un pinchazo.";
            }
           
        }
    }
}
