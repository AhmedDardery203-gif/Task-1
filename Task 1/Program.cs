namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int laa = 35;
            int smm = 25;
            decimal tax = 6.6m;

            Console.WriteLine("Number of large carpets");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of small carpets");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price per large carpet:$35");
            Console.WriteLine("price per small carpet:$25");
            decimal laaa = large * laa;
            Console.WriteLine($"{laaa:C}");
            decimal smmm = small * smm;
            Console.WriteLine($"{smmm:C}");
            decimal cost = laaa + smmm;
            Console.WriteLine($"cost={cost:c}");
            Console.WriteLine("tax=6.6");
            decimal total = cost + tax;
            Console.WriteLine($"total estimate:{total}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
