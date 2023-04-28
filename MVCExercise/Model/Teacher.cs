using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Model
{
    internal class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get
            {
                return this._salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this._salary = value;
            }
        }

        public Teacher(string first_name, string last_name, int salary) : base(first_name, last_name)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary = {this.Salary}";
        }
    }
}
