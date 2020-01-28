using System;

namespace Lab1App
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string s ="";
            /*
             * Asks user the the number between 3 and 9
            Create a times table using that number
            Output a menu 
            "Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: "
            Based upon selection, output the table with the new orientation, followed by the menu unless 5 is selected.
             */
            Console.WriteLine("Enter a number between 3 and 9");
            num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num);
            //for (int i= 1; i<=num; i++)
            //{
                //s = s + i + " ";
            //}
            //Console.WriteLine(s);

            for(int j = 1; j <= num; j++)
            {
                for(int i = j; i<= j*num; i= i + j)
                {
                    s = s + i + " ";
                }
                Console.WriteLine(s);
                s = "";
            }
        }
    }
}
