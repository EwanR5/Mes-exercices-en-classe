using System;

namespace AlgoAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string categorie = "";
            int age = 0;
            Console.WriteLine("Hello World!");
            categorieAge(age, ref categorie);
        }

        public static void categorieAge(int age, ref string categorie)
        {
            if (age < 6)
            {
                categorie = "Vous êtes trop jeune";
            }
            else if (age <= 7)
            {
                categorie = "Vous êtes Poussin";
            }
            else if (age <= 9)
            {
                categorie = "Vous êtes Pupille";
            }
            else if (age <= 11)
            {
                categorie = "Vous êtes Minime";
            }
            else if (age <= 14)
            {
                categorie = "Vous êtes Cadet";
            }
            else
            {
                categorie = "Vous êtes trop âgé";
            }

              
        }
    }
}
