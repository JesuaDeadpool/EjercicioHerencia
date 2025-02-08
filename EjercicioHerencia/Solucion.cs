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
        public double RadioEs { get; set; }
        public double RadioCi { get; set; }

        public void Imprimir()
        {
            Console.WriteLine(); 
            Console.WriteLine($"El Trapecio con una Base {Base1} una Anchura  {Base2} y una Altura {Altura}, El area es de : {AreaTrapeacio(Base1,Base2,Altura).ToString("F2")}");
            Console.WriteLine(); 
            Console.WriteLine($"La esfera con un Radio {RadioEs}, su volumen es de : {VolumenEsfera(RadioEs).ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"La circunsferencia con un Radio {RadioCi}, su longitud es de : {LongitudCircuferencia(RadioCi).ToString("F2")}");
        }
     

    }
}
