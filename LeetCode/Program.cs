namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        //1-task
        var counter = 0;
        var result = 0;
        while (counter < 1000)
        {
            if (counter % 2 == 1) result += counter;
        }
        Console.WriteLine(result);






        //2-task
        var array = int.Parse(Console.ReadLine());
       int [] numbers = new int[array];

        Console.WriteLine("Massiv elementlari:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element[{i}] = {numbers[i]}");
        }
        var max =numbers.Max();
        var min =numbers.Min();
        Console.WriteLine(max);
        Console.WriteLine(min);






        //3-task

        Console.WriteLine("Butun son kiriting (x):");
        if (int.TryParse(Console.ReadLine(), out int x) && x >= 0)
        {
            long factorial = FindFactorial(x);
            Console.WriteLine($"{x}! = {factorial}");
        }
        else
        {
            Console.WriteLine("Iltimos, manfiy bo'lmagan butun son kiriting.");
        }

    }
    static long FindFactorial(int n)
    {
        long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
