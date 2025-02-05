using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {

        public double AreaTrapeacio(double baseA, double ancho, double altura)
        {
            return ((baseA + ancho) * altura) / 2; 
        }


        public double VolumenEsfera(double radio)
        {
            return 4 / 3 * (Math.PI * Math.Pow(radio, 3));

        }

        public double LongitudCircuferencia(double radio)
        {
            return 2 * Math.PI * radio; 
        }


    }
}
