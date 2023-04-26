using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Model
{
    internal class Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }

        public Person (string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }
    }
}
