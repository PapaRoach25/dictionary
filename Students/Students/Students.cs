using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Students
    {
        private Dictionary<string, int> students = new Dictionary<string, int>();
        

        public void AddStudent(string enteredStr)
        {

            string[] surname_key = enteredStr.Split(new char[] { "(.*):([1 - 5])" });
            string studentSurname = surname_key[0];
            int studentMark = Convert.ToInt32(surname_key[1]);
            if (studentMark < 1 || studentMark > 5)
            {
                Console.WriteLine("Mark should be a number from 1 to 5. Try again");
            }
            students.Add(studentSurname, studentMark);
        }

        public void listOfStudent()
        {
            foreach (KeyValuePair<string, int> keyValue in students)
            {
                Console.WriteLine(keyValue.Key + ":" + keyValue.Value);
            }
        }

        public bool isDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
