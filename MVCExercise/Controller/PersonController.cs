using MVCExercise.Model;
using MVCExercise.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Controller
{
    internal class PersonController
    {
        private ConsoleView view;
        private PersonRepository repository;

        private static PersonController instance;

        public static void Boot()
        {
            if (instance == null)
                instance = new PersonController();

            while (instance.mainMenu()) ;
        }

        public PersonController()
        {
            this.view = new ConsoleView();
            this.repository = PersonRepository.Instance;
        }

        public bool mainMenu()
        {
            this.view.printChoice();
            switch(this.view.getInputChar("Your choice"))
            {
                case '1':
                    this.showDetails();
                    break;
                case '2':
                    this.editPerson();
                    break;
                case '3':
                    this.addPerson();
                    break;
                case '4':
                    this.remove();
                    break;
                case '5':
                    return false;
                    break;
                default:
                    break;
            }
            return true;
        }

        public void showDetails()
        {
            this.view.ViewDetailsChoice(this.repository.All);
            int index = this.view.getInputInt("Choice");
            this.view.printPersonDetails(this.repository.Select(index - 1));
        }

        public void remove()
        {
            this.view.deleteChoice(this.repository.All);
            int index = this.view.getInputInt("Choice");
            this.view.printPersonDetails(this.repository.Select(index - 1));
        }
        public void addPerson()
        {
            this.view.printAddChoice();
            switch (this.view.getInputChar("Choice"))
            {
                case '1':
                    this.repository.Add(
                        typeof(Teacher),
                        this.view.getInputString("Firstname"),
                        this.view.getInputString("Lastname"),
                        this.view.getInputInt("Salary"));
                    break;
                case '2':
                    this.repository.Add(
                    typeof(Student),
                    this.view.getInputString("Firstname"),
                    this.view.getInputString("Lastname"),
                    this.view.getInputInt("Year"));
                    break;
            }
        }

        public void editPerson()
        {
            this.view.editChoice(this.repository.All);
            int index = this.view.getInputInt("Choice");
            Person p = this.repository.Select(index - 1);
            if (p == null)
                return;

            if (p.GetType() == typeof(Student))
            {
                this.view.EditAttributeChoice(new string[] { "Firstname", "Lastname", "Year" });
            } else
            {
                this.view.EditAttributeChoice(new string[] { "Firstname", "Lastname", "Salary" });
            }

            switch (this.view.getInputChar("Choice"))
            {
                case '1':
                    p.first_name = this.view.getInputString("Firstname");
                    break;
                case '2':
                    p.last_name = this.view.getInputString("Lastname");
                    break;
                case '3':
                    if (p.GetType() == typeof(Student))
                    {
                        Student st = (Student) p;
                        st.Year = this.view.getInputInt("Year");
                        this.repository.Edit(index, st);
                    }
                    else
                    {
                        Teacher t = (Teacher)p;
                        t.Salary = this.view.getInputInt("Salary");
                        this.repository.Edit(index, t);
                    }
                    break;
            }
         }
    }
}
