using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Estudiante
    {
        public string Nombre
        { get; set; }

        public int Nota
        {  get; set; }
        

        public Estudiante(string nombre, int nota)
        {
            this.Nombre = nombre;
            this.Nota = nota;
        }

        public Estudiante()
        {
            
        }
        public string CapturarNombre()
        {
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            return Nombre;
           
        }

        public int CapturarNota()
        {
            Console.Write("Nota: ");
            Nota = Int32.Parse(Console.ReadLine());
            
            while(!(Nota <= 10 && Nota >= 0))
            {
                Console.Write("Re-introduzca una nota dentro de la escala establecida: ");
                Nota = Int32.Parse(Console.ReadLine());

            }
            Console.Write("\n");
            return Nota;
        }

        public static string Condicion(int nota)
        {
            string res = "";

            if (nota >= 8)
            {
                res = "Muy Bueno";
            }
            else if (nota >= 4)
            {
                res = "Bueno";
            }
            else if (nota >= 0)
            {
                res = "Insuficiente";
            }
            else
            {
                res = "La nota esta fuera de la escala establecida.";
            }


            return res;
        }
    }
}