using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
     public class Solucion : Operaciones
    {
        public double Base { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }


        public void Imprimir()
        {
            Console.WriteLine($"El Trapecio con una Base {Base} una Anchura  {Ancho} y una Altura {Altura}, El area es de : {AreaTrapeacio(Base,Ancho,Altura)}"); 
        }
     

    }
}
