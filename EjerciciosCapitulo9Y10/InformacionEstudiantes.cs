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
    public partial class InformacionEstudiantes : Form
    {
        
        public InformacionEstudiantes()
        {
            InitializeComponent();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        Estudiantes estudiantes;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(IdEstudiantetextBox.Text);
            int edad = Convert.ToInt32(EdadtextBox.Text);
            
             
          
            estudiantes = new Estudiantes(codigo,NombretextBox.Text,ApellidostextBox.Text,edad,SexotextBox.Text,GradotextBox.Text);
            dataGridView1.Rows.Add(estudiantes.estudianteId,estudiantes.nombre,estudiantes.apellidos,estudiantes.edad,estudiantes.sexo,estudiantes.grado);
            MessageBox.Show("Datos estudiantes Guardados","Mesanje",MessageBoxButtons.OK,MessageBoxIcon.Information);

            IdEstudiantetextBox.Clear();
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            EdadtextBox.Clear();
            SexotextBox.Clear();
            GradotextBox.Clear();
        }
    }
}
