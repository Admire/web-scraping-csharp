namespace web_scraping_csharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageRangeNum = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startPageNum = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageRangeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cào danh mục theo trang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lưu ý: Tool sẽ đóng tiến trình Chrome hiện tại khi bắt đầu cào";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(264, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1381, 718);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Xóa bảng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(31, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Lưu vào cơ sở dữ liệu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số trang";
            // 
            // pageRangeNum
            // 
            this.pageRangeNum.Location = new System.Drawing.Point(31, 273);
            this.pageRangeNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pageRangeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageRangeNum.Name = "pageRangeNum";
            this.pageRangeNum.Size = new System.Drawing.Size(200, 27);
            this.pageRangeNum.TabIndex = 7;
            this.pageRangeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pageRangeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Tải từ cơ sở dữ liệu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(31, 663);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Lưu dưới dạng txt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(31, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Dừng cào";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập trang bắt đầu";
            // 
            // startPageNum
            // 
            this.startPageNum.Location = new System.Drawing.Point(31, 208);
            this.startPageNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.startPageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPageNum.Name = "startPageNum";
            this.startPageNum.Size = new System.Drawing.Size(200, 27);
            this.startPageNum.TabIndex = 7;
            this.startPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startPageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(31, 368);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 50);
            this.button7.TabIndex = 0;
            this.button7.Text = "Cào danh mục mọi trang";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(31, 722);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 50);
            this.button8.TabIndex = 0;
            this.button8.Text = "Xóa cơ sở dữ liệu";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(31, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 50);
            this.button9.TabIndex = 0;
            this.button9.Text = "Cào toàn bộ trang web";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhà đất bán",
            "Nhà đất cho thuê",
            "Dự án",
            "Tin tức",
            "Wiki BĐS",
            "Phong Thủy",
            "Nội-Ngoại thất",
            "Nhà môi giới",
            "Doanh nghiệp"});
            this.comboBox1.Location = new System.Drawing.Point(31, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Nhà đất bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn danh mục";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.startPageNum);
            this.Controls.Add(this.pageRangeNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1700, 850);
            this.MinimumSize = new System.Drawing.Size(1700, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batdongsan.com.vn Scraping Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pageRangeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label2;
        private ListView listView1;
        private Button button2;
        private Button button4;
        private Label label1;
        private NumericUpDown pageRangeNum;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label3;
        private NumericUpDown startPageNum;
        private Button button7;
        private Button button8;
        private Button button9;
        private ComboBox comboBox1;
        private Label label4;
    }
}