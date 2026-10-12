using System.Drawing;

namespace TheoryExam
{
    public partial class Form1 : Form
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();

            // PLEASE DO NOT MODIFY THIS CODE
            people = new List<Person>()
            {
                new Person("Alice", "Brown", 17),
                new Person("Ben", "Dawkins", 21),
                new Person("Clara", "Dawson", 34),
                new Person("George", "Miller", 65),
                new Person("Helen", "Turner", 72)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write your answer for task 1.3 here
            List<Person> peeps = new List<Person>();
            foreach (Person person in people)
            {
                if (person.LastName.StartsWith("D"))
                {
                    peeps.Add(person);
                }
            }
            // Write your answer for task 1.4 here
            listBox1.Items.Clear();
            foreach (var people in peeps) 
            {
                string temp = $"{people.FirstName}, {people.LastName}, {Convert.ToString(people.Age)}";
                listBox1.Items.Add(temp);
            }
            listBox1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Write your answer for task 1.5 here
            List<Person> peeps = new List<Person>();
            foreach (Person person in people)
            {
                if (person.Age >= 25 && person.Age <= 50)
                {
                    peeps.Add(person);
                }
            }
            // Write your answer for task 1.6 here 
            listBox2.Items.Clear();
            foreach (var people in peeps)
            {
                string temp = $"{people.FirstName}, {people.LastName}, {Convert.ToString(people.Age)}";
                listBox2.Items.Add(temp);
            }
            listBox2.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write your answer for task 1.7 here
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
