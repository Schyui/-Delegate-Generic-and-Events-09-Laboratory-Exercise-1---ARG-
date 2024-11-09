namespace frm_Calculator
{
    public partial class FrmCalculator : Form
    {
        private double num1, num2;
        CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }
        public void ArithmeticOperator() {
            if (cbOperator.SelectedItem.Equals("+"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.SelectedItem.Equals("-"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.SelectedItem.Equals("*"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.SelectedItem.Equals("/"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtBoxInput1.Text);
            num2 = Double.Parse(txtBoxInput2.Text);

            ArithmeticOperator();
        }
    }
}
