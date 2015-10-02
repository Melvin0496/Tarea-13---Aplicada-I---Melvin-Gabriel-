using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCapitulo9Y10
{
   public class Inventario
   {
        public int codigo { get; set; }
        public string producto { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }

        public Inventario(int iCodigo,string iProducto,double iPrecio,int iCantidad)
        {
            this.codigo = iCodigo;
            this.producto = iProducto;
            this.precio = iPrecio;
            this.cantidad = iCantidad;
        }

        public double Importe(double precio,int cantidad)
        {
            return precio * cantidad;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}{2}{3}{4}",codigo,producto,precio,cantidad,this.Importe(precio,cantidad));
            return sb.ToString();
        }

    }
}
