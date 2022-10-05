namespace GoodsApp
{
    public partial class GoodForm : Form

    {
        private DataGridView dataGridView1 = new DataGridView();
        private List<Good> Goods= new List<Good>();
        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }


    }


}