using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    /// <summary>
    /// Esta classe é responsável por efetuar display de dados.
    /// </summary>
    public static class Display
    {
        // Coordenadas da área reservada ao display de dados
        private static int X = Console.WindowWidth - 19;
        private static int Y = 0;

        // Coordenadas dos pontos cardeais (bússola)
        private static int BussolaX = X + ((Console.WindowWidth - (X + 1)) / 2);
        private static int BussolaY = Y + 1;

        // Coordenadas da área onde são mostrados os comandos do Rover
        private static int ComandosX = X + 2;
        private static int ComandosY = Y + 8;

        // Coordenadas da área onde é mostrado o status do Rover
        private static int StatusRoverX = X + 2;
        private static int StatusRoverY = Y + 17;

        /// <summary>
        /// Desenhar o título da aplicação.
        /// </summary>
        public static void DesenharTituloAplicacao()
        {
            ConsoleColor cor = Console.ForegroundColor;

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;

            // Insira código aqui:
            //  escrever o título da aplicação na consola ("Mars Rover - Consola de Comando e Controlo")

            Console.ForegroundColor = cor;
        }

        /// <summary>
        /// Desenhar linha separadora que delimita a área do display.
        /// </summary>
        public static void DesenharSeparador()
        {
            for (int i = 0; i < Console.WindowHeight; ++i)
            {
                Console.SetCursorPosition(X, i);
                Console.Write("\u2502");
            }
        }

        /// <summary>
        /// Desenhar os pontos cardeais (bússola).
        /// </summary>
        public static void DesenharPontosCardeais()
        {
            Console.SetCursorPosition(BussolaX, BussolaY);
            Console.Write("N");
            Console.SetCursorPosition(BussolaX - 2, BussolaY + 2);
            Console.Write("O");
            Console.SetCursorPosition(BussolaX + 2, BussolaY + 2);
            Console.Write("E");
            Console.SetCursorPosition(BussolaX, BussolaY + 4);
            Console.Write("S");

            Console.SetCursorPosition(BussolaX, BussolaY + 1);
            Console.Write("\u2502");
            Console.SetCursorPosition(BussolaX, BussolaY + 2);
            Console.Write("\u2502");
            Console.SetCursorPosition(BussolaX, BussolaY + 3);
            Console.Write("\u2502");
            Console.SetCursorPosition(BussolaX - 1, BussolaY + 2);
            Console.Write("\u2500\u253C\u2500");
        }

        /// <summary>
        /// Mostrar os comandos do Rover, disponíveis para o utilizador.
        /// </summary>
        public static void DesenharComandos()
        {
            Console.SetCursorPosition(ComandosX, ComandosY);
            Console.Write("Comandos:");
            Console.SetCursorPosition(ComandosX, ComandosY + 2);
            Console.Write("N = Norte");
            Console.SetCursorPosition(ComandosX, ComandosY + 3);
            Console.Write("E = Este");
            Console.SetCursorPosition(ComandosX, ComandosY + 4);
            Console.Write("O = Oeste");
            Console.SetCursorPosition(ComandosX, ComandosY + 5);
            Console.Write("S = Sul");
            Console.SetCursorPosition(ComandosX, ComandosY + 6);
            Console.Write("X = Executar");
            Console.SetCursorPosition(ComandosX, ComandosY + 7);
            Console.Write("D = Terminar");
        }

        /// <summary>
        /// Mostrar o estado (status) do Rover.
        /// </summary>
        /// <param name="comandosDisponiveis">Quantidade de comandos disponíveis para inserir no Rover.</param>
        public static void DesenharStatusRover(int comandosDisponiveis)
        {
            Console.SetCursorPosition(StatusRoverX, StatusRoverY);
            Console.Write("Status Rover:");

            Console.SetCursorPosition(StatusRoverX, StatusRoverY + 2);
            Console.Write(comandosDisponiveis);
            Console.SetCursorPosition(StatusRoverX, StatusRoverY + 3);
            Console.Write("disponíveis");
        }
    }
}
