using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace prKol_ind2_Gurina
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "num.txt";

            try
            {
                // чтение строк
                var numbers = File.ReadAllLines(file).Select(line => int.TryParse(line, out int number) ? number : (int?)null).Where(number => number.HasValue).Select(number => number.Value).ToList();
                // разделение на положительные и отрицательные
                var polosition = numbers.Where(n => n > 0);
                var otrication = numbers.Where(n => n < 0);

                // объединение и вывод
                var result = polosition.Concat(otrication);
                foreach (var number in result)
                {
                    Console.WriteLine(number);
                }

                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка !");
            }

            Console.ReadKey();
        }
    }
}
