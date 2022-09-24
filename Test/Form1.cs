namespace Test
{
    public partial class Form1 : Form
    {
        IProductRepository repo;

        public Form1(IProductRepository repo)
        {
            InitializeComponent();
            this.repo = repo;
            dataGridView1.DataSource = repo.GetProducts().ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new Adding(repo))
            {
                frm.ShowDialog();

                dataGridView1.DataSource = repo.GetProducts().ToList();
            };
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            using(var frm = new Adding(repo))
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                
                frm.productName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                frm.description = dataGridView1.Rows[index].Cells[2].Value.ToString();
                frm.price = Convert.ToDecimal(dataGridView1.Rows[index].Cells[3].Value);
                frm.id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                frm.ShowDialog();
                
                dataGridView1.DataSource = repo.GetProducts().ToList();
            };
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

            repo.DeleteProductById(id);

            dataGridView1.DataSource = repo.GetProducts().ToList();
        }
    }
}