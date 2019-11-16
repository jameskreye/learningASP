using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisenadoProyecto
{
    class Program
    {
        private static Perro[] misPerros = new Perro[10];
        private static int indice;

        static void Main(string[] args)
        {
            string opcion = "";
            indice = 0;

            //instancio un perro 
            Perro perro1 = new Perro("Cachupon", "cafe", "bulldog");


            do
            {
                Console.Clear();
                //despliegue menu consola
                Console.WriteLine("=========================================");
                Console.WriteLine("BIENVENIDO: REGISTRO PERROS");
                Console.WriteLine("=========================================");
                Console.WriteLine("1 - Registrar");
                Console.WriteLine("2 - Acciones");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("=========================================");

                //Lectura de informacion dada por el usuario
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("===================================");
                        Console.WriteLine("Registro de Nuevo Perro");
                        Console.WriteLine("===================================");

                        Console.WriteLine("Ingrese el nombre :");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese la raza :");
                        string raza = Console.ReadLine();

                        Console.WriteLine("Ingrese el color :");
                        string color = Console.ReadLine();

                        Console.WriteLine("Ingrese la edad :");
                        short edad = short.Parse(Console.ReadLine());

                        Perro nuevoPerro = new Perro(edad, color, raza, nombre);
                        misPerros[indice] = nuevoPerro;
                        indice++;


                        Console.WriteLine("===================================");
                        Console.WriteLine("!PERRO AGREGADO CORRECTAMENTE!");
                        Console.WriteLine("===================================");
                        Console.WriteLine("!Pulsa cualquier tecla para salir!");
                        Console.WriteLine("===================================");
                        Console.ReadKey();
                        break;

                    case "2":
                        {
                            Console.WriteLine("===================================");
                            Console.WriteLine("!IDENTIFIQUE EL PERRO !");
                            Console.WriteLine("===================================");
                            Console.WriteLine("Indica el No de almacenado del perro");

                            //este numero identifica al perro en el arreglo 
                            int idPerro = int.Parse(Console.ReadLine());

                            if (idPerro < 10 && idPerro >= 10)
                            {
                                Perro perro = misPerros[idPerro];
                                string op = "";

                                do
                                {
                                    Console.WriteLine("1 - Ladrar");
                                    Console.WriteLine("2 - Dormir");
                                    Console.WriteLine("1 - Volver");
                                    op = Console.ReadLine();

                                    Console.Clear();

                                    if (op.Equals("1"))
                                    {
                                        perro.ladrar();
                                    }
                                    else if (op.Equals("2"))
                                    {
                                        perro.dormir();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pulsa cualquier tecla para sair ");
                                        Console.ReadKey();
                                    }

                                    misPerros[idPerro] = perro;

                                } while (op != "3");
                            }
                        }
                            break;
                      case "3":
                        break;
                    default:
                        break;
                }
            } while (!opcion.Equals("3"));

            }
  
        }
    }

