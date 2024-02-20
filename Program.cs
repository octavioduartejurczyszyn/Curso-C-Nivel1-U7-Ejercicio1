using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición
            // dentro del vector
            int max = vnum[0], pos = 1;
            int[] vnum = new int[10];  
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Escriba un nro: ");
                vnum[x] = int.Parse(Console.ReadLine());     
            }
            for (int x = 0; x < 10; x++)
            {
                if(vnum[x] > max)
                {
                    max = vnum[x];
                    pos = x + 1;
                }
            }
            Console.WriteLine("El valor máximo es " + max + " y su posición es " + pos);
        }
    }
}
