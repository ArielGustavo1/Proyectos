// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num1 / num2;

        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("La resta es: " + resta);
        Console.WriteLine("La multiplicación es: " + multiplicacion);
        Console.WriteLine("La división es: " + division);
    }
}