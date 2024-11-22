namespace INF_UE5_Pythagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Pythagoras(double a, double b)
        {
            double result = 0;
            result = Math.Pow(b,2) + Math.Pow(a,2);

            return result;
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double c = Pythagoras(a, b);

            lblResult.Text = c.ToString();


        }
    }
}
