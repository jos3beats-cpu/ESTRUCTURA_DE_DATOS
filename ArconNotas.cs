using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcon
{
    internal class Program
    {

        static void Main()

            //Taller de jose arcon, el archivo se guarda en la carpeta de descargas
        {
            string ruta = "C:\\Users\\Downloads\\NotasAlumnos.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre,Edad,Nota");
                sw.WriteLine("Jose,19,50");
                sw.WriteLine("Estiven,17,40");
                sw.WriteLine("Oscar,18,20");
                sw.WriteLine("Felipe,21,45");
                sw.WriteLine("Bryan,17,30");
                sw.WriteLine("Andres,18,23");

            }
            Console.WriteLine("El Archivo ha sido creado con éxito.");
        }
    }

}

