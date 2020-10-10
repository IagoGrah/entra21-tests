using System;
using System.Linq;

namespace Domain
{
    public class Arrays2
    {
        public (double[] A, double[] B) zUm(double[] A, double[] B)
        {
            // return (B, A);
            var temp = new double[A.Length];
            A.CopyTo(temp, 0);
            B.CopyTo(A, 0);
            temp.CopyTo(B, 0);

            return (A, B);
        }

        public bool zDois(double[] arr)
        {
            return arr.Length != arr.Distinct().Count() ? true : false;
        }
        
        public double zTres(char[] genders, char[] answers)
        {
            double women = 0;
            double womenYes = 0;
            
            for (int i = 0; i < genders.Length; i++)
            {
                if (genders[i] == 'f')
                {
                    women++;
                    if (answers[i] == 'y')
                    {womenYes++;}
                }
            }

            return (100/women)*womenYes;
        }

        public int zQuatro(int[] input)
        {
            return input.Where(x => x%2 != 0).Sum();
        }

        public int zCinco(double[] arr)
        {
            return arr.Count(x => x > 0);
        }

        public int zSeis(double[] input)
        {
            if (input.Any(x => x<0))
            {
                throw new ArgumentException("Number must be positive");
            }
            else
            {
            return Array.IndexOf(input, input.Max());
            }
        }

        public int zSete(double[] arr)
        {
            int same = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i){same++;}
            }
            return same;
        }

        public int zOito(char[] arr)
        {
            return arr.Count(x => 
            {
                return char.ToUpper(x)=='A'
                ||char.ToUpper(x)=='E'
                ||char.ToUpper(x)=='I'
                ||char.ToUpper(x)=='O'
                ||char.ToUpper(x)=='U';
            });
        }

        public string zNove(char[] arr)
        {
            string output = "";

            for (int i = 0; i < arr.Length; i+=2)
            {
                output += arr[i];
            }

            return output;
        }
    }
}