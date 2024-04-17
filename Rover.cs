using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    /// <summary>
    /// Representa o veículo Mars Rover. Permite interagir com o veículo, através do envio de comandos e receber feedback e informações.
    /// </summary>
    public class Rover
    {
        /// <summary>Número máximo de comandos suportado pelo Rover.</summary>
        public static int MaximoComandos = 6;
        
        /// <summary>Coordenada X da posição do Rover na consola.</summary>
        public int X { get; set; }

        /// <summary>Coordenada Y da posição do Rover na consola.</summary>
        public int Y { get; set; }
        
        /// <summary>Cor de fundo do Rover na consola.</summary>
        public ConsoleColor CorFundo { get; set; }

        // Insira código aqui:
        //  declarar uma queue chamada Comandos com tamanho máximo MaximoComandos

        /// <summary>
        /// Comandos 
        /// </summary>
        public enum Comando
        {
            Nulo,
            Norte,
            Sul,
            Este,
            Oeste
        }

        public enum Feedback
        {
            Nulo,
            Ok,
            ComandoDesconhecido,
            SemCapacidade,
            TerminarLigacao
        }

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="x">Coordenada X do Rover.</param>
        /// <param name="y">Coordenada Y do Rover.</param>
        /// <param name="corFundo">Cor do Rover.</param>
        public Rover(int x, int y, ConsoleColor corFundo = ConsoleColor.White)
        {
            X = x;
            Y = y;
            CorFundo = corFundo;
        }

        /// <summary>
        /// Terminar a ligação ao Rover.
        /// </summary>
        /// <returns>Retorna feedback desta operação.</returns>
        public Feedback TerminarLigacao()
        {
            System.Threading.Thread.Sleep(2000);
            return Feedback.Ok;
        }
        
        /// <summary>
        /// Inserir um comando na memória do Rover para execução posterior.
        /// </summary>
        /// <param name="comando">O comando a inserir.</param>
        /// <returns>Retorna feedback (comando inserido com sucesso ou insucesso) desta operação.</returns>
        public Feedback InserirComando(Comando comando)
        {
            if (Comandos.Count < MaximoComandos)
            {
                // Insira código aqui:
                //  inserir um comando na queue Comandos

                return Feedback.Ok;
            }

            return Feedback.SemCapacidade;
        }

        /// <summary>
        /// Retorna o número de comandos que o Rover pode receber. 
        /// </summary>
        /// <returns>Um número inteiro.</returns>
        public int ComandosDisponiveis()
        {
            return MaximoComandos - Comandos.Count;
        }

        /// <summary>
        /// Executa os comandos armazenados pelo Rover.
        /// </summary>
        /// <returns>Retorna feedback da execução dos comandos.</returns>
        public Feedback ExecutarComandos()
        {
            Console.CursorVisible = false;

            while (Comandos.Count > 0)
            {
                System.Threading.Thread.Sleep(300);
                Desenhar(true);

                // Insira código aqui:
                //  retirar um comando da queue

                switch (comando)
                {
                    case Comando.Norte:
                        Y -= 1;
                        break;

                    case Comando.Sul:
                        Y += 1;
                        break;

                    case Comando.Este:
                        X += 1;
                        break;

                    case Comando.Oeste:
                        X -= 1;
                        break;

                }

                Desenhar();
            }

            Console.CursorVisible = true;

            return Feedback.Ok;
        }

        /// <summary>
        /// Desenhar o Rover na consola.
        /// </summary>
        /// <param name="apagar">Parâmetro opcional que quando tem o valor true faz com o que Rover seja apagado da consola.</param>
        public void Desenhar(bool apagar = false)
        {
            ConsoleColor corFundoAtual = Console.BackgroundColor;

            Console.BackgroundColor = (apagar) ? ConsoleColor.Black : CorFundo;

            Console.SetCursorPosition(X + 1, Y);
            Console.Write("  ");
            Console.SetCursorPosition(X + 1, Y + 1);
            Console.Write("  ");

            Console.BackgroundColor = corFundoAtual;
        }
    }
}
