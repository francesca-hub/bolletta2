using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioBolletta
{
   public class bolletta
    {
        public utente Utente { get; set; }
        public double Kwh { get; set; }
        public decimal Conto { get; set; }

        const decimal quotaFissa = 40;

        public  string StampaBolletta()
        {
           
          
            return $"l'utente {Utente.Nome} {Utente.Cognome}, ha consumato {Kwh} e deve pagare {Conto}";
        }

        public bolletta()
        {
            Utente = new utente();
        }

        public bolletta(double kwh)
        {
            Kwh = kwh;
            Conto = (decimal)(kwh * 10) + quotaFissa;
        }
         
       
    }
}
