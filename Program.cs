using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Veuillez saisir la taille du tableau :\t");
            string number = Console.ReadLine();
            int taille = Convert.ToInt32(number);

            int[] Tab = new int[taille];

            Console.WriteLine("\n Veuillez saisir les elements du tableau :");

            for (int i = 0; i < taille; i++)
            {
                Console.Write("l'element N° {0} :  ",i+1);
                Tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //triage du tableau :
            Console.WriteLine("\n triage du tableau :");
            Array.Sort(Tab);
            int j = 0;
            for (int i = 0; i < taille; i++)
            {
                Console.Write("\t"+Tab[i]+" |");
                j = i;
            }

            //changer la taille du tableau :
            Array.Resize(ref Tab, taille + 1);
            //Array.Resize(ref Tab, Tab.length + 1);

            //l'insertion de la nouvelle valeur :
            Console.WriteLine("\n Veuillez saisir la valeur à insérer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Tab[j+1] = num;

            //triage du tableau apres l'insertion de la nouvelle valeur :
            Console.WriteLine("\n triage du tableau apres l'insertion :");

            Array.Sort(Tab);
            taille = Tab.Length;

            for (int i = 0; i < taille; i++)
            {
                Console.Write("\t {0} |", Tab[i]);

            }
        }
    }
}

//