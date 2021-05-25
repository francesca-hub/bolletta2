using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioBolletta
{
   public class utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public utente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public utente()
        {
        }


    }

   
}
