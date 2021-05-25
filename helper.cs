using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioBolletta
{
  public static class helper
    {
        public static bolletta CreaBolletta()
        {
            Console.WriteLine("Inserisci il tuo nome");
            string n = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome?");
            string c = Console.ReadLine();
            double k;

            do {
                Console.WriteLine("Inserisci i kwh consumati");
            }while(!double.TryParse(Console.ReadLine(), out k));

            utente user = new utente(n, c);
            bolletta bolletta = new bolletta(k);
            bolletta.Utente = user;
            return bolletta;
        }

       
    }
}
