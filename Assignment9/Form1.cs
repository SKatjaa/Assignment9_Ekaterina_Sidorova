using System.Diagnostics.Metrics;

namespace Assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            
            int[] charCount = new int[256];
            int length = userInput.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[userInput[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[userInput[i]])
                {
                    maxCount = charCount[userInput[i]];
                    character = userInput[i];
                }
            }

            if (character.Equals(' '))
            {
                label2.Text = "The most frequent character in your string is: ' '";
            }
            else
            {
                label2.Text = "The most frequent character in your string is: " + character;
            }
            label2.Visible = true;
            label3.Text = "It appears " + maxCount + " times";
            label3.Visible = true;

        }
    }
}