using System;
using System.Collections.Generic;
using System.Linq;
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

        // Repository implementation
        private List<Person> _people;
        private PersonRepository() 
        {
            this._people = new List<Person>();
        }

    }
}
