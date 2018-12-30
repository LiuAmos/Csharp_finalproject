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
            Form4 f4 = new Form4();
            f4.Show();
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
            //form1命名
            this.Text = "評估工作者於新聞標題分類正確度之監控視窗";

            //insert data
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(1,1,'title_1',5,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(2,1,'title_2',5,0,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(3,2,'title_1',2,0,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(4,2,'title_2',2,1,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(5,2,'title_3',3,0,3)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(6,3,'title_1',4,1,1)");
            //work4
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(7,4,'title_1',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(8,5,'title_1',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(9,6,'title_1',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(16,7,'title_1',10,1,1)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(10,4,'title_2',10,0,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(17,5,'title_2',10,0,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(18,6,'title_2',10,0,2)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(14,4,'title_3',10,1,3)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(15,5,'title_3',10,0,3)");
            //check clickbait
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(0,0,'title_check',10,0,0)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(11,1,'title_check',4,0,0)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(12,2,'title_check',2,1,0)");
            Edit("INSERT INTO clickbait(id,worker_id,title,time,clickbait,title_id) VALUES(13,3,'title_check',4,0,0)");


            //Query w1
            string w1_c11= Query("SELECT clickbait FROM clickbait WHERE worker_id=1 AND title_id=1 ");
            string w1_c12 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=1 AND clickbait=1 ");
            string w1_c13 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=1 AND clickbait=0 ");
            string w1_c21 = Query("SELECT clickbait FROM clickbait WHERE worker_id=1 AND title_id=2 ");
            string w1_c22 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=2 AND clickbait=1 ");
            string w1_c23 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>1 AND title_id=2 AND clickbait=0 ");
            //t1
            string w1_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=1");
            //check
            string w1_check_1 = Query("SELECT clickbait FROM clickbait WHERE worker_id=1 AND title_id=0 ");
            string w1_check_2 = Query("SELECT clickbait FROM clickbait WHERE worker_id=0 AND title_id=0 ");

            //Query w2
            string w2_c11 = Query("SELECT clickbait FROM clickbait WHERE worker_id=2 AND title_id=1 ");
            string w2_c12 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=1 AND clickbait=1 ");
            string w2_c13 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=1 AND clickbait=0 ");
            string w2_c21 = Query("SELECT clickbait FROM clickbait WHERE worker_id=2 AND title_id=2 ");
            string w2_c22 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=2 AND clickbait=1 ");
            string w2_c23 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=2 AND clickbait=0 ");
            string w2_c31 = Query("SELECT clickbait FROM clickbait WHERE worker_id=2 AND title_id=3 ");
            string w2_c32 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=3 AND clickbait=1 ");
            string w2_c33 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>2 AND title_id=3 AND clickbait=0 ");
            //t2
            string w2_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=2");
            //check
            string w2_check_1 = Query("SELECT clickbait FROM clickbait WHERE worker_id=2 AND title_id=0 ");
            string w2_check_2 = Query("SELECT clickbait FROM clickbait WHERE worker_id=0 AND title_id=0 ");


            //Query w3
            string w3_c11 = Query("SELECT clickbait FROM clickbait WHERE worker_id=3 AND title_id=1 ");
            string w3_c12 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>3 AND title_id=1 AND clickbait=1 ");
            string w3_c13 = Query("SELECT count(*) FROM clickbait WHERE worker_id<>3 AND title_id=1 AND clickbait=0 ");
            //t3
            string w3_time = Query("SELECT sum(time) FROM clickbait WHERE worker_id=3");
            //check
            string w3_check_1 = Query("SELECT clickbait FROM clickbait WHERE worker_id=3 AND title_id=0 ");
            string w3_check_2 = Query("SELECT clickbait FROM clickbait WHERE worker_id=0 AND title_id=0 ");

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
            if (w1_c21 == "1")
            {
                w1_c2_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w1_c2_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w1_c2_2.Text = w1_c22;
            w1_c2_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w1_c22 == "0")
            {
                w1_c2_2.BackColor = Color.FromArgb(0, 255, 0);
                w1_c2_2.Text = "";
            }
            else
            {
                w1_c2_2.BackColor = Color.FromArgb(255, 0, 0);
            }

            w1_c2_3.Text = w1_c23;
            w1_c2_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w1_c23 == "0")
            {
                w1_c2_3.BackColor = Color.FromArgb(255, 0, 0);
                w1_c2_3.Text = "";
            }
            else
            {
                w1_c2_3.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w1_check
            w1_check1.Text = "";
            if (w1_check_1 == "1")
            {
                w1_check1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w1_check1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w1_check2.Text = "";
            if (w1_check_2 == "1")
            {
                w1_check2.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w1_check2.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w2_c1
            w2_c1_1.Text = "";
            if (w2_c11 == "1")
            {
                w2_c1_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w2_c1_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w2_c1_2.Text = w2_c12;
            w2_c1_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c12 == "0")
            {
                w2_c1_2.BackColor = Color.FromArgb(0, 255, 0);
                w2_c1_2.Text = "";
            }
            else
            {
                w2_c1_2.BackColor = Color.FromArgb(255, 0, 0);
            }

            w2_c1_3.Text = w2_c13;
            w2_c1_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c13 == "0")
            {
                w2_c1_3.BackColor = Color.FromArgb(255, 0, 0);
                w2_c1_3.Text = "";
            }
            else
            {
                w2_c1_3.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w2_c2
            w2_c2_1.Text = "";
            if (w2_c21 == "1")
            {
                w2_c2_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w2_c2_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w2_c2_2.Text = w2_c22;
            w2_c2_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c22 == "0")
            {
                w2_c2_2.BackColor = Color.FromArgb(0, 255, 0);
                w2_c2_2.Text = "";
            }
            else
            {
                w2_c2_2.BackColor = Color.FromArgb(255, 0, 0);
            }

            w2_c2_3.Text = w2_c23;
            w2_c2_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c23 == "0")
            {
                w2_c2_3.BackColor = Color.FromArgb(255, 0, 0);
                w2_c2_3.Text = "";
            }
            else
            {
                w2_c2_3.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w2_c3
            w2_c3_1.Text = "";
            if (w2_c31 == "1")
            {
                w2_c3_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w2_c3_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w2_c3_2.Text = w2_c32;
            w2_c3_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c32 == "0")
            {
                w2_c3_2.BackColor = Color.FromArgb(0, 255, 0);
                w2_c3_2.Text = "";
            }
            else
            {
                w2_c3_2.BackColor = Color.FromArgb(255, 0, 0);
            }

            w2_c3_3.Text = w2_c33;
            w2_c3_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w2_c33 == "0")
            {
                w2_c3_3.BackColor = Color.FromArgb(255, 0, 0);
                w2_c3_3.Text = "";
            }
            else
            {
                w2_c3_3.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w2_check
            w2_check1.Text = "";
            if (w2_check_1 == "1")
            {
                w2_check1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w2_check1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w2_check2.Text = "";
            if (w2_check_2 == "1")
            {
                w2_check2.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w2_check2.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w3_c1
            w3_c1_1.Text = "";
            if (w3_c11 == "1")
            {
                w3_c1_1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w3_c1_1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w3_c1_2.Text = w3_c12;
            w3_c1_2.TextAlign = ContentAlignment.MiddleCenter;
            if (w3_c12 == "0")
            {
                w3_c1_2.BackColor = Color.FromArgb(0, 255, 0);
                w3_c1_2.Text = "";
            }
            else
            {
                w3_c1_2.BackColor = Color.FromArgb(255, 0, 0);
            }

            w3_c1_3.Text = w3_c13;
            w3_c1_3.TextAlign = ContentAlignment.MiddleCenter;
            if (w3_c13 == "0")
            {
                w3_c1_3.BackColor = Color.FromArgb(255, 0, 0);
                w3_c1_3.Text = "";
            }
            else
            {
                w3_c1_3.BackColor = Color.FromArgb(0, 255, 0);
            }

            //w3_check
            w3_check1.Text = "";
            if (w3_check_1 == "1")
            {
                w3_check1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w3_check1.BackColor = Color.FromArgb(0, 255, 0);
            }
            w3_check2.Text = "";
            if (w3_check_2 == "1")
            {
                w3_check2.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                w3_check2.BackColor = Color.FromArgb(0, 255, 0);
            }



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

        private void btn_w1_exp_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btn_w3_exp_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
