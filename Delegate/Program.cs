using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Delegates characteristics:
	Used to create method objects
	with invoke method, we can call a delegate as a method
	we can pass the delegate object as an argument to another method
 * 
 */
namespace Delegate
{
    class Program
    {
        //=> goest to
        delegate void D(String value); //type declaration

        static void Main(string[] args)
        {
            //specify delegate with lamada expression
            D d = v => Console.WriteLine(v); //lamada expression
            d.Invoke("cat");

            //example UpperCaseFirst method in the main
            WriteOutput("green", new UpperCaseDelegate(UpperCaseFirst));
            //example UpperCaseLast method in the main
            WriteOutput("john", new UpperCaseDelegate(UpperCaseLast));
            //example UpperCaseAll method in the main
            WriteOutput("harry", new UpperCaseDelegate(UpperCaseAll));
        }
        //example
        delegate string UpperCaseDelegate(string input);
        static string UpperCaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        static string UpperCaseLast(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = char.ToUpper(buffer [buffer.Length - 1]);
            return new string(buffer);
        }
        static string UpperCaseAll(string input)
        {
            return input.ToUpper();
        }
        static void WriteOutput(string input, UpperCaseDelegate del)
        {
            Console.WriteLine("your string before:{0}", input);
            Console.WriteLine("your string after:{0}", del(input));
        }
    }
}
