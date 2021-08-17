using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136.SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //change the values as you wish. Rule: at least one UNIQUE number in the array
            int[] array = new int[] { 2, 2, 1 };

            var result = ReturnSingleNumber(array);
            Console.WriteLine("Unrepeatable Number: " + result.ToString());
            Console.ReadKey();
        }

        static int ReturnSingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Select(x => new
            {
                value = x.Key,
                count = x.Count()
            }).Where(x => x.count == 1).First().value;
        }
    }
}
