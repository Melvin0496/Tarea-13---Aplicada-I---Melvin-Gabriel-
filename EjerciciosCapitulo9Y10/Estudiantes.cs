using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCapitulo9Y10
{
    public class Estudiantes
    {
        public int estudianteId { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string grado { get; set; }

        public Estudiantes(int eEstudianteId,string eNombre,string eApellidos,int eEdad,string eSexo,string eGrado)
        {
            estudianteId = eEstudianteId;
            nombre = eNombre;
            apellidos = eApellidos;
            edad = eEdad;
            sexo = eSexo;
            grado = eGrado;
        }

    }
}
