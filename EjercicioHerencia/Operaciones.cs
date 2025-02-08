using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double AreaTrapeacio(double Base1, double Base2, double Altura)
        {
            return ((Base1 + Base2) * Altura) / 2; 
        }


        public double VolumenEsfera(double Radio)
        {
            return 4 / 3 * (Math.PI * Math.Pow(Radio, 3));

        }

        public double LongitudCircuferencia(double Radio)
        {
            return 2 * Math.PI * Radio; 
        }


    }
}
