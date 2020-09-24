using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace entra21_tests
{
    public class Exercicios
    {
        public string xUmA()
        {
            var str = new StringBuilder();
            
            for (int i=1; i<=10; i++)
            {
                str.Append(i + " ");
            }

            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }

        public string xUmB()
        {
            var str = new StringBuilder();
            
            for (int i=10; i>=1; i--)
            {
                str.Append(i + " ");
            }
            
            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }

        public string xUmC()
        {            
            var str = new StringBuilder();
            
            for (int i=1; i<=10; i++)
            {
                if (i % 2 != 0)
                {
                 str.Append(i + " ");
                }
            }

            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }
        
        public int xDois()
        {
            int count = 0;
            for (int i=1; i<=100; i++)
            {
                count += i;
            }
            return count;
        }

        public string xTres()
        {
            var str = new StringBuilder();
            
            for (int i=1; i<=200; i++)
            {
                if (i % 2 != 0)
                {
                 str.Append(i + ",");
                }
            }

            str.Remove(str.Length - 1, 1);
            return str.ToString();
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

        // Exercicio refatorado para Election.cs
        //
        // public string xSeis(string candidato1, string candidato2, double votos1, double votos2)
        // {            
        //     if (votos1>votos2) 
        //     { 
        //         return candidato1;
        //     }
        //     else if (votos2>votos1)
        //     {
        //         return candidato2;
        //     }
        //     else
        //     {
        //         return "Empate";
        //     }
        // }

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

        public (int, int) xDoze(int[] numbers)
        {
            (int even, int odd) sums = (0, 0);

            foreach (var num in numbers)
            {
                if (num % 2 == 0) {sums.even += num;}
                else {sums.odd += num;}
            }
            return sums;
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

        public string xQuatorze(List<double> numbers)
        {
            numbers.Sort();
            var result = new StringBuilder();
            foreach (var item in numbers)
            {
                result.Append(item + " < ");
            }
            result.Remove(result.Length-3, 3);

            return result.ToString();
        }

        public (int, int) xQuinze(List<double> numbers)
        {
            int multi3 = 0;
            int multi5 = 0;
            foreach (var item in numbers)
            {
                if (item != 0) {
                if (item % 3 == 0) {multi3++;}
                if (item % 5 == 0) {multi5++;} }
            }

            return (multi3, multi5);            
        }

        public double xDezesseis(double salario)
        {
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
            return salario;
        }

        public List<double> xDezessete(double number, List<double> multiples)
        {
            return multiples.Select(item => item*number).ToList();
        }

        public double xDezoito(int macas)
        {
            return ((macas%12)*1.30) + (((int)macas/12)*12);
        }
    }
}