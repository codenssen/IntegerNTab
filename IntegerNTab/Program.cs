namespace IntegerNTab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un entier (entre 1 et 1000) :");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] outputTab = new int[input];

            outputTab = SumZero(input);
            foreach (int i in outputTab)
            {
                Console.WriteLine(i);
            }

        }
        static int[] SumZero(int n)
        {
            int[] result = new int[n];
            int index = 0;

            if (n % 2 != 0)
            {
                result[index] = 0;
                index++;
                n--;
            }

            for (int i = 1; i <= n / 2; i++)
            {
                int randomInt = new Random().Next(1, n);
                result[index] = i * randomInt;
                index++;
                result[index] = -i * randomInt;
                index++;
            }

            return result;
        }
    }
}
