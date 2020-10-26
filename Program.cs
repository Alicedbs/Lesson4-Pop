using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson4_Pop
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            Console.ReadKey();
        }


        static void task1() //triangle
        {
            Console.WriteLine("Enter the number of lines for the triangle : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ", j);
                }
                Console.WriteLine();
            }
        }


        static void task2() //diamond
        {
            int i, j, n;

            Console.WriteLine("Enter the number of lines for half of a triangle : ");

            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    
        

        
        static char[] alpha = { 'a', 'b', 'c' };
        static char[] secret = { 'x', 'y', 'z' };

        static void task3()
        {
            Console.WriteLine("Write the word to encode : ");
            string stringToEncode = Console.ReadLine();

            string encodedString = encode(stringToEncode);
            Console.WriteLine($"Encoded string : {encodedString}");

            string decodedString = decode(stringToEncode);
            Console.WriteLine($"Decoded string : {decodedString}");

        }

        static int indexOf(char letter, char[] array)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
        

        static string encode(string inputString)
        {
            string result = "";
            foreach(char character in inputString)
            {
                int index = indexOf(character, alpha);
                result += secret[index];
            }
            return result;
        }

        static string decode(string encodedString)
        {
            string result = "";
            foreach (char character in encodedString)
            {
                int index = indexOf(character, secret);
                result += alpha[index];
            }
            return result;
        }


    } 
}
