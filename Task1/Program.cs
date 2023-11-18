using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtilityBill utilityBill = new UtilityBill(80, 3, "зима", true, false);  // | 1м2 | людей | ветеран труда | ветеран войны |

            Console.WriteLine("Вид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Отопление\t\t{utilityBill.Heating()}\t\t{utilityBill.Heating() * utilityBill.CalculateDiscount()}\t\t{utilityBill.Heating() - (utilityBill.Heating() * utilityBill.CalculateDiscount())}");
            Console.WriteLine($"Вода\t\t\t{utilityBill.Water()}\t\t{utilityBill.Water() * utilityBill.CalculateDiscount()}\t\t{utilityBill.Water() - (utilityBill.Water() * utilityBill.CalculateDiscount())}");
            Console.WriteLine($"Газ\t\t\t{utilityBill.Gas()}\t\t{utilityBill.Gas() * utilityBill.CalculateDiscount()}\t\t{utilityBill.Gas() - (utilityBill.Gas() * utilityBill.CalculateDiscount())}");
            Console.WriteLine($"Ремонт\t\t\t{utilityBill.Repair()}\t\t{utilityBill.Repair() * utilityBill.CalculateDiscount()}\t\t{utilityBill.Repair() - (utilityBill.Repair() * utilityBill.CalculateDiscount())}");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Итого\t\t\t\t\t\t\t{utilityBill.CalculateTotal()}");

            Console.ReadLine();
        }
    }
}
