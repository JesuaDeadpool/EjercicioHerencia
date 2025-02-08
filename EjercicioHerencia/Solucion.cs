using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
     public class Solucion : Operaciones
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }


        public void Imprimir()
        {
            Console.WriteLine(); 
            Console.WriteLine($"El Trapecio con una Base {Base1} una Anchura  {Base2} y una Altura {Altura}, El area es de : {AreaTrapeacio(Base1,Base2,Altura)}");
            Console.WriteLine(); 
            Console.WriteLine($"La esfera con un Radio {Radio}, su volumen es de : {VolumenEsfera(Radio)}");
            Console.WriteLine();
            Console.WriteLine($"La circunsferencia con un Radio {Radio}, su longitud es de : {LongitudCircuferencia(Radio)}");
        }
     

    }
}
