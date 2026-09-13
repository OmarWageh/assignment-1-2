namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Calculator Project .");
            while (true)
            {
            
            Console.Write("Please Enter the First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("pleae Enter the Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            var addition = num1 + num2;
            var subtraction = num1 - num2;
            var multiplication = num1 * num2;

            Console.WriteLine($"The Addition Two Numbers are: {addition}");
            Console.WriteLine($"The subtraction Two Numbers are: {subtraction}");
            Console.WriteLine($"The multiplication Two Numbers are: {multiplication}");
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");

            }
            else
            {
                var division = num1 / num2;
                Console.WriteLine($"The Division Two Numbers are: {division}");
            }
                }
           
        }
    }
}
