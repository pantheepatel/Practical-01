using Calculator;

// created namespace to avoid duplicate naming
namespace calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // making array with size 2(as given in LMS)
            double[] userInput = new double[2];
            Console.WriteLine("\nCalculator App\n");
            Console.Write("Enter first number:");
            userInput[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            userInput[1] = Convert.ToDouble(Console.ReadLine());

            // calling method to calculate this array
            Calculate calculation = new Calculate();
            calculation.CalculateMethod(userInput); // method to printout answer and calculations
        }
    }
}