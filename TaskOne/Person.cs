namespace TheoryExam
{
    public class Person
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private string firstName;
        private string lastName;
        private int age;

        // Write your answer for task 1.1 here
        public Person(string firstName, string lastName, int age) 
        { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        // Write your answer for task 1.2 here
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }

    }
}
