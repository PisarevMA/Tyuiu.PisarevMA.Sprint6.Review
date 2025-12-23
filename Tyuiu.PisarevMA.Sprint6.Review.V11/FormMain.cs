using Tyuiu.PisarevMA.Sprint6.Review.V11.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Review.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] arrayValues;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_PMA.ColumnCount = 50;
            dataGridViewOut_PMA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewOut_PMA.Columns[i].Width = 25;
            }
        }

        private void buttonGeneration_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxDigitalN_PMA.Text);
                int m = Convert.ToInt32(textBoxDigitalM_PMA.Text);
                int n1 = Convert.ToInt32(textBoxDigitalN1_PMA.Text);
                int n2 = Convert.ToInt32(textBoxDigitalN2_PMA.Text);

                if (n1 < n2)
                {
                    arrayValues = ds.GeneratingMatrix(n, m, n1, n2);
                    dataGridViewOut_PMA.ColumnCount = m;
                    dataGridViewOut_PMA.RowCount = n;

                    for (int i = 0; i < m; i++)
                    {
                        dataGridViewOut_PMA.Columns[i].Width = 25;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewOut_PMA.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonDone_PMA.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxDigitalC_PMA.Text);
                int k = Convert.ToInt32(textBoxDigitalK_PMA.Text);
                int l = Convert.ToInt32(textBoxDigitalL_PMA.Text);
                int n = Convert.ToInt32(textBoxDigitalN_PMA.Text);
                int m = Convert.ToInt32(textBoxDigitalM_PMA.Text);

                if (k <= l && c > -1 && k > -1 && l > -1 && n > 1 && m > 1)
                {
                    textBoxResultat_PMA.Text = ds.result_GetMatrix(arrayValues, c, k, l).ToString();
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }
    }
}