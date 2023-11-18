using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UtilityBill
    {
        // базовые тарифы на коммунальные услуги
        private const double heatingRate = 100; // на отопление (на 1 м2 площади)
        private const double waterRate = 50; // на воду (на 1 чел)
        private const double gasRate = 40; // на газ (на 1 чел)
        private const double repairRate = 20; // на текущий ремонт (на 1 м2 площади)

        // поля для хранения параметров помещения и проживающих
        private double area; // метраж помещения
        private int people; // количество проживающих людей
        private string season; // сезон
        private bool laborVeteran; // ветеран труда
        private bool warVeteran; // ветеран войны

        public double Area
        {
            get { return area; }
            set { area = value > 0 ? value : 0; } 
        }

        public int People
        {
            get { return people; }
            set { people = value > 0 ? value : 0; } 
        }

        public string Season
        {
            get { return season; }
            set { season = value; }
        }

        public bool LaborVeteran
        {
            get { return laborVeteran; }
            set { laborVeteran = value; }
        }

        public bool WarVeteran
        {
            get { return warVeteran; }
            set { warVeteran = value; }
        }

        public UtilityBill(double area, int people, string season, bool laborVeteran, bool warVeteran)
        {
            Area = area; // инициализация метража помещения
            People = people; // инициализация количества проживающих людей
            Season = season; // инициализация сезона
            LaborVeteran = laborVeteran; // инициализация ветерана труда
            WarVeteran = warVeteran; // инициализация ветерана войны
        }

        // метод для расчета суммы за отопление
        public double Heating()
        {
            double heating = Area * heatingRate; // начислено за отопление
            if (Season == "осень" || Season == "зима") // если осень или зима
            {
                heating *= 1.5; // увеличиваем тариф на 50%
            }
            if (LaborVeteran) // если ветеран труда
            {
                heating *= 0.7; // уменьшаем тариф на 30%
            }
            if (WarVeteran) // если ветеран войны
            {
                heating *= 0.5; // уменьшаем тариф на 50%
            }
            return heating; // возвращаем сумму за отопление
        }

        // метод для расчета суммы за воду
        public double Water()
        {
            double water = People * waterRate; // начислено за воду
            if (LaborVeteran) // если ветеран труда
            {
                water *= 0.7; // уменьшаем тариф на 30%
            }
            if (WarVeteran) // если ветеран войны
            {
                water *= 0.5; // уменьшаем тариф на 50%
            }
            return water; // возвращаем сумму за воду
        }

        // метод для расчета суммы за газ
        public double Gas()
        {
            double gas = People * gasRate; // начислено за газ
            if (LaborVeteran) // если ветеран труда
            {
                gas *= 0.7; // уменьшаем тариф на 30%
            }
            if (WarVeteran) // если ветеран войны
            {
                gas *= 0.5; // уменьшаем тариф на 50%
            }
            return gas; // возвращаем сумму за газ
        }

        // метод для расчета суммы за текущий ремонт
        public double Repair()
        {
            double repair = Area * repairRate; // начислено за текущий ремонт
            if (LaborVeteran) // если ветеран труда
            {
                repair *= 0.7;  // уменьшаем тариф на 30%
        }
            if (WarVeteran) // если ветеран войны
            {
                repair *= 0.5; // уменьшаем тариф на 50%
            }
            return repair; // возвращаем сумму за текущий ремонт
        }

        // метод для расчета льготной скидки
        public double CalculateDiscount()
        {
            double totalDiscount = 0;

            // Льгота для ветерана труда
            if (LaborVeteran)
            {
                totalDiscount += 0.3; // 30% от общей суммы
            }

            // Льгота для ветерана войны
            if (WarVeteran)
            {
                totalDiscount += 0.5; // 50% от общей суммы
            }

            return totalDiscount;
        }

        // метод для расчета итоговой суммы
        public double CalculateTotal()
        {
            double total = Heating() + Water() + Gas() + Repair(); // общая сумма
            double discount = CalculateDiscount(); // льготная скидка
            double totalWithDiscount = total - (total * discount); // итоговая сумма с учетом скидки

            return totalWithDiscount;
        }
    }
}

