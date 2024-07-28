using Calc_estadistica;


internal class Program2
{
    private static void Main(string[] args)
    {
        Calculadora operaciones = new Calculadora();
        bool run = true;
        int option = 0;
        do
        {

            try
            {
                Console.Clear();
                operaciones.PrintMenu();
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
                    operaciones.FillList();
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("--- Media de la Lista ---");
                    Console.WriteLine($"La Media es: {operaciones.CalculateMean()}");
                    Console.WriteLine("De la lista:");
                    operaciones.PrintList();
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("--- Mediana de la Lista ---");
                    Console.WriteLine($"La Mediana es: {operaciones.CalculateMedian()}");
                    Console.WriteLine("De la lista:");
                    operaciones.PrintList();
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("--- Moda de la Lista ---");
                    Console.WriteLine($"La Moda es: {operaciones.CalculateMode()}");
                    Console.WriteLine("De la lista:");
                    operaciones.PrintList();
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("--- Desviación Estándar de la Lista ---");
                    Console.WriteLine($"La Desviación Estándar es: {operaciones.CalculateStandardDeviation()}");
                    Console.WriteLine("De la lista:");
                    operaciones.PrintList();
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    operaciones.FillList();
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
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        } while (run);
    }
}