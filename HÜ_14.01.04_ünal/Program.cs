Console.Write("Geben Sie eine positive ganze Zahl ein: ");

int n = Convert.ToInt32(Console.ReadLine());


bool isPrime = IstPrimzahl(n);

if (isPrime)
{
    Console.WriteLine($"{n} ist eine Primzahl.");
}
else
{
    Console.WriteLine($"{n} ist keine Primzahl.");
}
    

    static bool IstPrimzahl(int num)
{

    if (num <= 1)
    {
        return false;
    }


    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false; // Die Zahl ist durch i teilbar, also keine Primzahl
        }
    }

    return true;
}
