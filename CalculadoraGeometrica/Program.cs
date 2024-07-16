using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ExcpetionTest
{
    static double SafeDivision(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        return x / y;
    }

    public static void Main()
    {
        double a, b;
        try { 

        Console.WriteLine("Introduce el primer valor");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el segundo valor");
        b = Double.Parse (Console.ReadLine());
        double result;

        
        
            result = SafeDivision(a, b);
            Console.WriteLine("El resultado de {0} entre {1} es: {2}", a, b, result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error al intentar dividir entre cero");
        }
        catch (FormatException xd)
        { 
        Console.WriteLine("No se puede dividir entre una letra bro, puro numero");
            Console.WriteLine(xd.Message);
        }
    }

}



