namespace numberforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            int n;
            if(!int.TryParse(number,out n))
            {
                MessageBox.Show("Wrong input");
            }else 
            { 
            MessageBox.Show(n.ToString());
            }
        }
    }
}