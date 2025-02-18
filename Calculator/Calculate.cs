namespace Calculator
{
    // sealed class so that no other class can inherit, but we can make object of class
    sealed class Calculate
    {
        public void CalculateMethod(double[] numbers)
        {
            double additionAnswer = numbers[0] + numbers[1];
            Console.WriteLine("The sum of {0} and {1} is {2}", numbers[0], numbers[1], additionAnswer);
            double subtractionAnswer = numbers[0] - numbers[1];
            Console.WriteLine("The subtraction of {0} and {1} is {2}", numbers[0], numbers[1], subtractionAnswer);
            double multiplicationAnswer = numbers[0] * numbers[1];
            Console.WriteLine("The multiplication of {0} and {1} is {2}", numbers[0], numbers[1], multiplicationAnswer);
            double devisionAnswer = Division(numbers);
            Console.WriteLine("The division of {0} and {1} is {2}", numbers[0], numbers[1], devisionAnswer);
        }

        private double Division(double[] numbers)
        {
            double answer = numbers[0] / numbers[1];
            if (double.IsInfinity(answer)) // handling error
            {
                Console.WriteLine("Error: Cannot devide by 0");
                return double.NaN;
            }
            else
            {
                return answer;
            }
        }
    }
}
