using System;

namespace Exercicio1
{
    class Program
    {
 //========================================================================================================
        public static void ex_03()
        // Crie um programa que solicite duas notas e calcule a média do aluno.
        {
            double nota1, nota2, media;

            Console.WriteLine("exercício 3\nInsira a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine("a média é: " + media + "\n");
        }
//========================================================================================================
        public static void ex_04()
        /*Crie um programa que solicite duas notas do aluno,
        calcule a média e informe se o aluno está "aprovado"
        ou "reprovado" (média 6.0)*/
        {
            double nota1, nota2, media;

            Console.WriteLine("exercício 4\nInsira a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine("a média é: " + media + "\n");

            if (media <= 6)
            {
                Console.WriteLine("Você está reprovado!\n");
            }
            else
            {
                Console.WriteLine("Você está aprovado!\n");
            }
        }
        //========================================================================================================
        public static void ex_05() {
            
            double nota1, nota2, nota3, total;

            Console.WriteLine("exercício 5\nInsira a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInsira a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInsira a terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());

            if (nota1 < nota2 && nota1 < nota3) {
                total = (nota2 + nota3)/2;
                Console.WriteLine("A nota é: " + total + "\n");
            }
            else if(nota2 < nota1 && nota2 < nota3)
            {
                total = (nota1 + nota3)/2;
                Console.WriteLine("A nota é: " + total + "\n");
            }
            else if(nota3 < nota2 && nota3 < nota1)
            {
                total = (nota2 + nota1)/2;
                Console.WriteLine("A nota é: " + total + "\n");

            }
        }/*Crie um programa que solicite 3 notas do aluno
            (Av1, Av2, Av3), descarte a menor nota e exiba
            a média do aluno, informando se o mesmo foi
            aprovado ou não.*/
        //========================================================================================================
        public static void ex_06() {
            
            double numero;

            Console.WriteLine("Informe o número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if(numero <= 0)
            {
                Console.WriteLine("O seu numero é negativo\n");
            }else{
                Console.WriteLine("O seu numero é positivo\n");
            }


        }/*Crie um programa que solicita um número e
            informa se ele é positivo ou negativo.*/
        //========================================================================================================
        public static void ex_07() {
            
            double ano, idade;

            Console.WriteLine("Informe o ano de nascimento: ");
            ano = Convert.ToDouble(Console.ReadLine());

            idade = 2021 - ano;
            Console.WriteLine("\na sua idade é " + idade + "\n");
        }/*Crie um programa que solicita o ano de nascimento do usuário e
          * informe a sua idade.*/
        //========================================================================================================
        public static void ex_08()
        {
            
            double ano, idade;

            Console.WriteLine("Informe a sua idade: ");
            idade = Convert.ToDouble(Console.ReadLine());

            ano = 2021 - idade;
            Console.WriteLine("o seu ano de nascimento é " + ano + "\n");
        }//Crie um programa que solicita a sua idade e informe o seu ano de nascimento.
        //========================================================================================================
        public static void ex_09() {

            

            double ano, idade, n;

            Console.WriteLine("Informe um valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n is > 100 and < 2200)
            {
                idade = 2021 - n;
                Console.WriteLine("a sua idade é " + idade + "\n");
            }
            else if (n is > 0 and < 100)
            {
                ano = 2021 - n;
                Console.WriteLine("o seu ano de nascimento é " + ano + "\n");
            }
        }/*Crie um programa que solicita um valor ao usuário
            (idade ou ano de nascimento) e informe a sua idade
            ou a sua data de nascimento.*/
        //========================================================================================================
        public static void ex_10() {
            
            double n;

            Console.WriteLine("informe o numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0){
                Console.WriteLine("par\n");
            }
            else if (n % 2 != 0){
                Console.WriteLine("ímpar\n");
            }
        }/*Criar um programa que solicite um numero
            do usuário e diga se ele é par ou ímpar.*/
        //========================================================================================================
        public static void ex_11()
        {
            
            double player, n, x;
            string parouimpar;

            n = 0;
            Console.WriteLine("Escolha par ou ímpar: ");
            parouimpar = Console.ReadLine();
            if (parouimpar == "impar")
            {
                n = 1;
            }
            else if (parouimpar == "par")
            {
                n = 2;
            }
            else if (parouimpar != "impar" && parouimpar != "par")
            {
            ex_11();
            return;
            }

            Console.WriteLine("\nEscolha um numero de 1 a 5: ");
            player = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
            var pc = rand.Next(6);

            if ((player + pc) % 2 == n % 2)
            {
                Console.WriteLine("\nO computador escolheu " + pc + ", você ganhou!\n");
            }
            else if((player + pc) % 2 != n % 2)
            {
                Console.WriteLine("\nO computador escolheu " + pc + ", você perdeu! Que pena\n");
            }
            else
            {
                Environment.Exit(0);
            }
        }/*Criar um programa que solicite o usuário escolher entre par ou ímpar,
            escolher um número, sortear um valor ao computador e verificar quem
            ganhou no par ou ímpar.*/
        //========================================================================================================
        public static void ex_12()
        {
            
            double player, n;
            string parouimpar;

            n = 0;

            Console.WriteLine("Escolha par ou ímpar: ");
            parouimpar = Console.ReadLine();
            if (parouimpar == "impar")
            {
                n = 1;
            }
            else if (parouimpar == "par")
            {
                n = 2;
            }
            else if (parouimpar != "impar" && parouimpar != "par")
            {
                ex_12();
                return;
            }

            Console.WriteLine("\nEscolha um numero de 1 a 5: ");
            player = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
            var pc   = rand.Next(5);

            if ((player + pc) % 2 == n % 2)
            {
                Console.WriteLine("\nO computador escolheu " + (pc + 1) + ", você perdeu! Que pena\n");
            }
            else if ((player + pc) % 2 != n % 2)
            {
                Console.WriteLine("\nO computador escolheu " + pc + ", você perdeu! Que pena\n");
            }
            else
            {
                Environment.Exit(0);
            }
        }/*Criar um programa que solicite o usuário escolher entre par ou ímpar,
          escolher um número, sortear um valor ao computador e verificar quem ganhou no par ou ímpar.
          Agora o computador deve sempre GANHAR!*/
        //========================================================================================================
        public static void ex_13()
        //Crie um programa que solicita um valor em metros e converta para centímetros.
        {
            double a;

            Console.WriteLine("Insira o valor em metros: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor inserido em centímetros é " + (a*100) + " cm.\n");
        }
        //========================================================================================================
        public static void ex_14()
        //Crie um programa que solicita ao usuário o raio de um círculo e calcule a sua área. ( A = pi.r² )
        {
            double raio, a;
            
            Console.WriteLine("insira o raio:");
            raio = double.Parse(Console.ReadLine());
            a = 3.141592 * (raio * raio);
            Console.WriteLine("A área do seu círculo é " + a + "\n");
        }
        //========================================================================================================
        public static void ex_15()
        /*Crie um programa que solicita ao usuário o valor da hora trabalhada, quantas horas trabalhou
        no mês e calcule o valor a receber no final do mês.*/
        {
            double valorHT, tempoHT, dinheiro;

            Console.WriteLine("insira o valor da hora trabalhada: ");
            valorHT = double.Parse(Console.ReadLine());

            Console.WriteLine("\ninsira a quantidade de horas trabalhadas no mês: ");
            tempoHT = double.Parse(Console.ReadLine());

            dinheiro = tempoHT * valorHT;
            Console.WriteLine("\nO valor a ser recebido é de " + dinheiro + "R$ no fim do mês.\n");
        }
        //========================================================================================================
        public static void ex_16()
        /*Crie um programa que solicita uma temperatura
        em graus Fahrenheit e converta e informe a temperatura em graus Celsius.*/
        {
            int Fah, Cel;

            Console.WriteLine("Insira a temperatura em graus Fahrenheit: ");
            Fah = Int32.Parse(Console.ReadLine());

            Cel = (int)((Fah - 32) / 1.8);
            Console.WriteLine("A temperatura em graus Celsius é de " + Cel + "ºC.\n");
        }
        //========================================================================================================
        public static void ex_17()
        //Crie um programa que solicita o peso e a altura de um
        //usuário e informe o seu IMC (Índice de massa corpórea) IMC = Peso/(Altura*altura)
        {
            double Peso, Altura, IMC;

            Console.WriteLine("Insira seu peso: ");
            Peso =  Double.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira sua altura: ");
            Altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nSeu IMC é de: " + Math.Round((Peso / (Altura * Altura)), 2).ToString() + ".\n");
        }
        //========================================================================================================
        public static void ex_18()
        /* Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.
           Calcule e mostre o total do seu salário no referido mês, sabendo que deve ser descontado 8 %
           para o INSS, faça um programa que nos dê:

        a) Salário bruto.
        b) Quanto pagou ao INSS.
        d) O salário líquido.
        + Salário Bruto: R$
        -INSS(8 %) : R$
        = Salário Liquido: R$ */

        {
            int valorHT, tempoHT;

            Console.WriteLine("insira o valor da hora trabalhada: ");
            valorHT = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\ninsira a quantidade de horas trabalhadas no mês: ");
            tempoHT = Int32.Parse(Console.ReadLine());

            //Resposta a)
            Console.WriteLine("\nO seu salário bruto é " + (valorHT * tempoHT) + "R$.");

            //Resposta b)
            Console.WriteLine("\nO valor pago ao INSS é de " + (0.08*(valorHT * tempoHT)) + "R$.");

            //Resposta c)
            Console.WriteLine("\nO seu salário líquido é de " + ((valorHT * tempoHT) - 0.08 * (valorHT * tempoHT)) + "R$.\n");

        }
        //========================================================================================================
        public static void ex_19()
        //Crie um programa para calcular o consumo médio de um automóvel,
        //solicite ao usuário uma distância percorrida em KM e o total de combustível
        //consumido, em litros.
        {
            double distancia, combustivel, MediaConsumo;

            Console.WriteLine("Informe a distância percorrida em KM: ");
            distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o combustível consumido em litros: ");
            combustivel = Math.Round(double.Parse(Console.ReadLine()),2);

            MediaConsumo = (distancia/combustivel);
            Console.WriteLine("O consumo médio em litros é de " + MediaConsumo + " litros.\n");

        }
        //========================================================================================================
        public static void ex_20()
        //Crie um programa que solicita a um vendedor o seu salário
        //fixo e o valor total de suas vendas no mês.Sabendo que a
        //sua comissão é de 15%, calcule o salário a receber no final do mês.
        {
            double salarioFixo, valorTotalVendasMes, comissao, salarioMes;

            Console.WriteLine("Informe seu salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total de suas vendas no mês: ");
            valorTotalVendasMes = double.Parse(Console.ReadLine());

            comissao = 0.15 * (valorTotalVendasMes + salarioFixo);

            salarioMes = salarioFixo + valorTotalVendasMes + comissao;
            Console.WriteLine("O seu salario mensal é de " + salarioMes + "R$.\n");
        }
        public static void Main(string[] args)
        {
            int prog;

            Console.WriteLine("Solicite o numero da questão a ser executada:\n" +
                "de 3 a 20 executa a questão (Porque eu comecei da 3 kkk)\n" +
                "0 para sair ");
            prog = Convert.ToInt32(Console.ReadLine());

            switch(prog){
                default:
                    Console.WriteLine("Questão não disponível");
                    Console.ReadLine();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                case 3:
                    Console.Clear();
                    Program.ex_03();
                    break;
                case 4:
                    Console.Clear();
                    Program.ex_04();
                    break;
                case 5:
                    Console.Clear();
                    Program.ex_05();
                    break;
                case 6:
                    Console.Clear();
                    Program.ex_06();
                    break;
                case 7:
                    Console.Clear();
                    Program.ex_07();
                    break;
                case 8:
                    Console.Clear();
                    Program.ex_08();
                    break;
                case 9:
                    Console.Clear();
                    Program.ex_09();
                    break;
                case 10:
                    Console.Clear();
                    Program.ex_10();
                    break;
                case 11:
                    Console.Clear();
                    Program.ex_11();
                    break;
                case 12:
                    Console.Clear();
                    Program.ex_12();
                    break;
                case 13:
                    Console.Clear();
                    Program.ex_13();
                    break;
                case 14:
                    Console.Clear();
                    Program.ex_14();
                    break;
                case 15:
                    Console.Clear();
                    Program.ex_15();
                    break;
                case 16:
                    Console.Clear();
                    Program.ex_16();
                    break;
                case 17:
                    Console.Clear();
                    Program.ex_17();
                    break;
                case 18:
                    Console.Clear();
                    Program.ex_18();
                    break;
                case 19:
                    Console.Clear();
                    Program.ex_19();
                    break;
                case 20:
                    Console.Clear();
                    Program.ex_20();
                    break;

            }
        }//===================    RESULTADOS    ==========================
    }
    
}
