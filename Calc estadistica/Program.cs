using System.Collections.Generic;
using System.Text;

List<double> NumberList = new List<double>();
bool run = true;
int option = 0;
do
{
    try
    {
        Console.Clear();
        PrintMenu();
        option = Convert.ToInt32(Console.ReadLine());
      
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
    }
    switch (option)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("--- Llenar Lista ---");
            FillList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("--- Media de la Lista ---");
            Console.WriteLine($"La Media es: {CalculateMean(NumberList)}");
            Console.WriteLine("De la lista:");
            PrintList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("--- Mediana de la Lista ---");
            Console.WriteLine($"La Mediana es: {CalculateMedian(NumberList)}");
            Console.WriteLine("De la lista:");
            PrintList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("--- Moda de la Lista ---");
            Console.WriteLine($"La Moda es: {CalculateMode(NumberList)}");
            Console.WriteLine("De la lista:");
            PrintList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("--- Desviación Estándar de la Lista ---");
            Console.WriteLine($"La Desviación Estándar es: {CalculateStandardDeviation(NumberList)}");
            Console.WriteLine("De la lista:");
            PrintList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 6:
            Console.Clear();
            FillList(NumberList);
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("Saliendo...");
            run = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
} while (run);
     
static void PrintMenu()
{
    Console.WriteLine("--- Calculadora Estadística ---");
    Console.WriteLine("1. Crear Lista.");
    Console.WriteLine("2. Calcular Media.");
    Console.WriteLine("3. Calcular Mediana.");
    Console.WriteLine("4. Calcular Moda.");
    Console.WriteLine("5. Calcular la  Desviación Estándar.");
    Console.WriteLine("6. Volver a Ingresar los Datos.");
    Console.WriteLine("7. Salir");
    Console.Write("Ingrese la opción deseada: ");
}

static void FillList(List<double>numberList)
{
    try
    {
        
        numberList.Clear();
        Console.Write("Ingrese el número de datos: ");
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Ingrese el dato de la posición {i + 1}: ");
            double enteredNumber = double.Parse(Console.ReadLine());
            numberList.Add(enteredNumber);
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error: {ex.Message} ");
    }
}
static void PrintList(List<double> numberList)
{
    foreach (double item in numberList)
    {
        Console.WriteLine(item);
    }
}

static double CalculateMean(List<double> numberList)
{ 
    double mean = 0, additionmean = 0;
    int cont = 0;
    foreach (double item in numberList) 
    {
    additionmean += item;
    }
    mean = additionmean / numberList.Count();
    return mean;
}
static double CalculateMode(List<double> numberList)
{
    double moda = numberList[0];
    int maxCount = 0;
    for(int i = 0; i < numberList.Count;i++) 
    {
        int count = 0;
        for (int j = 0; j < numberList.Count;j++)
        {
            if (numberList[i] == numberList[j]) 
            { 
                count++;  
            }
        }

        if (count > maxCount)
        {  
        maxCount = count; 
        moda = numberList[i];
        }
    }
    return moda;
}
static double CalculateMedian(List<double> numberList)
{
    double median = 0;
    int middlenumber = 0;
    numberList.Order();
    if (numberList.Count % 2 == 0)
    {
        middlenumber = numberList.Count / 2;
        
        
        median = (numberList[middlenumber] + numberList[middlenumber-1])/2;
    }
    else
    {
        middlenumber = numberList.Count/2;
        median = numberList[middlenumber];
    }
    return median;
}
static double CalculateStandardDeviation(List<double> numberList)
{
    
    double mean = CalculateMean(numberList), sum = 0, variance = 0, standardDeviation = 0;
    foreach (double number in numberList)
    {
        sum += Math.Pow(number - mean, 2); 
    }
        variance=  sum/numberList.Count;
    standardDeviation = Math.Sqrt(variance);
    return standardDeviation;
}
