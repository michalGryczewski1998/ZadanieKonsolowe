class ConsoleApp
{
    static void Main(string[] args)
    {
        PobracDane();
    }

    private static void PobracDane()
    {
        Console.WriteLine("Podaj liczbę (10-100)");
        _ = int.TryParse(Console.ReadLine(), out int liczba);

        if (liczba >= 10 && liczba <= 100)
        {
            Obliczenia(liczba);
        }
        else
        {
            Console.WriteLine("Podaj liczbę z przedziału 10-100");
            PobracDane();
        }
    }

    private static void Obliczenia(int liczba)
    {
        int wynik = 0;
        List<int> list = new();

        for (int i = 0; i < liczba; i++)
        {
            if (i % 2 != 0)
            {
                wynik += i;
                list.Add(i);
            }
        }
        Console.WriteLine("Wynik: " + wynik);

        ZapisDoPliku(list);
    }

    private static void ZapisDoPliku(List<int> listaDanych)
    {
        try
        {
            TextWriter writer = new StreamWriter("log.txt");

            foreach (var st in listaDanych)
            {
                writer.WriteLine(st);
            }

            writer.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Błąd podczas zapisu do pliku.");
        }
    }
}
