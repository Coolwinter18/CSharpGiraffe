using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            this.name = aName;
            this.major = aMajor;
            this.gpa = aGpa;

        }
        public bool HasHonors()
        {
            if (gpa>=3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
