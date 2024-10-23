using System;

class Program
{
    // Método de sobrecarga para sumar dos números enteros
    static int sumar(int a, int b)
    {
        return a + b;
    }

    // Método de sobrecarga para sumar dos números decimales
    static double sumar(double a, double b)
    {
        return a + b;
    }
    static int sumar(IEnumerable<int> elements){ 
        int result=0;
        foreach(var x in elements){
              result+=x;
        }

        return result;

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Resultado de la suma de enteros: " + sumar(5, 3));
        Console.WriteLine("Resultado de la suma de decimales: " + sumar(2.5, 3.7));
        Console.WriteLine("Resultado de la suma de array enteros: "
        + sumar(new int[]{1,2,3,4}));
        Console.WriteLine("Resultado de la suma de List enteros: "
       + sumar(new List<int>() { 1, 2, 3, 4 }));
    }
}


