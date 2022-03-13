namespace SwapNumbers
{
    class SwapNumbers
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Variable a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Variable b:");   
            int b = int.Parse(Console.ReadLine());
            //a = a * b;
            //b = a / b;
            //a = a / b;
            // Or
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("b=" +b);
            Console.WriteLine("a=" +a);

        }
    }

}