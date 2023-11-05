using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class SquaredArray
    {
        private double[] data; 

        public SquaredArray(int size)
        {
            data = new double[size];
        }

 
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < data.Length)
                {
                    return data[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            set
            {
                if (index >= 0 && index < data.Length)
                {
                    data[index] = value * value; 
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            SquaredArray arr = new SquaredArray(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите значение для arr[{i}]: ");
                double value = double.Parse(Console.ReadLine());
                arr[i] = value; 

            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}"); 
            }
            Console.ReadKey();
        }
    }
}
