using System.Collections.Generic;

List<double> NumberList = new List<double>();
 static void PrintMenu()
{
    Console.WriteLine("--- Calculadora Estadística ---");
    Console.WriteLine("1. Calcular Media.");
    Console.WriteLine("2. Calcular Mediana.");
    Console.WriteLine("3. Calcular Moda.");
    Console.WriteLine("4. Calcular la  Desviación Estándar.");
    Console.WriteLine("5. Volver a ingresar los datos.");
    Console.Write("Ingrese la opción deseada: ");
}

static void FillList()
{
    NumberList.Clear();
    Console.Write("Ingrese el número de datos: ");
    int size = int.Parse(Console.ReadLine());
    for (int i= 0; i <= size; i++)
    {
        Console.WriteLine($"Ingrese un número en el espacio {i+1}: ");
        double enteredNumber = double.Parse(Console.ReadLine());
        NumberList.Add(enteredNumber);
    }

}