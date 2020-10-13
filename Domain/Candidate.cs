using System;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Candidate
    {
        public Guid Id {get; private set;} = Guid.NewGuid();

        public string Name {get; private set;}

        public string Cpf {get; private set;}

        public int Votes {get; private set;} = 0;

        public Candidate(string name, string cpf)
        {
            this.Name = name;
            this.Cpf = cpf;
        }

        public bool ValidateCPF()
        {
            if (string.IsNullOrEmpty(this.Cpf))
            {
                return false;
            }

            var cpf = this.Cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            if (!cpf.All(char.IsNumber))
            {
                return false;
            }

            var first = cpf[0];
            if (cpf.Substring(1, 10).All(x => x == first))
            {
                return false;
            }

            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string temp;
            string digit;
            int sum;
            int rest;

            temp = cpf.Substring(0, 9);
            sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(temp[i].ToString()) * multiplier1[i];
            }

            rest = sum % 11;

            rest = rest < 2 ? 0 : 11 - rest;

            digit = rest.ToString();
            temp += digit;
            sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(temp[i].ToString()) * multiplier2[i];
            }

            rest = sum % 11;

            rest = rest < 2 ? 0 : 11 - rest;

            digit += rest.ToString();

            if (cpf.EndsWith(digit))
            {
                return true;
            }

            return false;
        }

        public bool ValidateName()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                return false;
            }

            Name.Trim();

            if (string.IsNullOrWhiteSpace(this.Name))
            {
                return false;
            }
            
            if (!Name.All(x => char.IsLetter(x) || char.IsWhiteSpace(x)))
            {
                return false;
            }
            
            // Fix capitalization
            var newName = new StringBuilder();
            for (int i = 0; i < Name.Length; i++)
            {
                if (i==0)
                {
                    newName.Append(Name[i].ToString().ToUpper());
                }
                else if (Name[i] == ' ')
                {
                    if (Name[i-1] == ' ') {continue;}
                    newName.Append(Name[i].ToString());
                }
                else
                {
                    if (Name[i-1] == ' ')
                    {
                        newName.Append(Name[i].ToString().ToUpper());
                    }
                    else
                    {
                        newName.Append(Name[i].ToString().ToLower());
                    }
                }
            }
            Name = newName.ToString();

            return true;
        }

        public void Vote()
        {
            Votes++;
        }
    }
}