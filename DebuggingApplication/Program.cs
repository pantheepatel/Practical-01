namespace debuggingApplication
{
    public class DebuggingApplication
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter here: ");
            string userResponse = Console.ReadLine();
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
    }
}