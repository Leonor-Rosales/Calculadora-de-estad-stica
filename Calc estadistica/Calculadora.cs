using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_estadistica
{
    internal class Calculadora
    {

        public List<double> NumberList { get; set; }
        public Calculadora()
        {
            
        }
        public Calculadora(List<double> numberList)
        {
            NumberList = new List<double>();
        }
        public List<double> accessList()
        {
            return NumberList;
        }
        public void PrintMenu()
        {
            Console.WriteLine("--- Calculadora Estadística con POO---");
            Console.WriteLine("1. Crear Lista.");
            Console.WriteLine("2. Calcular Media.");
            Console.WriteLine("3. Calcular Mediana.");
            Console.WriteLine("4. Calcular Moda.");
            Console.WriteLine("5. Calcular la  Desviación Estándar.");
            Console.WriteLine("6. Volver a Ingresar los Datos.");
            Console.WriteLine("7. Salir");
            Console.Write("Ingrese la opción deseada: ");
        }
        public void FillList()
        {
            int sizeList = 0;
            double enteredNumber = 0;
            try
            {

                NumberList.Clear();
                Console.Write("Ingrese el número de datos: ");
                sizeList = int.Parse(Console.ReadLine());
                if (sizeList <= 0)
                {
                    Console.WriteLine("Error: No puede ingresar valores nulos o menores a 0");
                    return;
                }
                for (int i = 0; i < sizeList; i++)
                {
                    Console.Write($"Ingrese el dato de la posición {i + 1}: ");
                    enteredNumber = double.Parse(Console.ReadLine());
                    if (enteredNumber < 0)
                    {
                        Console.WriteLine("Error: No puede ingresar valores nulos");
                        return;
                    }
                    NumberList.Add(enteredNumber);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message} ");
                Console.ReadKey();
            }
        }
        public void PrintList()
        {
            NumberList = NumberList.OrderBy(n => n).ToList();
            foreach (double item in NumberList)
            {
                Console.WriteLine(item);
            }
        }
        public double CalculateMean()
        {
            double mean = 0, additionmean = 0;
            int cont = 0;
            foreach (double item in NumberList)
            {
                additionmean += item;
            }
            mean = additionmean / NumberList.Count();
            return mean;
        }
        public double CalculateMode()
        {
            double moda = NumberList[0];
            int maxCount = 0;
            for (int i = 0; i < NumberList.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < NumberList.Count; j++)
                {
                    if (NumberList[i] == NumberList[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    moda = NumberList[i];
                }
            }
            return moda;
        }
        public double CalculateMedian()
        {
            double median = 0;
            int middlenumber = 0;
            NumberList = NumberList.OrderBy(n => n).ToList();
            if (NumberList.Count % 2 == 0)
            {
                middlenumber = NumberList.Count / 2;


                median = (NumberList[middlenumber] + NumberList[middlenumber - 1]) / 2;
            }
            else
            {
                middlenumber = NumberList.Count / 2;
                median = NumberList[middlenumber];
            }
            return median;
        }
        public double CalculateStandardDeviation()
        {
            double mean = CalculateMean(), sum = 0, variance = 0, standardDeviation = 0;
            foreach (double number in NumberList)
            {
                sum += Math.Pow(number - mean, 2);
            }
            variance = sum / NumberList.Count;
            standardDeviation = Math.Sqrt(variance);
            return standardDeviation;
        }
    }
    
}
