using System;

namespace StoreArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------\n\t W3lc8m3_B4ck!\n----------------------------------\n");

            Console.Write("Quantos dados deseja armazenar? ");
            int resp = Convert.ToInt32(Console.ReadLine());
            String[] dataStore = new String[resp];
            
            for (int i = 0; i < dataStore.Length; i++)
            {
                Console.Write("Digite o dado a ser armazenado: ");
                dataStore[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("\n----------------------------------\n\t DATA STORED\n----------------------------------\n");
            foreach (String s in dataStore)
            {
                Show(s);
            }
            Console.ReadKey();
        }

        static void Show(String name) {
            Console.WriteLine("=> Data stored: " + name);
        }
    }
}