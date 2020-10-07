using System;
using System.Linq;
using System.Collections.Generic;

namespace Domain
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

        public (int[], int[]) yDois(List<int> input)
        {
            var inputNormal = input.ToArray();  
            input.Reverse();
            
            var inputReverse = input.ToArray();
            return (inputNormal, inputReverse);
        }

        public bool yTres(double[] arr, double num)
        {
            return arr.Contains(num);
        }

        public bool yQuatro(double[] arrA, double[] arrB)
        {
            if (arrA.Length != arrB.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i]){return false;}
                }
                return true;
            }
        }

        public (double, int, int, int) yCinco(double[] arr)
        {
            double avg = arr.Sum()/arr.Length;
            int onAvg = 0;
            int aboveAvg = 0;
            int belowAvg = 0;
            foreach (double item in arr)
            {
                if (item == avg) {onAvg++;}
                else if (item < avg) {belowAvg++;}
                else {aboveAvg++;}
            }

            return (avg, belowAvg, onAvg, aboveAvg);
        }

        public double[] ySeis(double[] arrA, double[] arrB)
        {
            double[] arrC = new double[arrA.Length];

            Array.Sort(arrA);

            Array.Sort(arrB);
            Array.Reverse(arrB);

            for (int i=0; i<arrC.Length; i++)
            {
                arrC[i] = arrA[i] + arrB[i];
            }
            Array.Sort(arrC);

            return arrC;
        }
    }
}