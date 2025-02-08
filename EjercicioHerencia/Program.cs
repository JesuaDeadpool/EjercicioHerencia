//Nombre: Jesua Pavon
using EjercicioHerencia;

Solucion solucion = new Solucion();


Console.WriteLine("----Area Trapecio----");
Console.WriteLine("Ingrese la Primera Base del trapecio : ");
solucion.Base1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la Segunda Base del trapecio : ");
solucion.Base2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese La altura del trapecio: ");
solucion.Altura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----Volumen Esfera----");
Console.WriteLine("Ingrese El Radio de la Esfera: ");
solucion.RadioEs = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----Longitud Circunferencia----");
Console.WriteLine("Ingrese El Radio de la Circunferencia : ");
solucion.RadioCi = Convert.ToInt32(Console.ReadLine());

solucion.Imprimir(); 
