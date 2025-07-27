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

   

            //string input = "seka";
            //int number = Convert.ToInt32(input);
            //Console.WriteLine($"Converted number: {number}");

            // Output: Unhandled exception. System.FormatException: The input string 'seka' was not in a correct format.
            #endregion

            #region Q3

            //float P1 =(float) 1.40 ;
            //float P2 = (float)1.50;
            //float Result = P1 + P2;
            //Console.WriteLine(  Result);

            ////OR
            //float P01 = 2.40f;
            //float P02 = 2.50f;
            //float Result02 = P1 + P2;

            //Console.WriteLine(Result02);


            //output is 2.9 // Explicit Casting


            #endregion

            #region Q4
            string x = "think before u click  ";
          
            Console.WriteLine(x.Substring(5));

            #endregion

        }
    }
}
