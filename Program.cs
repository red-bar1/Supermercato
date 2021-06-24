using System;
using Week6.SupermercatoEF.Repository;

namespace Week6.SupermercatoEF
{
    //modello E-R
    //modello con classi
    //context
    //fluent api o data annotation
    //DB (con migration)
    //repository
    //menu
    class Program
    {
        private static IRepositoryDipendente repoDipendente = new RepoDipendente();
        private static IRepositoryReparto repoReparto = new RepoReparto();
        private static IRepositoryProdotto repoProdotto = new RepoProdotto();
        private static IRepositoryVendita repoVendita = new RepoVendita();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
