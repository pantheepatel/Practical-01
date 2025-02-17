namespace Calculator
{
    internal class UserInput
    {
        public static double[] UserInputMethod()
        {
            // making array with size 2(as given in LMS)
            double[] userInput = new double[2];
            Console.WriteLine("\nCalculator App\n");
            // loop to avoid redundant input taking code from user
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write($"\tEnter number {i+1}: ");
                userInput[i] = Convert.ToDouble(Console.ReadLine());
            }
            return userInput;
        }
    }
}
