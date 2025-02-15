using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apartman_Otamasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SQLHelper SQLHelper = new SQLHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt16(comboBox1.Text);
            int para = (int)numericUpDown1.Value;
            DateTime yeni = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("DaireNo", daireno);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", yeni);

            SQLHelper.ExecuteProc("Odeme_al", p1, p2, p3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable geridonenveri = SQLHelper.GetTable("SELECT * FROM AidatOdemesi");

            foreach (DataRow row in geridonenveri.Rows)
            {
                listBox1.Items.Add(row["DaireNo"].ToString());
                listBox2.Items.Add(row["Para"].ToString());
                listBox3.Items.Add(row["Tarih"].ToString());
            }
        }
    }
}
