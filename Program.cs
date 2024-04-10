using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine("Ingrese el alto del lote en metros:");
        double alto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el largo del lote en metros:");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el precio por metro cuadrado en dolares:");
        double precioM2 = Convert.ToDouble(Console.ReadLine());

        
        double area = alto * largo;

       
        double precioTotal = area * precioM2;

      
        Console.WriteLine("El área del lote es: " + area + " metros cuadrados");
        Console.WriteLine("El precio total del lote es: $" + precioTotal);
    }
}
