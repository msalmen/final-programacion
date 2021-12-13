using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_de_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEjercicio = 0;



            //Menu
            Console.WriteLine("Elija el ejercicio que desee ejecutar:");
            numEjercicio = Convert.ToInt32 (Console.ReadLine());
            
            switch (numEjercicio) 
                {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;

            }
            Console.ReadKey();
        }

        private static void Ejercicio1()
        {
            int numInicial = 0;
            int numFinal = 0;
            string param3 = "par";
            int[] numToShow = new int[] { };


            Console.WriteLine("Ingrese el valor del parametro 1");
            numInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del parametro 2");
            numFinal = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese par o impar");
            param3 = Convert.ToString(Console.ReadLine());


            numToShow = ParoImpar(numInicial, numFinal, param3);
            Console.WriteLine("Lista de numeros elegidos:");
            for (int i = 0; i < numToShow.Length; i++)
            {
                Console.WriteLine("{0}", numToShow[i]);
            }            
        }
        private static void Ejercicio2()
        {
            string palabra = "";
            char[] letrasArray = new char[] { };

            Console.WriteLine("Ingrese la palabra que desea separar:");
            palabra = Console.ReadLine();
            letrasArray = DividirPalabra(palabra);
            
            for (int i = 0; i < letrasArray.Length; i++)
            {
                Console.WriteLine("Posicion [{0}],letra [{1}]", i, letrasArray[i]);
            }
            Console.ReadKey();
        }

        private static void Ejercicio3()
        {
            
            string palabra = "";

            Console.WriteLine("Ingrese una palabra para saber la posicion de sus letras:");
            palabra = Console.ReadLine();

            PalabrasANumeros(palabra);

        }


        static int[] ParoImpar(int param1, int param2, string param3) {
            List<int> numTotal = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            int[] numTArray = new int[] { };
            int[] numParOImpar = new int[] { };
            



            Console.WriteLine("Cargando lista...");
            for (int i = 0; i <= param2 - param1; i++)
            {
                numTotal.Add(param1+i);
                if ((numTotal[i] % 2 == 0))
                {
                    pares.Add(numTotal[i]);
                    Console.WriteLine("Agregado a lista de pares");
                }
                else 
                {
                    impares.Add(numTotal[i]);
                    Console.WriteLine("Agregado a lista de impares");
                }
            }
            
            numTArray = numTotal.ToArray();
            if (param3 == "par")
            {
                numParOImpar = pares.ToArray();
            }
            else 
            {
                numParOImpar = impares.ToArray();
            }        
                        
            return numParOImpar;                      
        }
        static char[] DividirPalabra(string palabra)
        {
            
            char[] letras = palabra.ToCharArray();
            Console.WriteLine(" esta andando el array, la letra en la pos 3 es = {0}", letras[3]);
            return letras;
        }

        static void PalabrasANumeros(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            char[,] abecedario = new char[5, 5] { {'a', 'b', 'c', 'd', 'e'},
                                                {'f', 'g', 'h', 'i', 'j'},
                                                {'k', 'l', 'm', 'n', 'o'},
                                                {'p', 'q', 'r', 's', 't'},
                                                {'u', 'v', 'w', 'x', 'y'} };


            for (int iPalabra = 0; iPalabra < palabra.Length; iPalabra++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++) 
                    {
                        if (letras[iPalabra] == abecedario[i, j])
                        {
                            Console.WriteLine("{0} {1}", i, j);
                        }
                    }
                }
            }            
        }
    }
}

