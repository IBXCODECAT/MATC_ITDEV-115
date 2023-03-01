using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_StudentStudyApp
{
    internal class Student
    {
        private double[] hours = new double[7];

        //Not sure what these are for exactly, used them to contain propreties because they were in the class diagram
        private int id;
        private string name = string.Empty;
        
        //What is the point of having both propreties and private variables?
        internal int ID { get { return id; } set { id = value; } }
        internal string Name { get { return name; } set { name = value; } }

        internal double CalculateAvg()
        {
            double result = 0;

            foreach(double hour in hours)
            {
                result += hour;
            }

            result /= hours.Length;

            return result;
        }

        internal void EnterHours(int index, double hrs)
        {
            hours[index] = hrs;
        }

        internal double[] GetNumberHours()
        {
            return hours;
        }
    }
}
