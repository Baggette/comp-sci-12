using System.Data;

namespace claculator
{
    public partial class Form1 : Form
    {

        private string calcValues = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            calcValues += (sender as Button).Text;
            resultOutput.Text = calcValues;
        }

        private void btn_equals(object sender, EventArgs e)
        {
            string formcalc = calcValues.ToString().Replace("X", "*").ToString().Replace("÷", "/");

            try
            {
                resultOutput.Text = new DataTable().Compute(formcalc, null).ToString();
                calcValues = resultOutput.Text;
            }

            catch (Exception ex)
            {
                resultOutput.Text = "0";
                calcValues = "";
            }
        }
        private void btn_clear(object sender, EventArgs e) 
        {
            resultOutput.Text = "0";
            calcValues = "";
        }

        private void btn_clear_last(object sender, EventArgs e)
        {

            if (calcValues.Length > 0)
            {
                calcValues = calcValues.Remove(calcValues.Length - 1, 1);
            }
            resultOutput.Text = calcValues;
        }
    }
}