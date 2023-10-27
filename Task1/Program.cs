using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heatingRate = 0.05; // Тариф на отопление (на 1 м2 площади)
            double waterRate = 20; // Тариф на воду (на 1 чел)
            double gasRate = 15; // Тариф на газ (на 1 чел)
            double repairRate = 10; // Тариф на текущий ремонт (на 1 м2 площади)
            int area = 100; // Площадь помещения
            int occupants = 4; // Количество проживающих людей
            bool isWinter = true; // Переменная сезона (true для зимы или осени, false для весны или лета)
            bool isVeteranOfWork = true; // Переменная для льготы ветерана труда (true если есть льготы)
            bool isWarVeteran = false; // Переменная для льготы ветерана войны (true если есть льготы)

            // Расчет начисленных сумм
            double heatingPayment = heatingRate * area;
            double waterPayment = waterRate * occupants;
            double gasPayment = gasRate * occupants;
            double repairPayment = repairRate * area;
            double totalPayment = heatingPayment + waterPayment + gasPayment + repairPayment;

            // Применение льгот
            if (isVeteranOfWork)
            {
                heatingPayment *= 0.7; // 30% скидка ветерану труда
            }
            if (isWarVeteran)
            {
                heatingPayment *= 0.5; // 50% скидка ветерану войны
            }

            // Вывод таблицы
            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t{heatingPayment}\t{heatingPayment * 0.3}\t{heatingPayment - heatingPayment * 0.3}");
            Console.WriteLine($"Вода\t\t{waterPayment}\t0\t\t{waterPayment}");
            Console.WriteLine($"Газ\t\t{gasPayment}\t0\t\t{gasPayment}");
            Console.WriteLine($"Ремонт\t\t{repairPayment}\t0\t\t{repairPayment}");
            Console.WriteLine($"Итого\t\t{totalPayment}\t{heatingPayment * 0.3}\t{totalPayment - heatingPayment * 0.3}");
        }
    }
}
