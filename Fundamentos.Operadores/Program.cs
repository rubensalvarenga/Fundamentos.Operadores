using System;
using System.Runtime.CompilerServices;

namespace Fundamentos.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Conversão e Operadores Aritméticos");
            Console.WriteLine("==================================");

            Console.WriteLine("");
            Console.WriteLine("");

            int inteiro = 100;
            float real = 25.8f;

            real = inteiro;
            inteiro = (int)real;
            string valorReal = real.ToString();
            inteiro = int.Parse(valorReal);
            inteiro = Convert.ToInt32(real);


            Console.WriteLine(real);
            Console.WriteLine(inteiro);
            Console.WriteLine(valorReal);
            Console.WriteLine(Convert.ToBoolean(255)); // conversão sempre qq numero é true

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Operadores Aritméticos");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            int soma = 25 + 22;
            int subtracao = 25 - 12;
            int divisao = 356 / 12;
            int multiplicacao = 4534 * 2;

            Console.WriteLine( "Operadores : " );
            Console.WriteLine("-----------------------");

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(divisao);
            Console.WriteLine(multiplicacao);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Regras dos parenteses");
            Console.WriteLine("-----------------------");

            int x = 2 + 2 * 2;
            int y = 2 + (2 * 2);
            int z = (2 + 2) * 2;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Operações de Atribuição");
            Console.WriteLine("-----------------------");

            Console.WriteLine("");


            x += 5; // x = x + 5;
            x -= 5; // x = x - 5;
            x *= 10; // x = x * 10;
            x /= 2; // x = x / 2;

            Console.WriteLine(x);


            Console.WriteLine("Operadores de Comparação");
            Console.WriteLine("-----------------------");

            Console.WriteLine("");

            int a = 2;
            int b = 10;
            
            if ( a > b)  Console.WriteLine("A é maior que b");
            if ( a < b) Console.WriteLine("A é menor que b");
            if ( a <= b) Console.WriteLine("A é menor ou igual que b");
            if (a >= b) Console.WriteLine("A é maior ou igual que b");

            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Operadores de Aribuição");
            Console.WriteLine("-----------------------");
            
            Console.WriteLine("");

            int xx = 2;
            xx--;
            xx++;

            Console.WriteLine( xx == 25);
            Console.WriteLine(xx != 25);
            Console.WriteLine(xx > 25);
            Console.WriteLine(xx < 25);


            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Operadores de Lógicos");
            Console.WriteLine("-----------------------");

            Console.WriteLine("");
            Console.WriteLine("");

            int logico = 12;

            if (logico > 25 && logico < 40) Console.WriteLine(" Uso do E &&");
            if (logico > 25 || logico < 40) Console.WriteLine(" Uso do ou ||");
            if (logico != 25) Console.WriteLine(" Uso da negação");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Operador IF");
            Console.WriteLine("-----------------------");

            Console.WriteLine("");
            Console.WriteLine("");

            int idade = 18;
            int maioridade = 21;

            if (idade >= maioridade && idade < 65) Console.WriteLine("Atingiu a maioridade");
            else Console.WriteLine("Não é");
        }
    }
}
