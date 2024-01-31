using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtEmail = "j.rivaldoaraujo@outloo.com";

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            string[] emails = txtEmail.Split(',');
            if (emails.Count() > 0)
            {
                for (int i = 0; i < emails.Count(); i++)
                {
                    if (!rg.IsMatch(emails[i]))
                    {
                        Console.WriteLine("O E-mail " + emails[i] + " informado é inválido.");
                    }
                    else
                    {
                        Console.WriteLine("O E-mail " + emails[i] + " EMMAIL CORRETO ");
                    }
                }
            }
           
        }
    }
}
