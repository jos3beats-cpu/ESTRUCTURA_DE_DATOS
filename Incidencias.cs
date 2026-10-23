using System;
using System.Collections.Generic;
using System.IO;

// Registro de incindencias de soporte técnico utilizando archivos (.txt)
// 1. Guardar en una lista de incindencias atendidas en un archivo de texto (incindencias.txt)
// 2. Leer el archivo
// 3. Generar un reporte que cuenta cuántas incindencias hay por prioridad (Alta, media, baja).
// La estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.

// Ejemplo: "01";"Jose Arcon";"Daño del Pc". 

namespace JoseArcon
{
    internal class Program
    {
        //"C:\Users\SALA-1\Desktop"
        //Creando ruta para guardar mis incidencias
        static string pathArchivos = "incidencias.txt";

        static void GuardarIncidencias(List<string[]> incindencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivos, false))
                {
                    foreach (string[] incidencias in incindencias)
                    {
                        sw.WriteLine(string.Join(";", incidencias));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncindencia()
        {
            List<string[]> incindencias = new List<string[]>();

            if (!File.Exists(pathArchivos))
            {
                Console.WriteLine("El archivo no existe aún");
                return incindencias;
            }

            try
            {
                string linea;

                using (StreamReader sr = new StreamReader(pathArchivos))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            string[] campos = linea.Split(';');
                            incindencias.Add(campos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return incindencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencia para reportar. ");
                return;
            }

            Dictionary<string, int> ContarPorPrioridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length != 4) continue;

                string prioridad = inc[3].Trim().ToUpper();

                if (ContarPorPrioridad.ContainsKey(prioridad))
                {
                    ContarPorPrioridad[prioridad]++;
                }
                else
                {
                    ContarPorPrioridad[prioridad] = 1;
                }
            }

            Console.WriteLine("\n Reporte de incidencias");
            Console.WriteLine($"Total atendidas: {incidencias.Count}");
            Console.WriteLine("Detalle por prioridad");

            foreach (var inc in ContarPorPrioridad)
            {
                Console.WriteLine($"\n Prioridad {inc.Key}: {inc.Value}");
            }
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] { "01", "Jose Arcon", "No imprime", "ALTA" },
                new string[] { "02", "Oscar Hernandez", "Olvido contraseña", "BAJA" },
                new string[] { "03", "Stiven Orellano", "Wifi lento", "ALTA" },
                new string[] { "04", "Santiago Gonzales", "Pantalla azul", "MEDIA" },
                new string[] { "05", "Sebastian Cordoba", "PC no enciende", "ALTA" }
            };

            Console.WriteLine("Registro de incidencias unicaribe");
            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n --- Leyendo incidencias del archivo ---");
            List<string[]> incidenciasLeidas = LeerIncindencia();

            Console.WriteLine("\n Listado de incidencias leidas: ");
            Console.WriteLine($"{"ID",-4}{"Usuario",-20}{"Descripcion",-25}{"Prioridad",-10}");
            Console.WriteLine(new string('-', 59));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length != 4) continue;

                Console.WriteLine($"{inc[0],-4}{inc[1],-20}{inc[2],-25}{inc[3],-10}");
            }

            GenerarReporte(incidenciasLeidas);

            Console.WriteLine("\n Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
