using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    internal class Student : Person
    {
        public Student(PersonInfo info) : base(info)
        {

        }
        public override PersonInfo GetInfo()
        {
            return _info;
        }
    }
}
