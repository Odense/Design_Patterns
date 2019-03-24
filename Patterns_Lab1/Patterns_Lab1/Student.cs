using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab1
{
    class AbstractStudent
    {
        protected Student student;
        public Student Student
        {
            set { student = value; }
        }
        public virtual void PassTest()
        {
            student.PassTest();
        }
    }

    abstract class Student
    {
        public abstract void PassTest();
    }

    class ExcellentStudent : Student
    {
        public override void PassTest()
        {
            Console.WriteLine("Student has all correct answers");
        }
    }

    class GoodStudent : Student
    {
        public override void PassTest()
        {
            Console.WriteLine("Student has 80% correct answers");
        }
    }

    class SatisfactoryStudent : Student
    {
        public override void PassTest()
        {
            Console.WriteLine("Student has 60% correct answers");
        }
    }

    class UnsatisfactoryStudent : Student
    {
        public override void PassTest()
        {
            Console.WriteLine("Student has 40% correct answers");
        }
    }
}
