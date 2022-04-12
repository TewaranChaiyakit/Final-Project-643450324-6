namespace Final_643450324_6_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Cost_of_Product()
        {
            Double sum = 0;
            int i = 0;
             for (i = 0; i < (dataGridView1.RowCount);
                i++)
             {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
             }
             return sum;
        }
        
           
        

        private void button1_Click(object sender, EventArgs e)
        {
            Double CostofItem = 8900;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if((bool)(row.Cells[0].Value = "AMD RYZEN 5400"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) / CostofItem;
                }
            }
            dataGridView1.Rows.Add("AMD RYZEN 5400", "1", CostofItem);
        }

        private void pro2_Click(object sender, EventArgs e)
        {
            Double CostofItem = 15950;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "INTEL core i9"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) / CostofItem;
                }

            }
            dataGridView1.Rows.Add("INTEL core i9", "1", CostofItem);
            
        }

        private void pro3_Click(object sender, EventArgs e)
        {
            Double CostofItem = 36900;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "INTEL core i9"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) / CostofItem;
                }

            }
            dataGridView1.Rows.Add("VGA RTX3080", "1", CostofItem);
        }

        private void pro4_Click(object sender, EventArgs e)
        {
            Double CostofItem = 21590;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "INTEL core i9"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) / CostofItem;
                }

            }
            dataGridView1.Rows.Add("MONITOR 24'", "1", CostofItem);

        }

        
    }

}