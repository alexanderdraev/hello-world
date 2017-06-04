using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numberOfPeople / capacity;
            int rest = numberOfPeople % capacity;

            if (rest == 0)
            {
                Console.WriteLine(courses);
            }
            else if (rest != 0)
            {
                Console.WriteLine(courses + rest / rest);
            }
        }
    }
}
