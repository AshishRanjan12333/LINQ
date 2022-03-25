using System;
using System.Linq;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "India", "Burma", "Australia", "Japan", "Sinapore" };
            //var shortword = from word in arr where word.Length <=5 select word; //query syntax
            var shortword = arr.Where(w => w.Length <= 5);//method syntax (lambda method)
            foreach(var word in shortword)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
