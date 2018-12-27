using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            //w1_c1
            w1_c1_1.Text = "";
            w1_c1_1.BackColor = Color.FromArgb(0, 255, 0);
            w1_c1_2.Text = "3";
            w1_c1_2.BackColor = Color.FromArgb(255, 0, 0);
            w1_c1_2.TextAlign = ContentAlignment.MiddleCenter;
            w1_c1_3.Text = "4";
            w1_c1_3.BackColor = Color.FromArgb(0, 255, 0);
            w1_c1_3.TextAlign = ContentAlignment.MiddleCenter;

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

        private void w1_c2_1_Click(object sender, EventArgs e)
        {

        }
    }
}
