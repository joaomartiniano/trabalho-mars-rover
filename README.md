# Trabalho Prático Mars Rover

## Objetivo

Desenvolvimento de um aplicativo de consola com recurso à estrutura de dados ```Queue```, na linguagem C#.

## O problema

Encontra-se na superfície do planeta Marte um veículo de exploração, o Mars Curiosity Rover. Este veículo é controlado remotamente, a partir do planeta Terra.

Dada a quantidade de memória limitada que o veículo possui, e a grande distância a que o planeta Marte se situa da Terra, o veículo é controlado da seguinte forma:
- os controladores (no planeta Terra) enviam um conjunto de comandos para o Rover
- o Rover executa os comandos por ordem de chegada
- após a execução dos comandos, o Rover pode receber novos comandos

Com o projeto C# incompleto que o professor disponibiliza, deverás escrever o código que permita ao Rover receber e executar os comandos enviados pelos controladores da missão.

<img src="">

## Desenvolvimento do Trabalho
- O trabalho é desenvolvido individualmente
- O trabalho consiste na criação de um aplicativo que simula o envio e execução de comandos para um veículo (Rover) que se encontra na superfície de outro planeta (Marte)
- Para tal o professor disponibiliza algum código na forma de um projeto Visual Studio: os alunos deverão completar e, se desejarem, melhorar o código
- Os comandos deverão ficar armazenados numa estrutura do tipo ```Queue``` (fila)
- O aplicativo termina quando o utilizador introduzir o comando **d**
- A classificação máxima a obter pelos alunos depende do esforço: quanto mais complexa for a aplicação, maior a probabilidade de obter uma classificação alta (desde que o aplicativo esteja corretamente desenvolvido e de acordo com os critérios de avaliação)
- Os alunos são encorajados a fazer, com base nestas especificações, aplicativos criativos e com mais funcionalidades (por exemplo: impedir que o rover ultrapasse os limites do ecrã, colocar obstáculos no caminho (obrigando o rover contorná-los), dotar o rover de combustível que vai sendo gasto sempre que se movimenta, etc.)

## Recursos

- O professor disponibiliza, na plataforma YouTube, dois vídeos exemplificativos do funcionamento pretendido bem como uma explicação do código a acrescentar:
    - 1ª parte: https://youtu.be/oadSN_04Lx8
    - 2ª parte: https://youtu.be/AWtGchBb_NM

## Descrição do código disponibilizado pelo professor

É disponibilizado um projeto com 4 ficheiros de código C#:

```Program.cs```

Na classe ```Program```, o método ```Main()``` é responsável por todo o ciclo de vida da aplicação:

- inicializa a aplicação
- recebe e processa o input do utilizador
- termina a aplicação

```Rover.cs```

Contém a classe ```Rover``` e todo o código referente ao veículo no planeta Marte. Permite enviar os comandos e receber feedback. É nesta classe que os alunos deverão acrescentar a maior parte do código.

```Display.cs```

Contém a classe estática ```Display``` (significa que todo o seu código e propriedades são acessíveis diretamente, sem que haja necessidade de criar uma instância da classe).

Esta classe é responsável pelo display de dados, nomeadamente:

- Título da aplicação (método ```DesenharTituloAplicacao()```)
- Pontos cardeais (bússola) (método ```DesenharPontosCardeais()```)
- Lista de comandos (método ```DesenharComandos()```)
- Indicação da quantidade de comandos disponíveis no rover (método ```DesenharStatusRover()```)

```LinhaComandos.cs```

Contém a classe estática ```LinhaComandos```, responsável por mostrar a linha de comandos e por mostrar o feedback do rover.