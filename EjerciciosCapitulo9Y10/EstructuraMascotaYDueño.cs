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
    public partial class EstructuraMascotaYDueño : Form
    {
        ArrayList arreglo;
        public EstructuraMascotaYDueño()
        {
            InitializeComponent();
            arreglo = new ArrayList();
        }

        public struct Dueño
        {
            public string Nombre;
            public string Apellido;
            public int Edad;
            public string Direccion;
            public string Telefono;
            public Mascota MiMascota;

            public Dueño(string dNombre, string dApellido, int dEdad,string dDireccion, string dTelefono,string dNombreMascota,string dClase, string dRaza)
            {
                Nombre = dNombre;
                Apellido = dApellido;
                Edad = dEdad;
                Direccion = dDireccion;
                Telefono = dTelefono;

                MiMascota = new Mascota(dNombreMascota,dClase,dRaza);
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre Dueño: {0}\nApellido: {1}\nEdad: {2}\nDireccion: {3}\nTelefono: {4}\nNombre Mascota: {5}\nClase: {6}\nRaza: {7}\n\n",Nombre,Apellido,Edad,Direccion,Telefono,MiMascota.NombreMascota,MiMascota.Clase,MiMascota.Raza);
                return (sb.ToString());
            }

        }
        public struct Mascota
        {
            public string NombreMascota;
            public string Clase;
            public string Raza;

            public Mascota(string mNombreMascota,string mClase,string mRaza)
            {
                NombreMascota = mNombreMascota;
                Clase = mClase;
                Raza = mRaza;
            }
        }
        Dueño du;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(EdadtextBox.Text);

            du = new Dueño(NombretextBox.Text, ApellidotextBox.Text, edad, DirecciontextBox.Text, TelefonotextBox.Text, NombreMascotatextBox.Text, ClasetextBox.Text, RazatextBox.Text);
            arreglo.Add(du.ToString());
            MessageBox.Show("Informacion guardada","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            EdadtextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            NombreMascotatextBox.Clear();
            ClasetextBox.Clear();
            RazatextBox.Clear();
            
        }

       

        private void Informacionbutton_Click_1(object sender, EventArgs e)
        {
            foreach (string var in arreglo)
            {
                InformacionrichTextBox.Text += var;
            }
            
        }
    }
}
