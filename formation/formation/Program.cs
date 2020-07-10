using System;
using System.Collections.Generic;

namespace formation
{
    class Program
    {
        static void Main(string[] args)
        {

            var ramdom1 = new Random();
            var ramdom2 = new Random();
            List<int> somme = new List<int>();
            var NombreDeReponseVrai = 0;
            var question = 5;
            

            for (int i = 1; i < question; i++)
            {
                var Ramdom1 = ramdom1.Next(2, 10);
                var Ramdom2 = ramdom2.Next(2, 10);

                Console.WriteLine("question" + " " + i + "/5" + "   " + Ramdom1 + "+" + Ramdom2 + "=");
                var result = Console.ReadLine();
                var resulte = Convert.ToInt32(result);


                if (resulte == Ramdom1+Ramdom2)
                {
                    Console.WriteLine("bonne reponse");
                    NombreDeReponseVrai++;
                    
                }
                else
                {
                    Console.WriteLine("mauvaise reponse");
                }

            }
            foreach (var n in somme)
            {
                NombreDeReponseVrai += n;
            }
            if(question)
            {
                Console.WriteLine("vous avez repondu a " + " " +NombreDeReponseVrai + " bonnes reponses" );
            }
                     
        }
    }
}
