using System;

namespace primeira_aula
{
    class Program
    {
        static void xUm()
        {
            Console.WriteLine("Crescente:");

            for (int i=1; i<=10; i++)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nDecrescente:");

             for (int i=10; i>=1; i--)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nCrescente sem pares:");
            
            for (int i=1; i<=10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
        
        static void xDois()
        {
            int count = 0;
            for (int i=1; i<=100; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        static void xTres()
        {
            for (int i=1; i<200; i++)
            {
                if (i%2!=0) {Console.Write(i+" ");}
            }
        }

        static void xQuatro()
        {
            string userInput = null;
            double counter = 0;
            double sum = 0;
            double ageInput = 0;
            
            Console.WriteLine("Insira as idades dos alunos, quando terminar insira 0:");
            
            while (userInput != "0")
            {
                userInput = Console.ReadLine();
                bool isAge = Double.TryParse(userInput, out ageInput);
                if (!isAge)
                {
                    Console.WriteLine("ERRO, insira um número inteiro.");
                    continue;
                }
                sum += ageInput;
                counter++;
            }
            Console.WriteLine($"A média de idade dos {counter-1} alunos é {(sum/(counter-1)).ToString("F")}.");
        }

        static void xCinco()
        {
            int[] idades = new int[5];
            string[] nomes = new string[5];
            string[] nomesNaFaixa = new string[5];

            for (int i=0; i<5; i++)
            {
                System.Console.WriteLine($"Nome da Mulher {i+1}:");
                nomes[i] = Console.ReadLine();
                System.Console.WriteLine($"Idade da Mulher {i+1}:");
                idades[i] = Int32.Parse(Console.ReadLine());
            }
            int naFaixa = 0;
            for (int i=0; i<5; i++)
            {
                if (idades[i] < 36 && idades[i] > 17)
                {
                    naFaixa++;
                    nomesNaFaixa[i] = nomes[i];
                }
            }
            Console.WriteLine($"{naFaixa*20}% das mulheres estão na faixa entre 18 e 35 anos:");
            foreach (var name in nomesNaFaixa)
            {
                if (!String.IsNullOrEmpty(name))
                {Console.Write(name+" ");}
            }
        }

        static void xSeis()
        {
            string candidato1 = "";
            string candidato2 = "";
            double votos1 = 0.0;
            double votos2 = 0.0;
          
          menu:
            Console.WriteLine("Digite C para CADASTRAR, V para VOTAR, ou A para apurar:");
            var menuInput = Console.ReadLine();
            if (menuInput == "C") {
                goto modoCadastro;
            } else if (menuInput == "V") {
                goto modoVoto;
            } else if (menuInput == "A") {
                goto modoApura;
            } else {
                Console.WriteLine("ERRO");
                goto menu;
            };
          
          modoCadastro:
            if (candidato1 != "")
            {
                Console.WriteLine("CANDIDATOS JÁ REGISTRADOS");
                goto menu;
            }
            
            Console.WriteLine("Insira a Senha:");
            if (Console.ReadLine() != "Pa$$w0rd")
            {
                Console.WriteLine("SENHA INCORRETA");
                goto modoCadastro;
            }
            Console.WriteLine("Insira o nome do candidato 1:");
            candidato1 = Console.ReadLine();
            Console.WriteLine("Insira o nome do candidato 2:");
            candidato2 = Console.ReadLine();
            Console.WriteLine("CADASTRO COMPLETO");
            goto menu;

          modoVoto:
            if (candidato1 == "" || candidato2 == "")
            {
                Console.WriteLine("CANDIDATOS NÃO CADASTRADOS");
                goto menu;
            }
            Console.WriteLine($"Digite 1 para votar em {candidato1}, ou digite 2 para votar em {candidato2}:");
            var userVote = Console.ReadLine();
            if (userVote == "1") { votos1++; }
            else if(userVote == "2") { votos2++; }
            else {
                Console.WriteLine("ERRO");
                goto modoVoto;
            }
            Console.WriteLine("VOTO CONTABILIZADO");
            Console.Beep();
            goto menu;

          modoApura:
            Console.WriteLine("Insira a Senha:");
            if (Console.ReadLine() != "Pa$$w0rd")
            {
                Console.WriteLine("SENHA INCORRETA");
                goto modoApura;
            }
            
            if (candidato1 == "" || candidato2 == "")
            {
                Console.WriteLine("CANDIDATOS NÃO CADASTRADOS");
                goto menu;
            }
            
            if (votos1>votos2) 
            { 
                Console.WriteLine($"{candidato1} venceu de {votos1} a {votos2} com {(votos1*(100/(votos1+votos2))).ToString("F")}% dos votos!");
            }
            else if (votos2>votos1)
            {
                Console.WriteLine($"{candidato2} venceu de {votos2} a {votos1} com {(votos2*(100/(votos1+votos2))).ToString("F")}% dos votos!");
            }
            else if (votos1 == 0 && votos2 == 0)
            {
                Console.WriteLine("NENHUM VOTO REGISTRADO");
                goto menu;
            }
            else
            {
                Console.WriteLine("SEGUNDO TURNO!");
            }
        }

        static void xSete()
        {
            int cigDia = 0;
            int anos = 0;
            double preco = 0.00;
            
            Console.WriteLine("Quantos cigarros são fumados por dia?");
            cigDia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantos anos fumando?");
            anos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da carteira?");
            preco = double.Parse(Console.ReadLine());
            
            double dinheiroGasto = ((cigDia*preco/20)*365)*anos;
            Console.WriteLine($"Foram gastos R${dinheiroGasto.ToString("F")}.");
        }

        static void xOito()
        {
            Console.WriteLine("X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y = Double.Parse(Console.ReadLine());

            if (x % y != 0)
            {
                Console.WriteLine("X NÃO é múltiplo de Y");
            }
            else
            {
                Console.WriteLine("X é múltiplo de Y");
            }
        }

        static void xNove()
        {
            Console.WriteLine("X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Z:");
            double z = Double.Parse(Console.ReadLine());

            Console.WriteLine(x > (y+z) ? "X é maior que a soma de Y e Z" : "X não é maior que a soma de Y e Z");
        }

        static void xDez()
        {
            System.Console.WriteLine("Insira um número:");
            double A = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira outro número:");
            double B = Double.Parse(Console.ReadLine());

            if (A>B)
            {
                System.Console.WriteLine($"{A} é maior que {B}.");
            } else if (B>A)
            {
                System.Console.WriteLine($"{B} é maior que {A}.");
            } else
            {
                System.Console.WriteLine($"{A} é igual a {B}.");
            }
        }

        static void xOnze()
        {
            System.Console.WriteLine("Divisor:");
            double A = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Dividendo:");
            double B = Double.Parse(Console.ReadLine());

            if (B!=0)
            {
                Console.WriteLine("Quociente:");
                Console.WriteLine(A/B);
            }
            else
            {
                Console.WriteLine("DIVISÃO POR ZERO!");
            }
        }

        static void xDoze()
        {
            var arr = new double[4];
            double sumEven = 0;
            double sumOdd = 0;

            System.Console.WriteLine($"Insira {arr.Length} números:");
            for (int i = 0; i < arr.Length; i++)
            {
                var input = Double.Parse(Console.ReadLine());
                arr[i] = input;
            }
            foreach (var num in arr)
            {
                if (num % 2 == 0) {sumEven += num;}
                else {sumOdd += num;}
            }
            Console.WriteLine($"Soma dos pares: {sumEven}");
            Console.WriteLine($"Soma dos ímpares: {sumOdd}");
        }

        static void xTreze()
        {
            double biggest = Double.MinValue;
            System.Console.WriteLine("Insira dez números:");
            for (int c=1; c<=10; c++)
            {
                double input = Double.Parse(Console.ReadLine());
                if (input > biggest) {biggest = input;}
            }
            System.Console.WriteLine($"O maior número é {biggest}.");
        }

        static void xQuatorze()
        {
            double[] inputs = new double[3];

            Console.WriteLine("Insira três valores:");
            for (int i=0; i<3; i++)
            {
                inputs[i] = Double.Parse(Console.ReadLine());
            }
            Array.Sort(inputs);
            Console.WriteLine();
            Console.WriteLine($"{inputs[0]} < {inputs[1]} < {inputs[2]}");
        }

        static void xQuinze()
        {
            double[] inputs = new double[10];
            Console.WriteLine("Insira dez números:");
            for (int i=0; i<10; i++)
            {
                inputs[i] = Double.Parse(Console.ReadLine());
            }
            
            int multi3 = 0;
            int multi5 = 0;
            for (int i=0; i<10; i++)
            {
                if (inputs[i] != 0) {
                if (inputs[i] % 3 == 0) {multi3++;}
                if (inputs[i] % 5 == 0) {multi5++;} }
            }
            
            Console.WriteLine($"{multi3} múltiplos de 3;\n{multi5} múltiplos de 5.");
        }

        static void xDezesseis()
        {
            Console.WriteLine("Insira o salário:");
            double salario = Double.Parse(Console.ReadLine());
            double desconto = 0;
            double imposto = 0;

            if (salario > 2000)
            {
                imposto = 30;
            }
            else if (salario > 1200)
            {
                imposto = 25;
            }
            else if (salario > 600)
            {
                imposto = 20;
            }
            else
            {
                imposto = 0;
            }
            desconto = salario/100*imposto;
            salario -= desconto;
            if (imposto == 0)
            {Console.WriteLine("Salário inafetado, isento de impostos");}
            else {
            Console.WriteLine($"Salário líquido de R${salario.ToString("F")}. Redução de impostos de {imposto}% (R${desconto.ToString("F")}).");
            }
        }

        static void xDezessete()
        {
            Console.WriteLine("Insira um número para ver a tabuada:");
            double multi = Double.Parse(Console.ReadLine());
            int counter = 2;
            
            Console.Clear();
            Console.WriteLine("Aperte ENTER para ver o próximo número, ou X para encerrar.");

            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.X)
                {
                    break;    
                }
                Console.WriteLine($"{multi} x {counter} = {multi*counter}   ");
                counter++;    
            }
            Console.WriteLine("\nENCERRADO");
        }

        static void xDezoito()
        {
            Console.WriteLine("Quantas maçãs foram compradas?");
            int macas = Int32.Parse(Console.ReadLine());
            int indiv = macas % 12;
            double preco = (indiv*1.30) + (((int)macas/12)*12);

            Console.WriteLine($"R${preco.ToString("F")}");
        }
    }
}