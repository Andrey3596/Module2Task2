namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textThreeDigitNumber.Text = Properties.Settings.Default.textThreeDigitNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int threeDigitNumber;
            try 
            {
                threeDigitNumber = int.Parse(this.textThreeDigitNumber.Text);

            }
            catch (FormatException) 
            {
                return;
            }
            Properties.Settings.Default.textThreeDigitNumber = threeDigitNumber;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.CompareDigit(threeDigitNumber));
        }
    }
    public class Logic
    {
        public static string CompareDigit(int threeDigitNumber)
        {
            int firstDigit = threeDigitNumber / 100;
            int secondDigit = (threeDigitNumber - firstDigit * 100) / 10;
            int thirdDigit = (threeDigitNumber - firstDigit * 100 - secondDigit * 10);

            if (firstDigit > secondDigit && firstDigit > thirdDigit)
            {
                return firstDigit.ToString();
            }
            else if (secondDigit > thirdDigit && secondDigit > firstDigit)
            {
                return secondDigit.ToString();
            }
            else
            {
                return thirdDigit.ToString();
            }
        }
    }
}

