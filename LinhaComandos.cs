using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MarsRover
{
    /// <summary>
    /// Responsável pela linha de comandos e mostrar feedback do Rover.
    /// </summary>
    public static class LinhaComandos
    {
        // Coordenadas da linha de comandos
        private static int X = 0;
        private static int Y = 25;
        private static int Largura = Console.WindowWidth - 20;
        private static int Altura = 4;

        private static int PromptX = X;
        private static int PromptY = Y;
        
        // Coordenadas do feedback do Rover
        private static int FeedbackX = X;
        private static int FeedbackY = Y + 3;

        /// <summary>
        /// Mostrar a prompt da linha de comandos.
        /// </summary>
        public static void DesenharPrompt()
        {
            // Apagar comando anterior
            for (int x = PromptX; x < X + Largura - 1; ++x)
            {
                Console.SetCursorPosition(x, PromptY + 1);
                Console.Write(" ");
            }

            Console.SetCursorPosition(PromptX, PromptY);
            Console.WriteLine("Mars Rover pronto a receber comandos:");
            Console.Write("> ");
        }

        /// <summary>
        /// Mostrar o feedback do Rover.
        /// </summary>
        /// <param name="feedbackRover">O código do feedback a mostrar.</param>
        public static void MostrarFeedbackRover(Rover.Feedback feedbackRover)
        {
            ConsoleColor cor = Console.ForegroundColor;

            // Apagar feedback anterior
            for (int x = FeedbackX; x < X + Largura - 1; ++x)
            {
                Console.SetCursorPosition(x, FeedbackY);
                Console.Write(" ");
            }

            Console.SetCursorPosition(FeedbackX, FeedbackY);
            Console.Write("Rover feedback: ");

            Console.SetCursorPosition(FeedbackX + 16, FeedbackY);

            // Mostrar feedback
            switch (feedbackRover)
            {               
                case Rover.Feedback.Ok:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("OK");
                    break;

                case Rover.Feedback.SemCapacidade:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Memória esgotada");
                    break;

                case Rover.Feedback.ComandoDesconhecido:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Comando desconhecido");
                    break;

                case Rover.Feedback.TerminarLigacao:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("A terminar a ligação...");
                    break;
            }

            Console.ForegroundColor = cor;
        }
    }
}
