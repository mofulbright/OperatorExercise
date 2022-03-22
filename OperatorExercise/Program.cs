namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            double quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} + {b} is equal to {addition}");
            Console.WriteLine($"{a} - {b} is equal to {subtraction}");
            Console.WriteLine($"{a} * {b} is equal to {multiplication}");
            Console.WriteLine($"{a} / {b} is equal to {quotient} remainder {remainder}");

            Console.WriteLine(AreaOfCircle());

        }
        static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
