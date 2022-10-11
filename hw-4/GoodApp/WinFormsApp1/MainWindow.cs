
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {
        private List<Good> goods = new List<Good>();
        internal List<Good> Goods { get => goods; set => goods = value; }

        public MainWindow()
        {
            InitializeComponent();
            this.AddToData(new Book(300, "Ukraine", "Kobzar", "21.12.2021", "Cool", 346, "Knyga", "Taras"), myDataGrid);
            this.AddToData(new Food(30, "Ukraine", "Milk", "21.12.2021", "Tadty", 23, 1, "L"), myDataGrid);
        }


        private void AddToData(Good good, DataGridView dataGridView)
        {
            dataGridView.Rows.Add();
            dataGridView.Rows[^1].Cells[0].Value = good.Name;
            dataGridView.Rows[^1].Cells[1].Value = good.Price;
            dataGridView.Rows[^1].Cells[2].Value = good.Country;
            dataGridView.Rows[^1].Cells[3].Value = good.DateOfProd;
            dataGridView.Rows[^1].Cells[4].Value = good.Describtion;
            goods.Add(good);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            double price;
            int numberOfPages = 0;
            if (!double.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Price should be numeric");
                return;
            }
            else if (!int.TryParse(textBox6.Text, out numberOfPages))
            {
                MessageBox.Show("Number of pages should be int and greater than 0");
                return;
            }
            try
            {
                Book result = new Book(price, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, numberOfPages, textBox7.Text, textBox8.Text);
                Goods.Add(result);
                AddToData(result, myDataGrid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            double price;
            int daysOfExp;
            int amount;
            if (!double.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Price should be numeric");
                return;
            }
            else if (!int.TryParse(textBox10.Text, out daysOfExp))
            {
                MessageBox.Show("Expire days should be int");
                return;
            }
            else if (!int.TryParse(textBox11.Text, out amount))
            {
                MessageBox.Show("Amount should be int");
                return;
            }
            try
            {
                Food result = new Food(price, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, daysOfExp, amount, textBox11.Text);
                Goods.Add(result);
                AddToData(result, myDataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in myDataGrid.SelectedRows)
            {
                myDataGrid.Rows.Remove(row);
                goods.RemoveAt(row.Index + 1);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}