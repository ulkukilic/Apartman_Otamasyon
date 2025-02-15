using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Otamasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SQLHelper sqlHelper = new SQLHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;
            string giderler = "";
             foreach (Control item  in groupBox1.Controls) 
                {
                if (item is CheckBox checkbox && checkbox.Checked)
                {
                    giderler += " "+ item.Text ;
                }
            }
            giderler = giderler.Remove(0, 1);
            SqlParameter p1 = new SqlParameter("Gider",giderler);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);


            sqlHelper.ExecuteProc("Gidelerim", p1, p2, p3);
        }
    }
}