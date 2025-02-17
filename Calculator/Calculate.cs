namespace Calculator
{
    internal class Calculate
    {
        public static void CalculateMethod(double[] numbers)
        {
            // can add more methods in future
            string[] methods = { "Addition", "Substraction", "Multiplication", "Division" };
            foreach (var method in methods)
            {
                var methodName = typeof(Calculate).GetMethod(method);
                // checking if method exists in Calculate class or not
                if (methodName != null)
                {
                    // storing returned value of each method
                    double answer = (double)methodName.Invoke(null, new object[] { numbers });
                    Console.WriteLine("\t\tThe {0} of {1} and {2} is: {3}", method, numbers[0], numbers[1], answer);
                }
                else
                {
                    Console.WriteLine("Method {0} not found!", method);
                }
            }
        }

        // for below methods storing it in different variable, so that we can perform something on that(error handling)
        public static double Addition(double[] numbers)
        {
            double answer = numbers[0] + numbers[1];
            return answer;
        }
        public static double Substraction(double[] numbers)
        {
            double answer = numbers[0] - numbers[1];
            return answer;
        }
        public static double Multiplication(double[] numbers)
        {
            double answer = numbers[0] * numbers[1];
            return answer;
        }
        public static double Division(double[] numbers)
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
