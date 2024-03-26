// See https://aka.ms/new-console-template for more information

Console.WriteLine("Heldddslo, World!");
Console.WriteLine("Modyfikacja1");
Console.WriteLine("Modyfikacja2");
Console.WriteLine("Modyfikacja3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double) sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int maxim = 0;
    foreach (var number in numbers)
    {
        if (number > maxim)
        {
            maxim = number;
        }
    }

    return maxim;
}