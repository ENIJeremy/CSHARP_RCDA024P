using ProjetLinq.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.InitialiserDatas();


            var nomG = (from nom in Data.ListeAuteurs where nom.Nom.StartsWith("G") select nom).ToArray();
            foreach(Auteur auteur in nomG)
            {
                Console.WriteLine(auteur.Nom);
            }

            Console.WriteLine();

            var auteurMax = Data.ListeLivres.GroupBy(x => x.Auteur).OrderByDescending(y => y.Count()).First().Key;
            Console.WriteLine(auteurMax.Nom);

            Console.WriteLine();


            var groupLivre = Data.ListeLivres.GroupBy(x => x.Auteur);
            foreach(var livre in groupLivre)
            {
                Console.WriteLine(livre.Average(x => x.NbPages));
            }

            Console.WriteLine();

            var livreMax = Data.ListeLivres.OrderByDescending(x => x.NbPages).First();

            Console.WriteLine(livreMax.Titre);


            Console.WriteLine();

            var moyen = Data.ListeAuteurs.Average(x => x.Factures.Sum(y => y.Montant));
            Console.WriteLine(moyen.ToString());


            Console.WriteLine();

            var livres = Data.ListeLivres.GroupBy(x => x.Auteur);
            foreach (var livre in livres)
            {
                Console.WriteLine();
                Console.WriteLine(livre.Key.Prenom + " " + livre.Key.Nom);
                livre.ToList<Livre>().ForEach(x => Console.WriteLine(x.Titre));
            }


            Console.WriteLine();

            Data.ListeLivres.Select(x => x.Titre).OrderBy(y => y).ToList().ForEach(z => Console.WriteLine(z));

            Console.WriteLine();

            Data.ListeLivres.Where(x => x.NbPages > Data.ListeLivres.Average(y => y.NbPages)).ToList().ForEach(z => Console.WriteLine(z.Titre));



            Console.ReadLine();


        }
    }
}
