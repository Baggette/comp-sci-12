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
    }
}