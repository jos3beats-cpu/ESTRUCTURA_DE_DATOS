using System;

public class Program
{
static void ImprimirCabecera(string nombreMateria, int grupo, string nombreEstudiante){
    Console.WriteLine
    ("==============================================");
    Console.WriteLine("            Universidad Del Caribe    ");
    Console.WriteLine($"Asignatura: {  nombreMateria  }");
    Console.WriteLine($"Grupo: {  grupo  }");
    Console.WriteLine($"Nombre del estudiante : {  nombreEstudiante  }");
    Console.WriteLine
    ("==============================================");

    }


    public static void Main(string[] args)
    {
    ImprimirCabecera("Fundamentos de programacion", 1, "Jose Arcon");
    }
}
