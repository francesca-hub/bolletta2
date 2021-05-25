using System;

namespace EsercizioBolletta
{
/*Realizzare un’applicazione console che consenta di eseguire il calcolo della bolletta della luce.


Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
		
inserire i propri dati (nome, cognome e kwH consumati);
richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
	
Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.*/
    class Program
    {
        static void Main(string[] args)
        {
            //string nome = null, cognome = null;
            //double kwh = 0;
            //const decimal quotaFissa = 40;
            //decimal bolletta = 0;

            bolletta b = new bolletta();




            Console.WriteLine("Calcolo Bolletta");
            string scelta;
            do
            {
                Console.WriteLine("Premi 1 per inserire dati: Nome, Cognome, kWh");
                Console.WriteLine("Premi 2 per richiedere il calcolo della bolletta");
                Console.WriteLine("Premi 3 per stampare tutti i dati");
                Console.WriteLine("Premi 0 per uscire");

                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        b = helper.CreaBolletta();

                        break;

                    case "2":
                        bolletta a = new bolletta();
                        b.StampaBolletta();
                                           
                        break;
                        
                    case "3":
                       
                        Console.WriteLine(b.StampaBolletta());

            
                        break;
                        

                }

            } while (scelta != "0");

           
            
            
        }
        //40€ più il prodotto tra i kwH e 10


        private static void CalcolaBolletta(out decimal bolletta, double kwh, decimal quotaFissa)
        {
            bolletta = (decimal)(kwh * 10) + quotaFissa;
            Console.WriteLine($"L'importo della bolletta è {bolletta}!");
        }



        private static void InserisciDati(out string nome, out string cognome)
        {
            Console.WriteLine("Inserisci nome");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            cognome = Console.ReadLine();
            //Console.WriteLine("Inserisci kwh");
            //kwh = int.Parse(Console.ReadLine());
        }

        private static void InserisciDati(out double kwh)
        {

            do
            {
                Console.WriteLine("Inserisci i kwh consumati: ");
            } while (!double.TryParse(Console.ReadLine(), out kwh));
        }
        
        private static void StampaDati(string nome,  string cognome, decimal bolletta, double kwh)
        {
            Console.WriteLine($"Il cliente {cognome} {nome} deve pagare {bolletta}");
        }

 
    }
}
