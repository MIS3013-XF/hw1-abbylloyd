// HW1b Grade

// Your Name: Abby Lloyd
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string studentid;
            string homeworks;
            string participations;
            string quizzes;
            string midterm;
            string finalexam;

            double num1;
            double num2;
            double num3;
            double num4;
            double num5;


            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            studentid = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homeworks = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            participations = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizzes = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midterm = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final exam?");
            finalexam = Console.ReadLine();

            //scores feedback
            num1 = Convert.ToDouble(homeworks);
            num2 = Convert.ToDouble(participations);
            num3 = Convert.ToDouble(quizzes);
            num4 = Convert.ToDouble(midterm);
            num5 = Convert.ToDouble(finalexam);

            //weight
            double homeworksweight = .20;
            double participationsweight = .15;
            double quizzesweight = .15;
            double midtermweight = .25;
            double finalexamweight = .25;

            double finalgrade = (num1 * homeworksweight) + (num2 * participationsweight) + (num3 * quizzesweight) + (num4 * midtermweight) + (num5 * finalexamweight);

            Console.WriteLine(firstname + " " + lastname + " " + "(" + studentid + ")" + "," + " " + "your final grade is " + finalgrade.ToString("N2"));

            Console.ReadKey();
        }
    }
}
