using System.Runtime.InteropServices;

namespace ejercicio1DeArraysVocales;

class Program
{

    public static void Main(string[] args)
    {

        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };


        char[] vocales2 = { 'a', 'e', 'i', 'o', 'u' };


        for (int i = 0; i < 5; i++)
        {
            if (vocales[i] == vocales2[i])
            {
               
            }
            else  Console.WriteLine(i);

            
        }
    }
}
