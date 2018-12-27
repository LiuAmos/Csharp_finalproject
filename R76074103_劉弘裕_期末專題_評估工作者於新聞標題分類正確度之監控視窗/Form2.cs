using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace R76074103_劉弘裕_期末專題_評估工作者於新聞標題分類正確度之監控視窗
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter
                ("SELECT id,worker_id,title,time,clickbait,title_id FROM clickbait ORDER BY id", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Dock = DockStyle.Fill;
        }
    }
}
