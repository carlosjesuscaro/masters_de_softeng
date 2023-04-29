using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Model
{
    internal class PersonRepository
    {
        // Singleton implementation
        private static PersonRepository _instance;
        public static PersonRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PersonRepository();
                return _instance;
            }
            // set is not required because the value will not be modified
        }
        // The overall purpose is to ensure there is only one repo (a list in this case)
        // that will store all the students and teachers. 'This' represents  the instance
        // and this._people is the list of people

        // Repository implementation
        private List<Person> _people;
        
        private PersonRepository() 
        {
            this._people = new List<Person>();
        }

        public List<Person> All
        {
            get
            {
                return _people;
            }
        }

        public Person? Select(int index)
        {
            return index < this._people.Count && index >= 0 ? this._people[index] : null;
            // it returns null if the condition is false
        }
        // the ? shows that the return could be a null

        public bool Remove(int index)
        {
            if (index >= this._people.Count || index < 0)
            {
                return false;
            }
            this._people.RemoveAt(index);
            return true;
        }

        public bool Remove(Person toRemove)
        {
            return this._people.Remove(toRemove);
            // this 'Remove' is from the class List
        }

        public bool Edit(int index, Person np)
        {
            Person p = this.Select(index);
            if (p == null)
            {
                return false;
            }
            // p is the Person with the old information
            // np is the Person with the new information

            p.first_name = np.first_name;
            p.last_name = np.last_name;

            if (p.GetType() == typeof(Teacher) && np.GetType() == typeof(Teacher))
            {
                Teacher t = (Teacher)p;
                Teacher nt = (Teacher)np;
                t.Salary = nt.Salary;
                return true;
            }
            if (p.GetType() == typeof(Student) && np.GetType() == typeof(Student))
            {
                Student s = (Student)p;
                Student ns = (Student)np;
                s.Year = ns.Year;
                return true;
            }
            return false;
        }

        public Person? AddPerson(Person p)
        {
            if (p == null)
            {
                return null;
            }

            this._people.Add(p);
            return p;
        }

        public Person? Add(Type personType, string fname, string lname, int value)
        {
            Person p = this.Create(personType, fname, lname, value);
            return this.AddPerson(p);
        }
        
        // Factory design pattern:
        public Person? Create(Type personType, string fname, string lname, int value)
        {
            if (personType == typeof(Student))
            {
                return CreateStudent(fname, lname, value);
            }
            if (personType == typeof(Teacher))
            {
                return CreateTeacher(fname, lname, value);
            }

            return null;
        }

        private Teacher CreateTeacher(string fname, string lname, int salary)
        {
            return new Teacher(fname, lname, salary);
        }
        
        private Student CreateStudent(string fname, string lname, int year)
        {
            return new Student(fname, lname, year);
        }
    }
}
