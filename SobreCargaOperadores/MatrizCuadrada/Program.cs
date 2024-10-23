using System;

 public class Program
{
     static   void  Main()
    {
 
        MatrizCuadra A = new MatrizCuadra(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
        MatrizCuadra B = new MatrizCuadra(new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
        MatrizCuadra C = A + B;
        MatrizCuadra D = A - B;
        MatrizCuadra E = A * B;
        Console.WriteLine("Matriz A");
        Console.WriteLine(A);
        Console.WriteLine("Matriz B");
        Console.WriteLine(B);
        Console.WriteLine("Matriz C = A + B");
        Console.WriteLine(C);
        Console.WriteLine("Matriz D = A - B");
        Console.WriteLine(D);
        Console.WriteLine("Matriz E = A * B");
        Console.WriteLine(E);

    }
}//end program
 
 
    
   
