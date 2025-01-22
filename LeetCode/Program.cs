namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = MySqrt(64);
            Console.WriteLine(n);
        }
        public static int MySqrt(int x)
        {
            int result = 0;
            for (var i = 2; i < x; i++)
            {
                if (x / i == i)
                {
                   result = i; 
                }
            
            }
            return result;
        }
    }
}
