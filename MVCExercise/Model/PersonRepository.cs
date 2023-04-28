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
        // that will store all the students and teachers

        // Repository implementation
        private List<Person> _people;

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

        // Testing
        List<int> test = new List<int>();
      

        private PersonRepository() 
        {
            this._people = new List<Person>();
        }

    }
}
