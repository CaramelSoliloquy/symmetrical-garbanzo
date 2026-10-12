namespace TheoryExam
{
    public partial class Form1 : Form
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private Random random;

        public Form1()
        {
            InitializeComponent();

            // PLEASE DO NOT MODIFY THIS CODE
            random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write your answer for task 3.1 here

            // Write your answer for task 3.2 here

            // Write your answer for task 3.3 here

            // Write your answer for task 3.4 here
        }

        // PLEASE DO NOT MODIFY THIS CODE

        /// <summary>
        /// Checks whether a given number is a perfect square.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is a perfect square; otherwise, false.</returns>
        private bool IsSquare(int number)
        {
            // Numbers less than 0 are not perfect squares
            if (number < 0)
                return false;

            // Calculate the square root
            int sqrt = (int)Math.Sqrt(number);

            // Check if the square of the integer square root equals the original number
            return (sqrt * sqrt == number);
        }

        // PLEASE DO NOT MODIFY THIS CODE

        /// <summary>
        /// Generates a list of unique random perfect square numbers within a specified range.
        /// </summary>
        /// <param name="count">The number of perfect square numbers to generate.</param>
        /// <param name="min">The inclusive lower bound of the random number range.</param>
        /// <param name="max">The inclusive upper bound of the random number range.</param>
        /// <returns>A list containing up to <paramref name="count"/> unique random perfect square numbers within the specified range.</returns>
        private List<int> GenerateRandomSquares(int count, int min, int max)
        {
            HashSet<int> squares = new HashSet<int>();

            while (squares.Count < count)
            {
                int number = random.Next(min, max + 1);
                if (IsSquare(number))
                {
                    squares.Add(number);
                }
            }
            return new List<int>(squares);
        }
    }
}