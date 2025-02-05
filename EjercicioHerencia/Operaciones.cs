using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {

        public double Base { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set;  }
        public double Radio {  get; set; }



        public double AreaTrapeacio()
        {
            return ((Base + Ancho) * Altura) / 2; 
        }


        public double VolumenEsfera()
        {
            return 4 / 3 * (Math.PI * Math.Pow(Radio, 3));

        }

        public double LongitudCircuferencia()
        {
            return 2 * Math.PI * Radio; 
        }


    }
}
