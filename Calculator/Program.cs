using Calculator;

// flow of practical
// we calling method to take user input and storing it in array
// now sharing this array to calculateMethod for further working

// created namespace to avoid duplicate naming
namespace calculator
{
    internal class Calculator
    {
        public static void Main(string[] args)
        {
            // stores returned array from UserInputMethod.
            double[] numbers = UserInput.UserInputMethod();
            // calls method to calculate this array
            Calculate.CalculateMethod(numbers);
        }
    }
}