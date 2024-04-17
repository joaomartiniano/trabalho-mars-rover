using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização da aplicação
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Mars Rover";
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;

            // Desenhar componentes do interface
            Display.DesenharTituloAplicacao();
            Display.DesenharPontosCardeais();
            Display.DesenharSeparador();
            Display.DesenharComandos();

            // Criar Rover
            Rover rover1 = new Rover(10, 10);
            Rover.Feedback feedbackRover = Rover.Feedback.Nulo;

            // Insira código aqui:
            //  desenhar o rover (veja a classe Rover)

            string s;

            do
            {
                // Desenhar status do Rover
                Display.DesenharStatusRover(rover1.ComandosDisponiveis());

                // Desenhar a prompt na linha de comandos
                LinhaComandos.DesenharPrompt();

                // Obter comandos do utilizador
                Console.CursorVisible = true;
                s = Console.ReadLine().ToLower();

                // Processar comandos
                switch (s)
                {
                    case "d": // Terminar a aplicação
                        LinhaComandos.MostrarFeedbackRover(Rover.Feedback.TerminarLigacao);

                        if (rover1.TerminarLigacao() == Rover.Feedback.Ok)
                        {
                            // Insira código aqui:
                            //  terminar a aplicação
                        }

                        break;

                    case "n": // Norte

                        // Insira código aqui:
                        //  o parâmetro deve ter o comando Norte (veja a enumeração Comando na classe Rover)
                        feedbackRover = rover1.InserirComando(Rover.Comando.Nulo);

                        break;

                    case "e": // Este

                        // Insira código aqui:
                        //  o parâmetro deve ter o comando Este (veja a enumeração Comando na classe Rover)
                        feedbackRover = rover1.InserirComando(Rover.Comando.Nulo);

                        break;

                    case "o": // Oeste

                        // Insira código aqui:
                        //  o parâmetro deve ter o comando Oeste (veja a enumeração Comando na classe Rover)
                        feedbackRover = rover1.InserirComando(Rover.Comando.Nulo);

                        break;

                    case "s": // Sul

                        // Insira código aqui:
                        //  o parâmetro deve ter o comando Sul (veja a enumeração Comando na classe Rover)
                        feedbackRover = rover1.InserirComando(Rover.Comando.Nulo);

                        break;

                    case "x": // Executar comandos armazenados na memória do Rover

                        // Insira código aqui:
                        //  retire o comentário da instrução seguinte
                        //  executar comandos no Rover (veja a classe Rover para descobrir o método apropriado)
                        
                        //feedbackRover = (completar);

                        break;

                    default: // Comando desconhecido
                        feedbackRover = Rover.Feedback.ComandoDesconhecido;
                        break;
                }

                // Mostrar feedback do Rover ao comando inserido
                LinhaComandos.MostrarFeedbackRover(feedbackRover);

            } while (1 == 1);
        }
    }
}
