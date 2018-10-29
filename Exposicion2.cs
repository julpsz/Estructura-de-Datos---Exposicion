using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp7
{
    
      
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nombre_apellido = new ArrayList();
            ArrayList dni = new ArrayList();
            ArrayList legajo = new ArrayList();


            int opcion;


            do
            {
                Console.WriteLine("MENU PRINCIPAL - INSCRIPCION AL CURSO 2018");
                Console.WriteLine("" +
                    "1. Inscribir Alumno\n" +
                    "2. Borrar inscripcion de alumno\n" +
                    "3. Listar alumnos inscriptos\n" +
                    "4. Borrar curso completo\n" +
                    "5. SALIR\n\n");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inscribir();
                        break;
                    case 2:
                        borrar();
                        break;
                    case 3:
                        listar();
                        break;
                    case 4:
                        borra_curso();
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 5);

            void inscribir()
            {
                
                Console.WriteLine("Ingrese nombre y apellido del alumno");
                nombre_apellido.Add(Console.ReadLine());
                Console.WriteLine("Ingrese dni del alumno");
                dni.Add(Console.ReadLine());
                Console.WriteLine("Ingrese legajo del alumno");
                legajo.Add(Console.ReadLine());
                Console.Clear();
            }

            void borrar()
            {
                string borr;
                int posicion=0;

                Console.WriteLine("Ingrese nombre y apellido del alumno a borrar");
                borr = Convert.ToString(Console.ReadLine());

                posicion= nombre_apellido.IndexOf(borr);
                nombre_apellido.RemoveAt(posicion);
                dni.RemoveAt(posicion);
                legajo.RemoveAt(posicion);
                Console.Clear();
            }

            void listar()
            {
                Console.Clear();
                int i;
                Console.WriteLine("ALUMNOS INSCRIPTOS");
                for(i=0; i<nombre_apellido.Count; i++)
                {
                    Console.WriteLine("Nombre y apellido:       {0}",nombre_apellido[i]);
                    Console.WriteLine("DNI:                     {0}",dni[i]);
                    Console.WriteLine("Legajo Nro:              {0}\n",legajo[i]);
                }
                Console.WriteLine("Total de alumnos inscriptos al curso: {0}\n",nombre_apellido.Count);
                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR...");
                Console.ReadKey();
                Console.Clear();
            }

            void borra_curso()
            {
                nombre_apellido.Clear();
                dni.Clear();
                legajo.Clear();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
