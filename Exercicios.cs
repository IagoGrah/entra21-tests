using System;
using System.Collections.Generic;

namespace entra21_tests
{
    class Exercicios
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

        public double xQuatro(List<int> ages)
        {
            if (ages.Count <= 0)
            {
                return 0;
            }
            
            double sum = 0;
            
            foreach (var item in ages)
            {
                sum += item;
            }

            return sum/ages.Count;
        }

        public double xCinco(List<double> women)
        {
            double naFaixa = 0;
            
            foreach (var age in women)
            {
                if (age >= 18 && age <= 35){naFaixa++;}
            }

            return (100.0/women.Count)*naFaixa;
        }

        public string xSeis(string candidato1, string candidato2, double votos1, double votos2)
        {            
            if (votos1>votos2) 
            { 
                return candidato1;
            }
            else if (votos2>votos1)
            {
                return candidato2;
            }
            else
            {
                return "Empate";
            }
        }

        public double xSete(double cigDia, double anos, double preco)
        {
            return ((cigDia*preco/20)*365)*anos;
        }

        public bool xOito(double x, double y)
        {
            if (x % y != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool xNove(double x, double y, double z)
        {
            return x > (y+z) ? true : false;
        }

        public string xDez(double A, double B)
        {
            if (A>B)
            {
                return $"{A}>{B}";
            } else if (B>A)
            {
                return $"{B}>{A}";
            } else
            {
                return $"{A}={B}";
            }
        }

        public double xOnze(double A, double B)
        {
            if (B!=0)
            {
                return A/B;
            }
            else
            {
                return 0;
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

        public double xTreze(List<double> input)
        {
            double biggest = Double.MinValue;
            foreach (var item in input)
            {
                if (item > biggest) {biggest = item;}
            }

            return biggest;
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

        public double xDezoito(int macas)
        {
            return ((macas%12)*1.30) + (((int)macas/12)*12);
        }
    }
}