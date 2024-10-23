 using System;

class Program
{
    static void Main(string[] args)
    {
         //Console.OutputEncoding = System.Text.Encoding.UTF8; //para que se muestren los acentos
         Console.Clear(); 
         string nombre="Juan Pérez";
         string numero="123456";
         decimal saldo=1000M;
         CuentaBancaria cuenta1= new CuentaBancaria(nombre,numero,saldo);        
        
         cuenta1.MostrarDetalles();
         Console.WriteLine("\nDeposito de 1500");
         cuenta1=cuenta1+1500M;
         cuenta1.MostrarDetalles();
         Console.WriteLine("\nRetiro de 500");
         cuenta1=cuenta1-500M;
         cuenta1.MostrarDetalles();


    }
}