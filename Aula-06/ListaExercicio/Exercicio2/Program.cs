﻿  


    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Insert(2, 100);
            numeros.RemoveAt(numeros.Count - 1);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numeros);
            }
        }
    }