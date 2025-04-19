using lab4;

internal class Program
{
    private static void Main(string[] args)
    {
        test_cpu();
    }
    private static void test_cpu()
    {
        Console.Write("Введiть модель процесора: ");
        string model = Console.ReadLine();

        Console.Write("Введiть виробника: ");
        string manufacturer = Console.ReadLine();

        Console.Write("Введiть кiлькiсть ядер: ");
        int cores = int.Parse(Console.ReadLine());

        Console.Write("Введiть кiлькiсть потокiв: ");
        int threads = int.Parse(Console.ReadLine());

        Console.Write("Введiть частоту (ГГц): ");
        double frequency = double.Parse(Console.ReadLine());

        Console.Write("Введiть розмiр кешу (МБ): ");
        int cache = int.Parse(Console.ReadLine());

        Console.Write("Введiть TDP (Вт): ");
        int tdp = int.Parse(Console.ReadLine());

        Console.Write("Чи пiдтримує Hyper-Threading? (y - так, n - нi): ");
        ConsoleKeyInfo keyHyperThreading = Console.ReadKey(); Console.WriteLine();

        CPU myCPU = new CPU();

        myCPU.Model = model;
        myCPU.Manufacturer = manufacturer;
        myCPU.Cores = cores;
        myCPU.Threads = threads;
        myCPU.Frequency = frequency;
        myCPU.CacheMB = cache;
        myCPU.TDPWatts = tdp;
        myCPU.HasHyperThreading = keyHyperThreading.Key == ConsoleKey.Y;

        double performance = myCPU.CalculatePerformance();

        Console.WriteLine();
        Console.WriteLine("Інформація про процесор:");
        Console.WriteLine($" Модель: {myCPU.Model}");
        Console.WriteLine($" Виробник: {myCPU.Manufacturer}");
        Console.WriteLine($" Кiлькiсть ядер: {myCPU.Cores}");
        Console.WriteLine($" Кiлькiсть потокiв: {myCPU.Threads}");
        Console.WriteLine($" Частота: {myCPU.Frequency} ГГц");
        Console.WriteLine($" Кеш: {myCPU.CacheMB} МБ");
        Console.WriteLine($" TDP: {myCPU.TDPWatts} Вт");
        Console.WriteLine(myCPU.HasHyperThreading ? " Пiдтримує Hyper-Threading" : " Не пiдтримує Hyper-Threading");
        Console.WriteLine();
        Console.WriteLine($" Індекс продуктивностi: {performance:F2}");
    }

    private void test_town()
    {
        Console.Write("Введiть назву мiста: "); string sName = Console.ReadLine();
        Console.Write("Введiть назву краiни: "); string sCountry = Console.ReadLine();
        Console.Write("Введiть назву регiону: "); string sRegion = Console.ReadLine();
        Console.Write("Введiть кiлькiсть населення: "); string sPopulation = Console.ReadLine();
        Console.Write("Введiть рiчний дохiд: "); string sYearIncome = Console.ReadLine();
        Console.Write("Введiть площу, кв. км: "); string sSquare = Console.ReadLine();
        Console.Write("Чи є у мiстi порт? (y-так, n-нi): "); ConsoleKeyInfo keyHasPort = Console.ReadKey(); Console.WriteLine();
        Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): "); ConsoleKeyInfo keyHasAirport = Console.ReadKey(); Console.WriteLine();

        Town OurTown = new Town();

        OurTown.Name = sName; OurTown.Country = sCountry; OurTown.Region = sRegion;
        OurTown.Population = int.Parse(sPopulation); OurTown.YearIncome = double.Parse(sYearIncome); OurTown.Square = double.Parse(sSquare);
        OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
        OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;

        double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
        Console.WriteLine();
        Console.WriteLine(" "); Console.WriteLine(" Данi про об`ект: ");
        Console.WriteLine(" "); Console.WriteLine(" Назва: " + OurTown.Name);
        Console.WriteLine(" Країна: " + OurTown.Country);
        Console.WriteLine(" Регiон: " + OurTown.Region);
        Console.WriteLine(" Кiлькiсть населення: " +
        OurTown.Population.ToString());
        Console.WriteLine(" Рiчний дохiд: " +
        OurTown.YearIncome.ToString(" 0.00 "));
        Console.WriteLine(" Площа: " + OurTown.Square.ToString(" 0.000 "));
        Console.WriteLine(OurTown.HasPort ? " У мiстi є порт" : " У мiстi нема порту");
        Console.WriteLine(OurTown.HasAirport ? " У мiстi є аеропорт" : " У мiстi нема аеропорту");
        Console.WriteLine();
        Console.WriteLine(" Середнiй річний дохід на одного громадянина:" + YearIncomePerInhabitant.ToString("0.00"));
    }
}