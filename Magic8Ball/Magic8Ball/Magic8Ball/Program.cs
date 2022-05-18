using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Esta funcion es llamada desde el intante que la aplicacion es lanzada
        BeginGame:
            Console.WriteLine("Bienvenidos a la Bola Magica 8!");

            ConsoleColor PreGameColor = Console.ForegroundColor;
        AskQuestion:
            Console.Write("\nHaz una pregunta!:>");
            string response = Console.ReadLine();
            RandomizeConsoleOutputColor();
            GetResponse();
            ResetConsoleColours(PreGameColor);

            Console.WriteLine("___");
            goto AskQuestion;

        }

        static void ResetConsoleColours(ConsoleColor PreGame)
        {
            Console.ForegroundColor = PreGame;
        }


        static void GetResponse()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(1, 20);
            switch (result)
            {
                case 1:
                    Console.WriteLine("Como yo lo veo, sí");
                    break;
                case 2:
                    Console.WriteLine("Vuelve a preguntar más tarde");
                    break;
                case 3:
                    Console.WriteLine("Mejor no te lo digo ahora");
                    break;
                case 4:
                    Console.WriteLine("No puedo adivinar nombres ahora");
                    break;
                case 5:
                    Console.WriteLine("Concéntrese y pregunte de nuevo");
                    break;
                case 6:
                    Console.WriteLine("No cuentes con ello");
                    break;
                case 7:
                    Console.WriteLine("Es seguro");
                    break;
                case 8:
                    Console.WriteLine("Es decididamente así");
                    break;
                case 9:
                    Console.WriteLine("Lo más probable");
                    break;
                case 10:
                    Console.WriteLine("Mi respuesta es no");
                    break;
                case 11:
                    Console.WriteLine("Mis fuentes dicen que no");
                    break;
                case 12:
                    Console.WriteLine("Las perspectivas no son tan buenas");
                    break;
                case 13:
                    Console.WriteLine("Perspectiva buena");
                    break;
                case 14:
                    Console.WriteLine("La respuesta es confusa, inténtelo de nuevo");
                    break;
                case 15:
                    Console.WriteLine("Los signos apuntan a que sí");
                    break;
                case 16:
                    Console.WriteLine("Muy dudoso");
                    break;
                case 17:
                    Console.WriteLine("Sin duda");
                    break;
                case 18:
                    Console.WriteLine("Sí");
                    break;
                case 19:
                    Console.WriteLine("Sí definitivamente");
                    break;
                case 20:
                    Console.WriteLine("Puede confiar en ello");
                    break;

            }
        }

        private static void Next(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        static void RandomizeConsoleOutputColor()
        {
            int result;
            Random rnd = new Random();// Este es un nuevo Generador de Numeros
            result = rnd.Next(1,5);
            switch (result)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;


            }
        }
    }
}
