using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsererEntier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = {1,2,3,4,5,6};
            int nbr,choix;
            Console.Write("tab = ");
            AfficherTab(tab);
            while (true)
            {
                Console.WriteLine("1- Afficher le tableau."); 
                Console.WriteLine("2- Ajouter un element."); 
                Console.WriteLine("3- Quittez.");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        AfficherTab(tab);
                        break;
                    case 2:
                        Console.Write("Ajoutez un nombre : ");
                        nbr = int.Parse(Console.ReadLine());
                        AjouterNbr(ref tab, nbr);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            
            Console.Read();
        }

        public static void AfficherTab(int[] tab)
        {
            foreach (int i in tab)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void AjouterNbr(ref int[] tab, int nbr)
        {
            Array.Resize(ref tab, tab.Length + 1);
            for (int i = 0; i < tab.Length; i++)
            {
                if (nbr <= tab[i])
                {
                    for (int j = tab.Length-1; j > i; j--)
                        tab[j] = tab[j - 1];
                    tab[i] = nbr;
                    break;
                }
            }
            if (tab[tab.Length - 1] == 0)
                tab[tab.Length - 1] = nbr;
        }
    }
}
