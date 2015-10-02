using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCapitulo9Y10
{
    public class Poligonos
    {
        private double pLongitudLado;
        private int pNumeroLados;
        private double pApotema;
        private double pBase;
        private double pAltura;

        public double longitudLado
        {
            get
            {
                return longitudLado;
            }
            set
            {
                if(value < 0)
                {
                    pLongitudLado = 1;
                }
                else
                {
                    pLongitudLado = value;
                }
            }
        }
        public int numeroLados
        {
            get
            {
                return pNumeroLados;
            }
            set
            {
                if (value < 0)
                {
                    pNumeroLados = 1;
                }
                else
                {
                    pNumeroLados = value;
                }
            }
        }
        public double apotema
        {
            get
            {
                return pApotema;
            }
            set
            {
                if (value < 0)
                {
                    pApotema = 1;
                }
                else
                {
                    pApotema = value;
                }
            }
        }
        public double Base
        {
            get
            {
                return pBase;
            }
            set
            {
                if(value < 0)
                {
                    pBase = 1;
                }
                else
                {
                    pBase = value;
                }
            }
        }
        public double  altura
        {
            get
            {
                return pAltura;
            }
            set
            {
                if(value < 0)
                {
                    pAltura = 1;
                }
                else
                {
                    pAltura = value;
                }
            }
        }

        public Poligonos(double longitudLado,int numeroLados,double apotema,double Base,double altura)
        {
            this.longitudLado = longitudLado;
            this.numeroLados = numeroLados;
            this.apotema = apotema;
            this.Base = Base;
            this.altura = altura;
        }
        public Poligonos(double longitudLado,int numeroLados,double apotema)
        {
            this.longitudLado = longitudLado;
            this.numeroLados = numeroLados;
            this.apotema = apotema;
            
        }
        public Poligonos(double Base, double altura)
        {
            this.Base = Base;
            this.altura = altura;
        }
        public Poligonos(double longitudLado)
        {
            this.longitudLado = longitudLado;
        }
        public Poligonos(double Base,double altura,double longitudLado)
        {
            this.Base = Base;
            this.altura = altura;
            this.longitudLado = longitudLado;
        }
        public double PerimetroPoligonoRegunlar(double longitudLado,int numeroLados)
        {
            return pLongitudLado * pNumeroLados;
        }
        public double AreaPoligonoRegular(double longituLado,int numeroLados,double apotema)
        {
            return (PerimetroPoligonoRegunlar(pLongitudLado,pNumeroLados) * pApotema) / 2;
        }
        public double PerimetroCuadrado(double longitudLado)
        {
            return 4 * pLongitudLado;
        }
        public double AreaCuadrado(double longitudLado)
        {
            return pLongitudLado * pLongitudLado;
        }
        public double PerimetroEquilatero(double longitudLado)
        {
            return 3 * pLongitudLado;
        }
        public double AreaEquilatero(double Base, double altura)
        {
            return (pBase * pAltura) / 2;
        }
        public double PerimetroRectangulo(double Base, double altura)
        {
            return 2 * (pBase + pAltura);
        }
        public double AreaRectangulo(double Base, double Altura)
        {
            return pBase * pAltura;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\n{2}\n{3}\n{4}\n\n",pLongitudLado,pNumeroLados,pApotema,pBase,pAltura);
            return sb.ToString(); 
        }
    }
}
