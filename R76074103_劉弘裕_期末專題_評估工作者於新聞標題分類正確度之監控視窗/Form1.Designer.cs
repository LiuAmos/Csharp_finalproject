namespace R76074103_劉弘裕_期末專題_評估工作者於新聞標題分類正確度之監控視窗
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_w1 = new System.Windows.Forms.Label();
            this.lbl_w2 = new System.Windows.Forms.Label();
            this.lbl_w3 = new System.Windows.Forms.Label();
            this.btn_w1_exp = new System.Windows.Forms.Button();
            this.btn_w1_app = new System.Windows.Forms.Button();
            this.btn_w1_rej = new System.Windows.Forms.Button();
            this.btn_w2_exp = new System.Windows.Forms.Button();
            this.btn_w2_app = new System.Windows.Forms.Button();
            this.btn_w2_rej = new System.Windows.Forms.Button();
            this.btn_w3_exp = new System.Windows.Forms.Button();
            this.btn_w3_app = new System.Windows.Forms.Button();
            this.btn_w3_rej = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_line1 = new System.Windows.Forms.Label();
            this.lbl_line2 = new System.Windows.Forms.Label();
            this.lbl_line3 = new System.Windows.Forms.Label();
            this.lbl_line4 = new System.Windows.Forms.Label();
            this.w1_c1_1 = new System.Windows.Forms.Label();
            this.w1_c1_2 = new System.Windows.Forms.Label();
            this.w1_c1_3 = new System.Windows.Forms.Label();
            this.w1_c2_1 = new System.Windows.Forms.Label();
            this.w1_c2_2 = new System.Windows.Forms.Label();
            this.w1_c2_3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_w1_time = new System.Windows.Forms.Label();
            this.lbl_w2_time = new System.Windows.Forms.Label();
            this.lbl_w3_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anotation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Checks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Time";
            // 
            // lbl_w1
            // 
            this.lbl_w1.AutoSize = true;
            this.lbl_w1.Location = new System.Drawing.Point(26, 126);
            this.lbl_w1.Name = "lbl_w1";
            this.lbl_w1.Size = new System.Drawing.Size(66, 18);
            this.lbl_w1.TabIndex = 4;
            this.lbl_w1.Text = "Approve";
            this.lbl_w1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_w2
            // 
            this.lbl_w2.AutoSize = true;
            this.lbl_w2.Location = new System.Drawing.Point(26, 213);
            this.lbl_w2.Name = "lbl_w2";
            this.lbl_w2.Size = new System.Drawing.Size(66, 18);
            this.lbl_w2.TabIndex = 5;
            this.lbl_w2.Text = "Approve";
            // 
            // lbl_w3
            // 
            this.lbl_w3.AutoSize = true;
            this.lbl_w3.Location = new System.Drawing.Point(26, 298);
            this.lbl_w3.Name = "lbl_w3";
            this.lbl_w3.Size = new System.Drawing.Size(66, 18);
            this.lbl_w3.TabIndex = 6;
            this.lbl_w3.Text = "Approve";
            // 
            // btn_w1_exp
            // 
            this.btn_w1_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w1_exp.Location = new System.Drawing.Point(927, 117);
            this.btn_w1_exp.Name = "btn_w1_exp";
            this.btn_w1_exp.Size = new System.Drawing.Size(87, 37);
            this.btn_w1_exp.TabIndex = 7;
            this.btn_w1_exp.Text = "expand";
            this.btn_w1_exp.UseVisualStyleBackColor = true;
            // 
            // btn_w1_app
            // 
            this.btn_w1_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w1_app.Location = new System.Drawing.Point(1027, 117);
            this.btn_w1_app.Name = "btn_w1_app";
            this.btn_w1_app.Size = new System.Drawing.Size(105, 37);
            this.btn_w1_app.TabIndex = 8;
            this.btn_w1_app.Text = "approve";
            this.btn_w1_app.UseVisualStyleBackColor = true;
            this.btn_w1_app.Click += new System.EventHandler(this.btn_w1_app_Click);
            // 
            // btn_w1_rej
            // 
            this.btn_w1_rej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w1_rej.Location = new System.Drawing.Point(1143, 117);
            this.btn_w1_rej.Name = "btn_w1_rej";
            this.btn_w1_rej.Size = new System.Drawing.Size(71, 37);
            this.btn_w1_rej.TabIndex = 9;
            this.btn_w1_rej.Text = "reject";
            this.btn_w1_rej.UseVisualStyleBackColor = true;
            this.btn_w1_rej.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_w2_exp
            // 
            this.btn_w2_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w2_exp.Location = new System.Drawing.Point(927, 204);
            this.btn_w2_exp.Name = "btn_w2_exp";
            this.btn_w2_exp.Size = new System.Drawing.Size(87, 36);
            this.btn_w2_exp.TabIndex = 10;
            this.btn_w2_exp.Text = "expand";
            this.btn_w2_exp.UseVisualStyleBackColor = true;
            this.btn_w2_exp.Click += new System.EventHandler(this.btn_w2_exp_Click);
            // 
            // btn_w2_app
            // 
            this.btn_w2_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w2_app.Location = new System.Drawing.Point(1027, 204);
            this.btn_w2_app.Name = "btn_w2_app";
            this.btn_w2_app.Size = new System.Drawing.Size(105, 36);
            this.btn_w2_app.TabIndex = 11;
            this.btn_w2_app.Text = "approve";
            this.btn_w2_app.UseVisualStyleBackColor = true;
            this.btn_w2_app.Click += new System.EventHandler(this.btn_w2_app_Click);
            // 
            // btn_w2_rej
            // 
            this.btn_w2_rej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w2_rej.Location = new System.Drawing.Point(1143, 204);
            this.btn_w2_rej.Name = "btn_w2_rej";
            this.btn_w2_rej.Size = new System.Drawing.Size(71, 36);
            this.btn_w2_rej.TabIndex = 12;
            this.btn_w2_rej.Text = "reject";
            this.btn_w2_rej.UseVisualStyleBackColor = true;
            this.btn_w2_rej.Click += new System.EventHandler(this.btn_w2_rej_Click);
            // 
            // btn_w3_exp
            // 
            this.btn_w3_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w3_exp.Location = new System.Drawing.Point(927, 289);
            this.btn_w3_exp.Name = "btn_w3_exp";
            this.btn_w3_exp.Size = new System.Drawing.Size(87, 37);
            this.btn_w3_exp.TabIndex = 13;
            this.btn_w3_exp.Text = "expand";
            this.btn_w3_exp.UseVisualStyleBackColor = true;
            // 
            // btn_w3_app
            // 
            this.btn_w3_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w3_app.Location = new System.Drawing.Point(1027, 288);
            this.btn_w3_app.Name = "btn_w3_app";
            this.btn_w3_app.Size = new System.Drawing.Size(105, 38);
            this.btn_w3_app.TabIndex = 14;
            this.btn_w3_app.Text = "approve";
            this.btn_w3_app.UseVisualStyleBackColor = true;
            this.btn_w3_app.Click += new System.EventHandler(this.btn_w3_app_Click);
            // 
            // btn_w3_rej
            // 
            this.btn_w3_rej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w3_rej.Location = new System.Drawing.Point(1143, 288);
            this.btn_w3_rej.Name = "btn_w3_rej";
            this.btn_w3_rej.Size = new System.Drawing.Size(71, 38);
            this.btn_w3_rej.TabIndex = 15;
            this.btn_w3_rej.Text = "reject";
            this.btn_w3_rej.UseVisualStyleBackColor = true;
            this.btn_w3_rej.Click += new System.EventHandler(this.btn_w3_rej_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 16;
            // 
            // lbl_line1
            // 
            this.lbl_line1.Location = new System.Drawing.Point(12, 92);
            this.lbl_line1.Name = "lbl_line1";
            this.lbl_line1.Size = new System.Drawing.Size(1200, 3);
            this.lbl_line1.TabIndex = 17;
            // 
            // lbl_line2
            // 
            this.lbl_line2.Location = new System.Drawing.Point(14, 176);
            this.lbl_line2.Name = "lbl_line2";
            this.lbl_line2.Size = new System.Drawing.Size(1200, 3);
            this.lbl_line2.TabIndex = 18;
            // 
            // lbl_line3
            // 
            this.lbl_line3.Location = new System.Drawing.Point(14, 260);
            this.lbl_line3.Name = "lbl_line3";
            this.lbl_line3.Size = new System.Drawing.Size(1200, 3);
            this.lbl_line3.TabIndex = 19;
            // 
            // lbl_line4
            // 
            this.lbl_line4.Location = new System.Drawing.Point(14, 341);
            this.lbl_line4.Name = "lbl_line4";
            this.lbl_line4.Size = new System.Drawing.Size(1200, 3);
            this.lbl_line4.TabIndex = 20;
            // 
            // w1_c1_1
            // 
            this.w1_c1_1.Location = new System.Drawing.Point(171, 107);
            this.w1_c1_1.Name = "w1_c1_1";
            this.w1_c1_1.Size = new System.Drawing.Size(60, 30);
            this.w1_c1_1.TabIndex = 21;
            this.w1_c1_1.Text = "c1";
            // 
            // w1_c1_2
            // 
            this.w1_c1_2.Location = new System.Drawing.Point(171, 137);
            this.w1_c1_2.Name = "w1_c1_2";
            this.w1_c1_2.Size = new System.Drawing.Size(30, 30);
            this.w1_c1_2.TabIndex = 22;
            this.w1_c1_2.Text = "c1";
            // 
            // w1_c1_3
            // 
            this.w1_c1_3.Location = new System.Drawing.Point(201, 137);
            this.w1_c1_3.Name = "w1_c1_3";
            this.w1_c1_3.Size = new System.Drawing.Size(30, 30);
            this.w1_c1_3.TabIndex = 23;
            this.w1_c1_3.Text = "c1";
            // 
            // w1_c2_1
            // 
            this.w1_c2_1.Location = new System.Drawing.Point(248, 107);
            this.w1_c2_1.Name = "w1_c2_1";
            this.w1_c2_1.Size = new System.Drawing.Size(60, 30);
            this.w1_c2_1.TabIndex = 24;
            this.w1_c2_1.Text = "c2";
            this.w1_c2_1.Click += new System.EventHandler(this.w1_c2_1_Click);
            // 
            // w1_c2_2
            // 
            this.w1_c2_2.Location = new System.Drawing.Point(248, 137);
            this.w1_c2_2.Name = "w1_c2_2";
            this.w1_c2_2.Size = new System.Drawing.Size(30, 30);
            this.w1_c2_2.TabIndex = 25;
            this.w1_c2_2.Text = "c2";
            // 
            // w1_c2_3
            // 
            this.w1_c2_3.Location = new System.Drawing.Point(278, 137);
            this.w1_c2_3.Name = "w1_c2_3";
            this.w1_c2_3.Size = new System.Drawing.Size(30, 30);
            this.w1_c2_3.TabIndex = 26;
            this.w1_c2_3.Text = "c2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Dataset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_w1_time
            // 
            this.lbl_w1_time.AutoSize = true;
            this.lbl_w1_time.Location = new System.Drawing.Point(793, 126);
            this.lbl_w1_time.Name = "lbl_w1_time";
            this.lbl_w1_time.Size = new System.Drawing.Size(21, 18);
            this.lbl_w1_time.TabIndex = 28;
            this.lbl_w1_time.Text = "t1";
            // 
            // lbl_w2_time
            // 
            this.lbl_w2_time.AutoSize = true;
            this.lbl_w2_time.Location = new System.Drawing.Point(793, 213);
            this.lbl_w2_time.Name = "lbl_w2_time";
            this.lbl_w2_time.Size = new System.Drawing.Size(21, 18);
            this.lbl_w2_time.TabIndex = 29;
            this.lbl_w2_time.Text = "t2";
            // 
            // lbl_w3_time
            // 
            this.lbl_w3_time.AutoSize = true;
            this.lbl_w3_time.Location = new System.Drawing.Point(793, 298);
            this.lbl_w3_time.Name = "lbl_w3_time";
            this.lbl_w3_time.Size = new System.Drawing.Size(21, 18);
            this.lbl_w3_time.TabIndex = 30;
            this.lbl_w3_time.Text = "t3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 374);
            this.Controls.Add(this.lbl_w3_time);
            this.Controls.Add(this.lbl_w2_time);
            this.Controls.Add(this.lbl_w1_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.w1_c2_3);
            this.Controls.Add(this.w1_c2_2);
            this.Controls.Add(this.w1_c2_1);
            this.Controls.Add(this.w1_c1_3);
            this.Controls.Add(this.w1_c1_2);
            this.Controls.Add(this.w1_c1_1);
            this.Controls.Add(this.lbl_line4);
            this.Controls.Add(this.lbl_line3);
            this.Controls.Add(this.lbl_line2);
            this.Controls.Add(this.lbl_line1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_w3_rej);
            this.Controls.Add(this.btn_w3_app);
            this.Controls.Add(this.btn_w3_exp);
            this.Controls.Add(this.btn_w2_rej);
            this.Controls.Add(this.btn_w2_app);
            this.Controls.Add(this.btn_w2_exp);
            this.Controls.Add(this.btn_w1_rej);
            this.Controls.Add(this.btn_w1_app);
            this.Controls.Add(this.btn_w1_exp);
            this.Controls.Add(this.lbl_w3);
            this.Controls.Add(this.lbl_w2);
            this.Controls.Add(this.lbl_w1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_w1;
        private System.Windows.Forms.Label lbl_w2;
        private System.Windows.Forms.Label lbl_w3;
        private System.Windows.Forms.Button btn_w1_exp;
        private System.Windows.Forms.Button btn_w1_app;
        private System.Windows.Forms.Button btn_w1_rej;
        private System.Windows.Forms.Button btn_w2_exp;
        private System.Windows.Forms.Button btn_w2_app;
        private System.Windows.Forms.Button btn_w2_rej;
        private System.Windows.Forms.Button btn_w3_exp;
        private System.Windows.Forms.Button btn_w3_app;
        private System.Windows.Forms.Button btn_w3_rej;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_line1;
        private System.Windows.Forms.Label lbl_line2;
        private System.Windows.Forms.Label lbl_line3;
        private System.Windows.Forms.Label lbl_line4;
        private System.Windows.Forms.Label w1_c1_1;
        private System.Windows.Forms.Label w1_c1_2;
        private System.Windows.Forms.Label w1_c1_3;
        private System.Windows.Forms.Label w1_c2_1;
        private System.Windows.Forms.Label w1_c2_2;
        private System.Windows.Forms.Label w1_c2_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_w1_time;
        private System.Windows.Forms.Label lbl_w2_time;
        private System.Windows.Forms.Label lbl_w3_time;
    }
}

