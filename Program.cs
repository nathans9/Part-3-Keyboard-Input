using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //computer

            string[] computer =
            {
"   _______________  ",
"  |  ___________  | ",
"  | |           | | ",
"  | |   0   0   | | ",
"  | |     -     | | ",
"  | |   \\___/   | | ",
"  | |___     ___| | ",
"  |_____|\\_/|_____| ",
"    _|__|/ \\|_|_    ",
"   / ********** \\   ",
" /  ************  \\ ",
"--------------------"
            };

            for (int line = 0; computer.Length > line; line++)
            {
                Console.WriteLine(computer[line]);
            }

            Random generator = new Random();
            int random = generator.Next(10, 1001);
            int badYear = DateTime.Now.Year;
            Console.WriteLine("Greetings, human.  If you're reading this, this means that you have just emerged from cryo-sleep, and have successfully survived the nuclear holocaust of " + badYear + ".  I have to congratulate you.  You are the first to reawaken.");
            Console.Write("Please enter your name: ");
            string inputName = Console.ReadLine();
            Console.Write("Please enter your age from before the nuclear holocaust (#): ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            int currentYear = badYear + random;
            int currentAge = currentYear - (badYear - inputAge);
            int birthYear = badYear - inputAge;
            Console.WriteLine("The present year is " + currentYear + ", and you, " + inputName + ", born in the year " + birthYear + ", are currently " + currentAge + " years old.");
            Console.WriteLine("");

            //p2

            Console.WriteLine("While you were asleep, I haven't been able to pracise my mental arithmetic.  Please input three whole numbers for me to add.");
            int num1, num2, num3, numSum;
            Console.Write("Integer 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Integer 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Integer 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            numSum = num1 + num2 + num3;
            Console.WriteLine("The sum of those three integers is " + numSum + "!");
            Console.WriteLine("");

            //p3

            Console.WriteLine("I'm still feeling a little rusty.  Please enter three distances for me to find the averages of.");
            double dis1, dis2, dis3, avgDis;
            Console.Write("Distance 1: ");
            dis1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Distance 2: ");
            dis2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Distance 3: ");
            dis3 = Convert.ToDouble(Console.ReadLine());
            avgDis = (dis1 + dis2 + dis3) / 3;
            Console.WriteLine("The average between these three distances is " + Math.Round(avgDis, 2) + " kilometres!");
            Console.WriteLine("");

            //p4

            Console.WriteLine("Lastly, to make sure I'm in shape, please enter the lengths of two sides of a right-angle triangle, and allow me to calculate the hypotenuse.");
            double side1, side2, hyp;
            Console.Write("Side 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            hyp = (Math.Sqrt((Math.Pow(side1, 2)) + (Math.Pow(side2, 2))));
            Console.WriteLine("The length of the hypotenuse is " + Math.Round(hyp, 2) + ".");
            Console.WriteLine();
            Console.WriteLine("This concludes our rendezvous.  Treasure the rest of your life.");

            Console.ReadLine();
        }
    }
}