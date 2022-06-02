using System;
using System.Linq;

namespace LINQAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();

            QueryIntArray();

            Console.ReadKey();
        }

        static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy", "Maya" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var greaterThan20 = from num in nums
                                where num > 20
                                orderby num
                                select num;

            foreach (var i in greaterThan20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine($"Get Type : {greaterThan20.GetType()}");

            var listGreaterThan20 = greaterThan20.ToList<int>();
            var arrayGreaterThan20 = greaterThan20.ToArray();

            nums[0] = 40;

            foreach (var i in greaterThan20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            return arrayGreaterThan20;
        }
    }
}
