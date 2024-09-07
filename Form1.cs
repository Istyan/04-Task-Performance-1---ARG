using System.Text;

namespace GuessingGameWinAPPS
{
    public partial class Form1 : Form
    {
        private readonly string wordGuess = "computer";
        private readonly StringBuilder wrongGuess = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Guess = GuessTextBox.Text.Trim();
            if (string.Equals(Guess, wordGuess, StringComparison.OrdinalIgnoreCase))
            {
                WordToGuess.Text = wordGuess;
                MessageBox.Show("You Guessed Correctly!", "Correct Guess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                wrongGuess.AppendLine(Guess);
                Attempts.Items.Add(Guess);

                MessageBox.Show("Wrong Guess, Please Try Again!", "Incorrect Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GuessTextBox.Clear();
        }

        private string givenClue(string word)
        {
            StringBuilder wordClue = new StringBuilder();
            wordClue.Append(word[0]);
            wordClue.Append(new string('?', word.Length - 2));
            wordClue.Append(word[word.Length - 1]);
            return wordClue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WordToGuess.Text = givenClue(wordGuess);
        }

        private void WordToGuess_Click(object sender, EventArgs e)
        {

        }
    }
}
