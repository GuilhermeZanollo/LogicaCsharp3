using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Fazer um programa que leia numeros inteiros ate que um zero seja lido. Ao final mostra a soma dos números lidos
            int soma = 0;
      
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            */

            /* Crescente e Decrescente
            // URI 1113

            string[] values = Console.ReadLine().Split(' ');
            int X = int.Parse(values[0]);
            int Y = int.Parse(values[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                values = Console.ReadLine().Split(' '); // ADICIONO NOVAMENTE AS VARIAVEIS POIS CASO NAO ADICIONE, O PROGRAMA FECHA;
                X = int.Parse(values[0]);
                Y = int.Parse(values[1]);
            }
            */

            /*
            // Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um individuo. O último dado,
            que não entrará nos calculos, contem um valor de idade negativa. Calcular e imprimir a idade média deste grupo de individuos.
            Se for entrado um valor negativo na primeira vez, mostra a mensagem "impossivel calcular".

            double soma, media;
            int cont; // contar quantas idade foram dado entrada

            double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {
                soma = soma + idade; // Calculando a soma das idades 
                cont = cont + 1; // Calculo de pessoas
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            }
            media = soma / cont; // Calculando a idade média do grupo de individuos
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            // URI 1071

            Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

            Entrada
            O arquivo de entrada contém dois valores inteiros.

            Saída
            O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre os valores fornecidos 
            na entrada que deverá caber em um inteiro.

            
            int soma, min, max;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                min = X;
                max = Y;
            } 
            else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for (int i=min+1; i<max; i++)
            {
                if (i % 2 != 0) // se for impar o numero entra na soma
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
            */

            /*
            // Problema exemplo "faça enquanto" "do while":
            Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em fahrenheit. Perguntar se o usuário deseja repetir
            (s/n). Caso o usuário digite "s", repetir o programa.

            Fórmula: F = 9C / 5 + 32

            EXEMPLO:
            Digite a temperatura em Celsius: 30.0
            Equivalente em Fahrenheit: 86.0
            Deseja repetir (s/n)? s
            Digite a temperatura em Celsius: 21.0
            Equivalente em Fahrenheit: 69.8
            Deseja repetir (s/n)? s
            Digite a temperatura em Celsius: -10.5
            Equivalente em Fahrenheit: 13.1
            Deseja repetir (s/n)? n

            double fah;
            char repetir = 's';
  
            while (repetir == 's') {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                double cel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fah = 9.0 * cel / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + fah.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)");
                repetir = char.Parse(Console.ReadLine());
            }
            */

            // Exercicios URI a FAZER: 1067, 1072, 1073, 1074, 1075, 1079, 1080, 1094, 1096, 1097, 1116, 1132, 1133, 1142, 1143, 1144,
            // 1151, 1153, 1155, 1156, 1157
            // MAIS DIFICEIS: 1099, 1101, 1145, 1149, 1150

        }
    }
}