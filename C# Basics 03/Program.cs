using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //string x = "think before u click  ";

            //Console.WriteLine(x.Substring(5));

            #endregion

            #region Q5

            //int Num01 = 5;
            //int Num02 = 10;

            //Num02 = Num01; //Num02 refer to the value of Num01
            //Console.WriteLine(  Num02); //Num02 =5

            //// value of 10 unreachable
            #endregion

            #region Q6


            //Point P1 = new Point();
            //P1.X = 10;
            //P1.Y = 50;
            //P1.X = P1.Y;
            //Console.WriteLine( $"P1.X : { P1.X}");//50
            //Console.WriteLine($"P1.Y :{P1.Y}");//50
            #endregion

            #region Q7

            //string S1 = "sayed ";
            //string S2 = "kabeil ";
            //string S3 = S1 + S2;
            //Console.WriteLine(  S3);



            #endregion

            #region Q8
            //Console.WriteLine("Enter principal:  ");
            //double principal = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter RateOfInterests:  ");
            //double RateOfInterests = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time :  ");
            //double time = double.Parse(Console.ReadLine());

            //double Interest = (principal * RateOfInterests * time) / 100;
            //Console.WriteLine( $" Interest : { Interest}");

            #endregion

            #region Q9
            //Console.WriteLine("Enter your  Weight KG:  ");
            //double Weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your Height meter :  ");
            //double Height = double.Parse(Console.ReadLine());


            //double BMI = (Weight) / (Height * Height);
            //Console.WriteLine($"  MY BMI : {BMI}");

            #endregion

            #region Q10


            //Console.WriteLine( "Enter The Temprature in degrees :" );

            //double Temprature = double.Parse( Console.ReadLine() );

            //string result = (Temprature < 10) ? "Just Cold" :
            //    (Temprature > 30) ? " Just Hot" :
            //    "Just Good ";  // Using nested ternary operator


            //Console.WriteLine(result );
            #endregion

            #region Q11

            //Console.WriteLine(  "Enter Day :");
            //int Day =int.Parse( Console.ReadLine() );
            //Console.WriteLine("Enter Month: ");
            //int Month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Year: ");
            //int Year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Today's date : {Day},{Month},{Year} ");
            //Console.WriteLine($"Today's date : {Day}/{Month}/{Year} ");
            //Console.WriteLine($"Today's date : {Day}-{Month}-{Year} ");

            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            ///// OutPut is : c. The event is on 06/14/2024

            #endregion

            #region Q13
            //13.Which of the following statements is correct about the
            //  C#.NET code snippet given below?
            //    int d;
            //   d = Convert.ToInt32(!(30 < 20));
            //// output is : 1 

            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //output is:  d. 6 1
            // 6 should be int becase int default


            #endregion

            #region Q15
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //Output is: 7 7

            #endregion
            /////////// Part 2 /////////////////////////////////////////////////////////
            #region Q1 Part 2
            //Console.WriteLine(  "Enter Number");
            //int Number = int.Parse( Console.ReadLine() );
            //if (Number %4 ==0 && Number %3==0)
            //{
            //    Console.WriteLine("Yes");


            //}

            //else { Console.WriteLine(   "No"); }

            #endregion

            #region Q2
            //Console.WriteLine(" Enter Number : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine(" Number is negative");
            //}
            //if (num > 0)
            //{
            //    Console.WriteLine(" Number is positive");
            //}

            //else if (num == 0)
            //{
            //    Console.WriteLine(" number is Zero");

            //}
            #endregion


            #region Q3


            //Console.WriteLine(  "Enter number01: ");
            //int number01 =int.Parse( Console.ReadLine() );
            //Console.WriteLine("Enter number02: ");
            //int number02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number03: ");
            //int number03 = int.Parse(Console.ReadLine());

            //int max = Math.Max(number01,Math.Max(number02,number03));
            //int min = Math.Min(number01, Math.Min(number02, number03));
            //Console.WriteLine(  $"MAx Element is {max}");
            //Console.WriteLine($"Min Element is : {min}  ");

            #endregion
            #region Q4
            Console.WriteLine( "Enter num ");

            int num = int.Parse( Console.ReadLine() );

            if (num % 2 == 0)
            {
                Console.WriteLine(" is even ");

            }
            else { Console.WriteLine(   " is odd "); }
            #endregion

        }
    }
}

