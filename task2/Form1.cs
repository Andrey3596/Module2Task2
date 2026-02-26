namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public class Logic
        {
            public static int CompareDigit(int threeDigitNumber)
            {
                int firstDigit = threeDigitNumber / 100;
                int secondDigit = (threeDigitNumber - firstDigit * 100) / 10;
                int thirdDigit = (threeDigitNumber - firstDigit * 100 - secondDigit * 10);

                if (firstDigit > secondDigit && firstDigit > thirdDigit)
                {
                    return firstDigit;
                }
                else if (secondDigit > thirdDigit && secondDigit > firstDigit)
                {
                    return secondDigit;
                }
                else
                {
                    return thirdDigit;
                }

            }
        }
    }
}
