using System;

namespace entra21_tests
{
    public class Program
    {
        public static string Check(double n1, double n2)
        {
            if (n1>n2) {return "greater";}
            else if (n1<n2) {return "lesser";}
            else {return "equal";}
        }
    }
}