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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
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
            ((System.ComponentModel.ISupportInitialize)(this.pageRangeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cào theo số đã nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bấm vào \"Cào theo số đã nhập\" hoặc \"Cào tất cả các trang\" để bắt đầu";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Location = new System.Drawing.Point(264, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1381, 718);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "URL bài viết";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tiêu đề";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá/m2";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Diện tích";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa chỉ";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày đăng bài";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nên xem";
            this.columnHeader8.Width = 150;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(31, 418);
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
            this.button4.Location = new System.Drawing.Point(31, 494);
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
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số trang";
            // 
            // pageRangeNum
            // 
            this.pageRangeNum.Location = new System.Drawing.Point(31, 142);
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
            this.button3.Location = new System.Drawing.Point(31, 568);
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
            this.button5.Location = new System.Drawing.Point(31, 639);
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
            this.button6.Location = new System.Drawing.Point(31, 340);
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
            this.label3.Location = new System.Drawing.Point(34, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập trang bắt đầu";
            // 
            // startPageNum
            // 
            this.startPageNum.Location = new System.Drawing.Point(34, 59);
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
            this.startPageNum.Size = new System.Drawing.Size(197, 27);
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
            this.button7.Location = new System.Drawing.Point(31, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 50);
            this.button7.TabIndex = 0;
            this.button7.Text = "Cào tất cả các trang";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.startPageNum);
            this.Controls.Add(this.pageRangeNum);
            this.Controls.Add(this.label3);
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button2;
        private Button button4;
        private Label label1;
        private NumericUpDown pageRangeNum;
        private Button button3;
        private Button button5;
        private Button button6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label3;
        private NumericUpDown startPageNum;
        private Button button7;
        private Button button8;
    }
}