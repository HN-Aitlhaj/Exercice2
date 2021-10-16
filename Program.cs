using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir la taille du tableau");
            string number = Console.ReadLine();
            int taille = Convert.ToInt32(number);

            int[] Tab = new int[taille];

            Console.WriteLine("Veuillez saisir les elements du tableau :");

            for (int i = 0; i < taille; i++)
            {
                Console.Write("l'element N° {0} :  ",i+1);
                Tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("triage du tableau");
            Array.Sort(Tab);
            int j = 0;
            for (int i = 0; i < taille; i++)
            {
                Console.Write("\t"+Tab[i]+" ");
                j = i;
            }
            Array.Resize(ref Tab, Tab.Length + 1);

            Console.Write("\n\n Veuillez saisir la valeur à insérer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Tab[j] = num;

            for (int i = 0; i < Tab.Length; i++)
            {
                Array.Sort(Tab);
                Console.Write("\t {1} |", (i + 1), Tab[i]);

            }
        }
    }
}
