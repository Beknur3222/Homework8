using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsyrma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет коммунальных платежей");

            Console.Write("Площадь помещения (м2): ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Количество проживающих людей: ");
            int numberOfResidents = int.Parse(Console.ReadLine());

            Console.Write("Сезон (осень/зима - 1, весна/лето - 2): ");
            int season = int.Parse(Console.ReadLine());

            Console.Write("Льготы (ветеран труда - 1, ветеран войны - 2, нет льгот - 3): ");
            int discountType = int.Parse(Console.ReadLine());

            double heatingRate = 10; 
            double waterRate = 5; 
            double gasRate = 8;
            double repairRate = 7; 

            double heatingPayment = area * heatingRate;
            double waterPayment = numberOfResidents * waterRate;
            double gasPayment = numberOfResidents * gasRate;
            double repairPayment = area * repairRate;

            if (season == 1)
            {
                heatingPayment *= 1.2;
            }

            double discount = 0;
            if (discountType == 1)
            {
                discount = (heatingPayment + repairPayment) * 0.3;
            }
            else if (discountType == 2)
            {
                discount = (heatingPayment + repairPayment) * 0.5;
            }

            double totalPayment = heatingPayment + waterPayment + gasPayment + repairPayment - discount;

            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine("Отопление\t{0:C2}\t{1:C2}\t{2:C2}", heatingPayment, discount, heatingPayment - discount);
            Console.WriteLine("Вода\t{0:C2}\t0.00\t{0:C2}", waterPayment);
            Console.WriteLine("Газ\t{0:C2}\t0.00\t{0:C2}", gasPayment);
            Console.WriteLine("Ремонт\t{0:C2}\t{1:C2}\t{2:C2}", repairPayment, discount, repairPayment - discount);
            Console.WriteLine("Итого\t{0:C2}\t{1:C2}\t{2:C2}", totalPayment + discount, discount, totalPayment);

            Console.ReadKey();
        }
    }
}
