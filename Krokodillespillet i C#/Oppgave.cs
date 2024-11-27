using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Krokodillespillet_i_C_
{
    internal class Oppgave
    {
        int points = 0;
        
        public void Run()
        {
            Console.WriteLine("Velkommen til krokodillespillet!");
            Console.WriteLine("Her skal du svare riktig på om tallene er like eller hvem som er størst");
        }

        private void RandomNumber()
        {
            Random rand = new Random();
            var randomnummer = rand.Next(0,11);
        }

        private void Getrightsign()
        {
            

        }

        private void Getcorrectsign()
        {
           

            
        
        }




    
    
    
    
    }
}
