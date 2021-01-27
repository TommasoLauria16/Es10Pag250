using System;

namespace Gestione
{
    public class ClasseArray
    {
        private const int a = 5;
        private static int[] array = new int[a];
        public static void Riempimento(bool vf)
        {
            Random r = new Random();
            if (vf == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1000);
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"inserisci il valore in posizione {i}");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void OrdineStampa(bool destraSinistra)
        {
            if (destraSinistra == true)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }

        }
        public static double[] Ricerca()
        {

            int max = int.MinValue;
            int min = int.MaxValue;
            double somma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                somma += array[i];
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                //min = Math.Min(min, array[i]);
                //max = Math.Max(max, array[i]);
            }
            double media = somma / array.Length;
            //double[] maxMinMedia = new double[] { max, min, media };
            //return maxMinMedia;
            return new double[] { max, min, media };



        }
    }
}
