using System;
using System.Linq;
using System.Collections.Generic;

namespace entra21_tests
{
    public class Arrays
    {
        public double[] yUm(double[] A, double[] B)
        {
            double[] C = new double[A.Length];
            
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i]-B[i];
            }
            
            return C;
        }

        public int[] yDois(List<int> input)
        {
            input.Reverse();
            return input.ToArray();
        }

        public void yTres()
        {
            double[] input = new double[10];

            Console.Clear();
            Console.WriteLine("Insira 10 números:");
            for (int i=0; i<10; i++)
            {
                input[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Insira um número para procurar no array:");
            double userNum = Double.Parse(Console.ReadLine());
            foreach (double item in input)
            {
                if (item == userNum)
                {
                    Console.WriteLine("O número se encontra no array na posição "+ Array.IndexOf(input, item)+".");
                    break;
                }
            }
        }

        public void yQuatro()
        {
            double[] A = new double[10];
            double[] B = new double[10];

            Console.Clear();
            Console.WriteLine("Insira os 10 números de A:");
            for (int i=0; i<10; i++)
            {
                A[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Insira os 10 números de B:");
            for (int i=0; i<10; i++)
            {
                B[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            for (int i=0; i<10; i++)
            {
                if (A[i] != B[i])
                {
                    Console.WriteLine("A e B NÃO são arrays idênticos.");
                    return;
                }
            }

            Console.WriteLine("A e B são arrays idênticos.");
        }

        public void yCinco()
        {
            double[] arr = new double[15];

            Console.Clear();
            Console.WriteLine("Insira 15 números:");
            for (int i=0; i<15; i++)
            {
                arr[i] = Double.Parse(Console.ReadLine());
            }
            
            double avg = arr.Sum()/15;
            Console.Clear();
            Console.WriteLine("Média = " + avg);
            int onAvg = 0;
            int aboveAvg = 0;
            int belowAvg = 0;
            foreach (double item in arr)
            {
                if (item == avg) {onAvg++;}
                else if (item < avg) {belowAvg++;}
                else {aboveAvg++;}
            }
            Console.WriteLine("O array contém:");
            Console.WriteLine(onAvg+" números na média,");
            Console.WriteLine(aboveAvg+" números acima da média e");
            Console.WriteLine(belowAvg+" números abaixo da média.");
        }

        public void ySeis()
        {
            double[] A = new double[12];
            double[] B = new double[12];
            double[] C = new double[12];

            Console.Clear();
            Console.WriteLine("Insira os 12 números de A:");
            for (int i=0; i<12; i++)
            {
                A[i] = Double.Parse(Console.ReadLine());
            }
            Array.Sort(A);

            Console.WriteLine("Insira os 12 números de B:");
            for (int i=0; i<12; i++)
            {
                B[i] = Double.Parse(Console.ReadLine());
            }
            Array.Sort(B);
            Array.Reverse(B);

            for (int i=0; i<12; i++)
            {
                C[i] = A[i] + B[i];
            }
            Array.Sort(C);
            
            Console.Clear();
            Console.WriteLine("Array C:");
            Console.WriteLine(string.Join(", ", C));
        }
    }
}