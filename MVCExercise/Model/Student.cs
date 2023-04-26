using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Model
{
    internal class Student: Person
    {
        private int _year;

        public int Year
        {
            get
            {
                return this._year;
            }
            set
            {
                if (value != 1 ||  this._year != 2)
                {
                    throw new ArgumentException();
                }
                this._year = value;
            }
        }

        public Student(string first_name, string last_name, int year):base(first_name, last_name) 
        {
            this.Year = year;
        }

        public override string ToString()
        {
            return base.ToString() + $" Year = {this.Year}";
        }
    }
}
