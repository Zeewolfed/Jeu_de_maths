using System;
using System.Drawing;

namespace Jeu_de_maths
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }
        static bool PoserQuestion(int MIN, int MAX)
        {
            Random random = new Random();

            int reponseInt = 0;
            while (true)
            {
                int a = random.Next(MIN, MAX);
                int b = random.Next(MIN, MAX);
                e_Operateur o = (e_Operateur) random.Next(1, 3);
                int resultatAttendu;

                if(o == e_Operateur.ADDITION)
                {
                    Console.Write($"{a} + {b} = ");
                    resultatAttendu = a + b;
                }
                else if (o == e_Operateur.MULTIPLICATION)
                {
                    Console.Write($"{a} x {b} = ");
                    resultatAttendu = a * b;
                }
                else if (o == e_Operateur.SOUSTRACTION)
                {
                    Console.Write($"{a}  {b} = ");
                    resultatAttendu = a - b;
                }
                else
                {
                    Console.WriteLine("ERREUR operateur inconnu!!");
                    return false;
                }

                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false ;
                }
                catch
                {
                    Console.WriteLine("ERREUR tu dois renter un nombre!!");
                    
                }
            }
            
        }
        
        static void Main(string[] args)
        {
            

            const int NOMBRE_NIM = 0;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTION = 4;

            int points = 0;

            for(int i = 0; i < NB_QUESTION; i++)
            {
                Console.WriteLine($"Question Numero {i+1}/{NB_QUESTION} ");

                bool bonneReponse = PoserQuestion(NOMBRE_NIM, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse");
                    
                }
                Console.WriteLine();
                
            }
            Console.WriteLine($"Nombre de points: {points}/{NB_QUESTION}");

            int moyenne = NB_QUESTION / 2;

            if(points == NB_QUESTION)
            {
                Console.WriteLine("100% bonnes reponse => Excellent");
            }
            else if(points == 0 )
            {
                Console.WriteLine("Revise tes Maths");
            }
            else if(points > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else
            {
                Console.WriteLine("Peut mieu faire");
            }
                
        }
    }
}