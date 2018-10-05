using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio2
{
    class Program
    {
        public static string cargamail()       //Funcion que carga el email ingresado por teclado y retorna el string
        {
            string mail;
            Console.WriteLine("Ingrese Email: ");
            mail = Console.ReadLine();
            return mail;
        }
        public static int cargadni()            //Funcion que carga el dni ingresado por teclado y retorna el int
        {
            int dni;
            Console.WriteLine("Ingrese dni: ");
            dni = Convert.ToInt32(Console.ReadLine());
            return dni;
        }
        public static string carganombre()      //Funcion que carga el nombre ingresado por teclado y retorna el string
        {
            string nombre;
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            return nombre;
        }
        public static int cargalegajo()         //Funcion que carga el Legajo ingresado por teclado y retorna el int
        {
            int legajo;
            Console.WriteLine("Ingrese legajo: ");
            legajo = Convert.ToInt32(Console.ReadLine());
            return legajo;
        }
        public static void imprimirdatos(string mail, int dni, string nombre, int legajo)   //Funcion que imprime los datos cargados
        {
            Console.WriteLine("DATOS:\n" +
                "Nombre: {0}\n" +
                "DNI: {1}\n" +
                "Email: {2}\n" +
                "Legajo: {3}\n", nombre, dni, mail, legajo);
        }
        static void Main(string[] args)
        {
            int opcion=0, dni=0, legajo=0;          //Definicion de variables
            string nombre="0", mail="0";
            Console.WriteLine("MENU DE USUARIO\n" +     //Menu principal
                "1. Cargar Email\n" +
                "2. Cargar DNI\n" + 
                "3. Cargar Nombre\n" +
                "4. Cargar Legajo\n" +
                "5. Imprimir datos\n" +
                "6. Salir\n");
            
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        mail = cargamail();
                        break;
                    case 2:
                        dni = cargadni();
                        break;
                    case 3:
                        nombre = carganombre();
                        break;
                    case 4:
                        legajo = cargalegajo();
                        break;
                    case 5:
                        imprimirdatos(mail, dni, nombre, legajo);
                        break;
                }
            } while (opcion != 6);
            
        }
    }
}
