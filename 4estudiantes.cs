using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* En un curso de 4 alumnos se registraron las notas de sus exámenes y 
             * se deben procesar de acuerdo a lo siguiente:
             a) Ingresar nombre y nota de cada alumno(almacenar los datos en dos listas paralelas)
             b) Realizar un listado que muestre los nombres, notas y condición del alumno.
            En la condición, colocar "Muy Bueno" si la nota es mayor o igual a 8, "Bueno" si la nota 
            está entre 4 y 7, y colocar "Insuficiente" si la nota es inferior a 4.
             c) Imprimir cuantos alumnos tienen la leyenda “Muy Bueno”. */


            Estudiante e1 = new Estudiante();
            Estudiante e2 = new Estudiante();
            Estudiante e3 = new Estudiante();
            Estudiante e4 = new Estudiante();

            
            Console.WriteLine("Ingrese el nombre y notas de los alumnos: ");
            Console.WriteLine("***NOTA: La escala de notas es 0-10***");
            Console.Write("\n");


            e1.CapturarNombre();
            e1.CapturarNota();
            e2.CapturarNombre();
            e2.CapturarNota();
            e3.CapturarNombre();
            e3.CapturarNota();
            e4.CapturarNombre();
            e4.CapturarNota();

            

            Console.Clear();

            Console.Write("Nombre 1: " + e1.Nombre + " || " + "Nota: " + e1.Nota + " || " + "Condicion: " + Estudiante.Condicion(e1.Nota) + "\n"); 
            Console.Write("Nombre 2: " + e2.Nombre + " || " + "Nota: " + e2.Nota + " || " + "Condicion: " + Estudiante.Condicion(e2.Nota) + "\n");
            Console.Write("Nombre 3: " + e3.Nombre + " || " + "Nota: " + e3.Nota + " || " + "Condicion: " + Estudiante.Condicion(e3.Nota) + "\n");
            Console.Write("Nombre 4: " + e4.Nombre + " || " + "Nota: " + e4.Nota + " || " + "Condicion: " + Estudiante.Condicion(e4.Nota) + "\n");

        }

        
    }
}