using System;

public class ProgramaJose

{
    static double CalcularAreaCirculo(double radio)
    {
        const double PI = 3.141592;
        //Ahora realizare el calculo
        double area = PI * Math.Pow(radio, 2);
        return area;
    }

    public static void Main(string[] args)
    {
        Console.Write("Ingrese el radio del circulo: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double result = CalcularAreaCirculo(r);
        Console.WriteLine($"El area es: {result:F2}");

    }
}