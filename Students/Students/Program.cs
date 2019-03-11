using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 2");
            Console.WriteLine("Please enter students and their marks: (enter 'stop' to finish):");
            Students list = new Students();

            string enteredStr;
            bool isInputFinished = true;

            while (isInputFinished) {
                try
                {
                    enteredStr = Console.ReadLine();

                    if (enteredStr == "stop")
                    {
                        isInputFinished = false;
                        break;
                    }
                    else
                    {
                        list.AddStudent(enteredStr);
                    }
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Input has wrong format! Desired format: 'Surname:Mark'");
                    Console.WriteLine("Mark should be a number from 1 to 5'");
                    continue;
                }





            } 

            list.listOfStudent();
            Console.ReadLine();

            
        
            

        }
    }
}
