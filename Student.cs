using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public string major;
        public static int studentCount = 0;
        private double gpa;
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            studentCount++;
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    gpa = value;
                }
                else
                {
                    gpa = 0;
                }
            }
        }


        public bool HasHonors() => gpa >= 3.5;

        public int GetStudentCount() => studentCount;
    
    }
}
