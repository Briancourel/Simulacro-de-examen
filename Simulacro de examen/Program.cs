using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_de_examen
{
    internal class Program
    {
        static string nombre;
       static int edad;
        static int dni;
        static double nota;
        static string estado;
        static int opcion;
        static bool existe = false;
        

        static void Main(string[] args)

        {
           
             void AñadirEstudiante() 
            {
                Console.WriteLine("ingrese el nombre y apellido del estudiante");
                nombre = Console.ReadLine();
                Console.WriteLine(" ingrese la edad del estudiante");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese el DNI");
                dni = int.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese la nota");
                nota = double.Parse(Console.ReadLine());

                existe = true;
            }
            
            void MostrarInformacion()
            {
                if (existe == true)
                {
                    Console.WriteLine(" nombre del estudiante: " + nombre);
                    Console.WriteLine(" edad del estudiante: " + edad);
                    Console.WriteLine(" dni del estudiante: " + dni);
                    Console.WriteLine("nota del estudiante: " + nota);
                }
                else {
                    Console.WriteLine(" el usuario aun no fue ingresado");
                     }
              
            }

           
            void MostrarEstado() 
            {
             if (nota >= 4 && nota < 7 ) 
                {
                  Console.WriteLine(" El estado de cursada del estudiante basado en su nota es: APROBADO PERO RINDE FINAL ");
                } 
             else if (nota >= 7) 
                {
                  Console.WriteLine(" El estado de  cursada del estudiante basado en su nota  PROMOCIONADO ");
                }
             else
                {
                    Console.WriteLine(" El estado de  cursada del estudiante basado en su nota es: DESAPROBADO ");
                }
            }

            Console.WriteLine(" bienvenido al programa ingrese el numero para buscar lo que desea");
            
            void OpcionesMenu() 
            {
                Console.WriteLine("1) si desea añadir un estudiante");
                Console.WriteLine("2) si desea mostrar la informacion del estudiante");
                Console.WriteLine("3) Mostrar el estado de la cursada");
                Console.WriteLine("4) Mostrar la cantidad de vocales que tiene el alumno entre nombre y apellido ");
                Console.WriteLine("5) Salir del programa");

            }

            void ContarVocales() 

            {
                int contador = 0;
               for ( int i = 0; i < nombre.Length; i++ ) 
                {
                if (nombre[i] =='a' || nombre[i] == 'e' || nombre[i] == 'i' || nombre[i] == 'o' || nombre[i] == 'u' ||
                    nombre[i] == 'A' || nombre[i] == 'E' || nombre[i] == 'I' || nombre[i] == 'O' || nombre[i] == 'U') 
                    {
                        contador++;
                    }
                        
                }

                Console.WriteLine(" LA CANTIDAD DE VOCALES SON " + contador);
            }

            void ManejoMenu() 
            {
                switch (opcion)
                {
                    case 1: AñadirEstudiante(); break;

                    case 2: MostrarInformacion(); break;


                    case 3:; MostrarEstado(); break;

                    case 4:; ContarVocales(); break;

                    case 5: Console.WriteLine(" saliste del programa "); break;

                }
            }

            do
            {
               OpcionesMenu();

                opcion = int.Parse(Console.ReadLine());

                ManejoMenu();

               
            } while (opcion != 5 );


        }
    }
}
