using System;

namespace Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, Producto=0;
            Console.WriteLine("Ingrese el primer nuero");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2=int.Parse(Console.ReadLine());

            for (int i=0; i<n2; i++)
            {
                Producto = Producto + n1; 
            }
            Console.WriteLine("La suma sucesiva de los productos es: {0}", Producto);
            Console.ReadKey(true);
        }
    }
}
