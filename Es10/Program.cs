using System;
using Gestione;

namespace Es10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vf = false;
            bool dS = false;
            Console.WriteLine("vuoi effettuare il riempimento casuale o manuale");
            string str = Console.ReadLine();
            if (str == "casuale" || str == "Casuale" || str == "CASUALE")
                vf = true;
            ClasseArray.Riempimento(vf);
            Console.WriteLine("vuoi stapare l'array da destra a sinista digita DS;\nse vuoi stamparlo da sinistra a destra SD");
            string destra_Sinistra = Console.ReadLine();
            if (destra_Sinistra == "DS" || destra_Sinistra == "Ds" || destra_Sinistra == "ds")
                dS = true;
            ClasseArray.OrdineStampa(dS);
            double[] array = ClasseArray.Ricerca();
            Console.WriteLine($"\nil massimo è {array[0]};\nil minimo è {array[1]};\nla media è {array[2]}.");
            Console.ReadLine();
        }
    }
}
