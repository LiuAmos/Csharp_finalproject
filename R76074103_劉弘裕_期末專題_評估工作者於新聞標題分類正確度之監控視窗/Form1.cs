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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_w1.Text = "Reject";
        }

        private void btn_w1_app_Click(object sender, EventArgs e)
        {
            lbl_w1.Text = "Approve";
        }

        private void btn_w2_exp_Click(object sender, EventArgs e)
        {

        }

        private void btn_w2_app_Click(object sender, EventArgs e)
        {
            lbl_w2.Text = "Approve";
        }

        private void btn_w3_app_Click(object sender, EventArgs e)
        {
            lbl_w3.Text = "Approve";
        }

        private void btn_w2_rej_Click(object sender, EventArgs e)
        {
            lbl_w2.Text = "Reject";
        }

        private void btn_w3_rej_Click(object sender, EventArgs e)
        {
            lbl_w3.Text = "Reject";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //insert data
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('1',1,'a',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('2',1,'b',10,1,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('3',2,'a',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('4',2,'b',10,0,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('5',2,'c',10,0,3)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('6',3,'a',10,0,1)");

            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('7',4,'a',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('8',4,'a',10,0,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES('9',4,'a',10,1,1)");

            //Query w1
            string w1_c11= Query("SELECT clickbait FROM clickbait WHERE worker_id=1 AND title_id=1 ");
            string w1_c12 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=1 AND clickbait=1 ");
            string w1_c13 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=1 AND clickbait=0 ");
            string w1_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=1");

            //Query w2
            string w2_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=2");

            //Query w3
            string w3_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=3");

            //lbl_line1
            lbl_line1.Text = "";
            lbl_line1.BackColor= Color.FromArgb(192, 192, 192);
            lbl_line2.Text = "";
            lbl_line2.BackColor = Color.FromArgb(192, 192, 192);
            lbl_line3.Text = "";
            lbl_line3.BackColor = Color.FromArgb(192, 192, 192);
            lbl_line4.Text = "";
            lbl_line4.BackColor = Color.FromArgb(192, 192, 192);

            //btn backcolor
            btn_w1_exp.BackColor = Color.FromArgb(104,185,255);
            btn_w2_exp.BackColor = Color.FromArgb(104, 185, 255);
            btn_w3_exp.BackColor = Color.FromArgb(104, 185, 255);
            btn_w1_app.BackColor = Color.FromArgb(172, 238, 129);
            btn_w2_app.BackColor = Color.FromArgb(172, 238, 129);
            btn_w3_app.BackColor = Color.FromArgb(172, 238, 129);
            btn_w1_rej.BackColor = Color.FromArgb(255, 125, 111);
            btn_w2_rej.BackColor = Color.FromArgb(255, 125, 111);
            btn_w3_rej.BackColor = Color.FromArgb(255, 125, 111);

            //btn forecolor
            btn_w1_exp.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w2_exp.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w3_exp.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w1_app.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w2_app.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w3_app.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w1_rej.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w2_rej.ForeColor = Color.FromArgb(255, 255, 255);
            btn_w3_rej.ForeColor = Color.FromArgb(255, 255, 255);

            //btn font
            btn_w1_exp.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w2_exp.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w3_exp.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w1_app.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w2_app.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w3_app.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w1_rej.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w2_rej.Font = new Font("微軟正黑體", 8, FontStyle.Bold);
            btn_w3_rej.Font = new Font("微軟正黑體", 8, FontStyle.Bold);

            //label1-4
            label1.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            label2.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            label3.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            label4.Font = new Font("微軟正黑體", 10, FontStyle.Bold);

            //lbl_w1-3
            lbl_w1.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lbl_w2.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lbl_w3.Font = new Font("微軟正黑體", 9, FontStyle.Regular);

            //lbl_w1_time1-3
            lbl_w1_time.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lbl_w2_time.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lbl_w3_time.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lbl_w1_time.Text = w1_time+" s";
            lbl_w2_time.Text = w2_time + " s";
            lbl_w3_time.Text = w3_time + " s";


            //w1_c1
            w1_c1_1.Text = "";
            if (w1_c11 == "1")
            {
                w1_c1_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else {
                w1_c1_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w1_c1_2.Text = w1_c12;
            w1_c1_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w1_c12 =="0")
            {
                w1_c1_2.BackColor = Color.FromArgb(0, 255, 0);
                w1_c1_2.Text = "";
            }
            else
            {
                w1_c1_2.BackColor = Color.FromArgb(255, 0, 0);
            }
            
            w1_c1_3.Text = w1_c13;
            w1_c1_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w1_c13 == "0")
            {
                w1_c1_3.BackColor = Color.FromArgb(255, 0, 0);
                w1_c1_3.Text = "";
            }
            else
            {
                w1_c1_3.BackColor = Color.FromArgb(0, 255, 0);
            }
            

            //w1_c2
            w1_c2_1.Text = "";
            w1_c2_1.BackColor = Color.FromArgb(255, 0, 0);
            w1_c2_2.Text = "2";
            w1_c2_2.BackColor = Color.FromArgb(255, 0, 0);
            w1_c2_2.TextAlign = ContentAlignment.MiddleCenter;
            w1_c2_3.Text = "1";
            w1_c2_3.BackColor = Color.FromArgb(0, 255, 0);
            w1_c2_3.TextAlign = ContentAlignment.MiddleCenter;


        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string Query(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                string result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        private void w1_c2_1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
