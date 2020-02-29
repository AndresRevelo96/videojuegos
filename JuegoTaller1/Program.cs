using System;

namespace CJuegoTaller1
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {

            Console.WriteLine("\nSeleccionar el numero de jugadores 2 o 4");
            string plyrs = Console.ReadLine();

            if (!plyrs.Equals("")) 
            {
                int numplayer = int.Parse(plyrs);

                while ( numplayer > 4 || numplayer < 2)
                {
                    Console.WriteLine("\nSeleccionar el numero de jugadores 2 o 4");
                    plyrs = Console.ReadLine();
                }

                Console.WriteLine("\nSeleccionar tablero");
                Console.WriteLine("1. Nivel básico (20)");
                Console.WriteLine("2. Nivel intermedio (30)");
                Console.WriteLine("3. Nivel avanzado (50)");
                String board = Console.ReadLine();

                if (!board.Equals(""))
                {
                    while (!board.Equals("1")&& !board.Equals("2")&& !board.Equals("3"))
                    {
                        Console.WriteLine("\nSeleccionar tablero");
                        Console.WriteLine("1. Nivel básico (20)");
                        Console.WriteLine("2. Nivel intermedio (30)");
                        Console.WriteLine("3. Nivel avanzado (50)");
                        board = Console.ReadLine();
                    }                   
                }

                int r = 0;
                switch (board)
                {
                    case "1":
                        r = 20;
                        break;
                    case "2":
                        r = 30;
                        break;
                    case "3":
                        r = 50;
                        break;
                    default:
                        Console.WriteLine("ERROR, no se encontro el tablero");
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine("Presiona enter para comenzar");
                Console.ReadKey();
               

                int[] scores = new int[numplayer];
                int[] par = new int[numplayer];
                int i = 0;

                while (scores[i] < r || par[i] == 3)
                {

                    Console.WriteLine("\nJugador "+(i+1)+ " enter para lanzar los dados");
                    Console.ReadKey();

                    int dice1 = new Random().Next(1, 7);
                    int dice2 = new Random().Next(1, 7);

                    if (dice1 == dice2)
                    {
                        par[i]++;
                    }
                    else
                    {
                        par[i] = 0;
                    }

                    scores[i] += dice1 + dice2;
                    Console.WriteLine("\nPosicion: " + scores[i]);

                 

         

                    if (scores[i] < r)
                    {
                        i++;
                    }

                    if (i == scores.Length)
                    {
                        i = 0;
                    }                   
                }

                Console.WriteLine("Felicidades jugador "+(i+1)+" ¡GANASTE! \n");
                Console.WriteLine("¿Quieres volver a jugar?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                string opagain = Console.ReadLine();
                if (!opagain.Equals(""))
                {
                    while (!opagain.Equals("1") && !opagain.Equals("2"))
                    {
                        Console.WriteLine("¿Jugar de nuevo?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                    }
                    if (opagain.Equals("1"))
                    {
                        start();
                    }
                    else if (opagain.Equals("2"))
                    {

                    }
                }
            }
        }
    }
}
