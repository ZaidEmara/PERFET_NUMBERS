namespace PERFECT_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int start, end, factor, i, sum;

            Console.WriteLine("start and end of range:");

            Console.WriteLine("Enter start");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine("perfect numbers are ");

            for (i = start; i <= end; i++)
            {

                factor = 1;
                sum = 0;
                while (factor < i)
                {
                    if (i % factor == 0)

                        sum += factor;
                    factor++;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}