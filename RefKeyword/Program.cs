using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    internal class Program
    {

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Calculation(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }

        static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }



        static void Main(string[] args)
        {
           
            Console.WriteLine("this is ref keyword output ");
            int a = 10, b = 20,sum,sub,multiply;
            Swap(ref a, ref b);  //call by ref keyword 
            Console.WriteLine($"a = {a} b= {b}");

            Console.WriteLine("-----------");
            Console.WriteLine("this is out keyword output ");

            Calculation(a, b, out sum, out sub, out multiply);
            Console.WriteLine($"sum ={sum}  sub={sub}  multiplication {multiply}");

            Console.WriteLine("-----------");
            Console.WriteLine("this is params keyword output ");
            AcceptNames("Rahul", "Kishor", "Tushar");
            AcceptNames("Rahul", "Kishor");
            AcceptNames("Rahul", "Kishor", "Tushar", "Raj");


        }
    }
}
