namespace C__Basics_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01

            #region Q1

            //Console.WriteLine(  "Enter Your Name: ");

            //String Name = Console.ReadLine();

            //Console.WriteLine(  $"Your Name Is: {Name}");

            #endregion

            #region Q2

   

            string input = "seka";
            int number = Convert.ToInt32(input);
            Console.WriteLine($"Converted number: {number}");

            // Output: Unhandled exception. System.FormatException: The input string 'seka' was not in a correct format.
            #endregion


        }
    }
}
