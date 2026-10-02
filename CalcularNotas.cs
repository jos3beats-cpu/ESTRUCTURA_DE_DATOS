using System;

class Program
{
    static void Main()
    {
        int cantidad = 22;

        string[] nombres = new string[cantidad];
        double[] calificaciones = new double[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
          
            do
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(nombres[i]));


            do
            {
                Console.Write("Nota (0 a 5): ");
            }
            while (!double.TryParse(Console.ReadLine(), out calificaciones[i]) ||
                   calificaciones[i] < 0 ||
                   calificaciones[i] > 5);
        }

        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < cantidad; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > mayor)
                mayor = calificaciones[i];

            if (calificaciones[i] < menor)
                menor = calificaciones[i];

            if (calificaciones[i] >= 3)
                aprobados++;
            else
                reprobados++;
        }

        Console.WriteLine();
        Console.WriteLine("Promedio: " + (suma / cantidad).ToString("F2"));
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }
}
