using BLL.EntityList;
using BLL.EntityManager;
using DAL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
        }



        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList prds = ProductManager.SelectAllProducts();
                this.dataGridView1.DataSource = prds;
            }
            catch
            {

            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //
        }
        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList prds = ProductManager.OrderByPrice();
            this.dataGridView1.DataSource = prds;
        }
        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void quantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList prds = ProductManager.OrderByQuantity();
            this.dataGridView1.DataSource = prds;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Search Button not used
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            //By ID textBox
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            //By Name textBox
        }

        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ProductManager.SelectAllProducts().Where(p => p.InStock == true).ToList();
        }
    }
}
