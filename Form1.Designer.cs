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
            this.CrawlSomePagesButton = new System.Windows.Forms.Button();
            this.TableTitle = new System.Windows.Forms.Label();
            this.TableResult = new System.Windows.Forms.ListView();
            this.DeleteResultButton = new System.Windows.Forms.Button();
            this.SaveToDbButton = new System.Windows.Forms.Button();
            this.PageRangeTitle = new System.Windows.Forms.Label();
            this.PageRangeNum = new System.Windows.Forms.NumericUpDown();
            this.LoadDbButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.StopCrawl = new System.Windows.Forms.Button();
            this.StartPageTitle = new System.Windows.Forms.Label();
            this.StartPageNum = new System.Windows.Forms.NumericUpDown();
            this.CrawlAllPagesButton = new System.Windows.Forms.Button();
            this.DeleteDbButton = new System.Windows.Forms.Button();
            this.CrawlAllButton = new System.Windows.Forms.Button();
            this.ListCategories = new System.Windows.Forms.ComboBox();
            this.ListCategoriesTitle = new System.Windows.Forms.Label();
            this.CrawlAllTitle = new System.Windows.Forms.Label();
            this.serverDBnameTitle = new System.Windows.Forms.Label();
            this.serverDBportTitle = new System.Windows.Forms.Label();
            this.userDBnameTitle = new System.Windows.Forms.Label();
            this.userDBpasswordTitle = new System.Windows.Forms.Label();
            this.DBnameTitle = new System.Windows.Forms.Label();
            this.serverDBname = new System.Windows.Forms.TextBox();
            this.serverDBport = new System.Windows.Forms.TextBox();
            this.userDBname = new System.Windows.Forms.TextBox();
            this.userDBpassword = new System.Windows.Forms.TextBox();
            this.DBname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PageRangeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // CrawlSomePagesButton
            // 
            this.CrawlSomePagesButton.Location = new System.Drawing.Point(31, 309);
            this.CrawlSomePagesButton.Name = "CrawlSomePagesButton";
            this.CrawlSomePagesButton.Size = new System.Drawing.Size(200, 50);
            this.CrawlSomePagesButton.TabIndex = 0;
            this.CrawlSomePagesButton.Text = "Cào danh mục theo trang";
            this.CrawlSomePagesButton.UseVisualStyleBackColor = true;
            this.CrawlSomePagesButton.Click += new System.EventHandler(this.CrawlSomePagesButton_Click);
            // 
            // TableTitle
            // 
            this.TableTitle.AutoSize = true;
            this.TableTitle.Location = new System.Drawing.Point(264, 113);
            this.TableTitle.Name = "TableTitle";
            this.TableTitle.Size = new System.Drawing.Size(415, 20);
            this.TableTitle.TabIndex = 3;
            this.TableTitle.Text = "Lưu ý: Tool sẽ đóng tiến trình Chrome hiện tại khi bắt đầu cào";
            // 
            // TableResult
            // 
            this.TableResult.Location = new System.Drawing.Point(264, 142);
            this.TableResult.Name = "TableResult";
            this.TableResult.Size = new System.Drawing.Size(1381, 630);
            this.TableResult.TabIndex = 4;
            this.TableResult.UseCompatibleStateImageBehavior = false;
            this.TableResult.View = System.Windows.Forms.View.Details;
            // 
            // DeleteResultButton
            // 
            this.DeleteResultButton.Location = new System.Drawing.Point(31, 486);
            this.DeleteResultButton.Name = "DeleteResultButton";
            this.DeleteResultButton.Size = new System.Drawing.Size(200, 50);
            this.DeleteResultButton.TabIndex = 0;
            this.DeleteResultButton.Text = "Xóa bảng";
            this.DeleteResultButton.UseVisualStyleBackColor = true;
            this.DeleteResultButton.Click += new System.EventHandler(this.DeleteResultButton_Click);
            // 
            // SaveToDbButton
            // 
            this.SaveToDbButton.Enabled = false;
            this.SaveToDbButton.Location = new System.Drawing.Point(31, 545);
            this.SaveToDbButton.Name = "SaveToDbButton";
            this.SaveToDbButton.Size = new System.Drawing.Size(200, 50);
            this.SaveToDbButton.TabIndex = 0;
            this.SaveToDbButton.Text = "Lưu vào cơ sở dữ liệu";
            this.SaveToDbButton.UseVisualStyleBackColor = true;
            this.SaveToDbButton.Click += new System.EventHandler(this.SaveToDbButton_Click);
            // 
            // PageRangeTitle
            // 
            this.PageRangeTitle.AutoSize = true;
            this.PageRangeTitle.Location = new System.Drawing.Point(31, 244);
            this.PageRangeTitle.Name = "PageRangeTitle";
            this.PageRangeTitle.Size = new System.Drawing.Size(103, 20);
            this.PageRangeTitle.TabIndex = 6;
            this.PageRangeTitle.Text = "Nhập số trang";
            // 
            // PageRangeNum
            // 
            this.PageRangeNum.Location = new System.Drawing.Point(31, 273);
            this.PageRangeNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PageRangeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageRangeNum.Name = "PageRangeNum";
            this.PageRangeNum.Size = new System.Drawing.Size(200, 27);
            this.PageRangeNum.TabIndex = 7;
            this.PageRangeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PageRangeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LoadDbButton
            // 
            this.LoadDbButton.Location = new System.Drawing.Point(31, 604);
            this.LoadDbButton.Name = "LoadDbButton";
            this.LoadDbButton.Size = new System.Drawing.Size(200, 50);
            this.LoadDbButton.TabIndex = 0;
            this.LoadDbButton.Text = "Tải từ cơ sở dữ liệu";
            this.LoadDbButton.UseVisualStyleBackColor = true;
            this.LoadDbButton.Click += new System.EventHandler(this.LoadDbButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Location = new System.Drawing.Point(31, 663);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(200, 50);
            this.SaveToFileButton.TabIndex = 0;
            this.SaveToFileButton.Text = "Lưu dưới dạng txt";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // StopCrawl
            // 
            this.StopCrawl.Enabled = false;
            this.StopCrawl.Location = new System.Drawing.Point(31, 427);
            this.StopCrawl.Name = "StopCrawl";
            this.StopCrawl.Size = new System.Drawing.Size(200, 50);
            this.StopCrawl.TabIndex = 0;
            this.StopCrawl.Text = "Dừng cào";
            this.StopCrawl.UseVisualStyleBackColor = true;
            this.StopCrawl.Click += new System.EventHandler(this.StopCrawl_Click);
            // 
            // StartPageTitle
            // 
            this.StartPageTitle.AutoSize = true;
            this.StartPageTitle.Location = new System.Drawing.Point(31, 179);
            this.StartPageTitle.Name = "StartPageTitle";
            this.StartPageTitle.Size = new System.Drawing.Size(139, 20);
            this.StartPageTitle.TabIndex = 6;
            this.StartPageTitle.Text = "Nhập trang bắt đầu";
            // 
            // StartPageNum
            // 
            this.StartPageNum.Location = new System.Drawing.Point(31, 208);
            this.StartPageNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.StartPageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartPageNum.Name = "StartPageNum";
            this.StartPageNum.Size = new System.Drawing.Size(200, 27);
            this.StartPageNum.TabIndex = 7;
            this.StartPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartPageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CrawlAllPagesButton
            // 
            this.CrawlAllPagesButton.Location = new System.Drawing.Point(31, 368);
            this.CrawlAllPagesButton.Name = "CrawlAllPagesButton";
            this.CrawlAllPagesButton.Size = new System.Drawing.Size(200, 50);
            this.CrawlAllPagesButton.TabIndex = 0;
            this.CrawlAllPagesButton.Text = "Cào danh mục mọi trang";
            this.CrawlAllPagesButton.UseVisualStyleBackColor = true;
            this.CrawlAllPagesButton.Click += new System.EventHandler(this.CrawlAllPagesButton_Click);
            // 
            // DeleteDbButton
            // 
            this.DeleteDbButton.Location = new System.Drawing.Point(31, 722);
            this.DeleteDbButton.Name = "DeleteDbButton";
            this.DeleteDbButton.Size = new System.Drawing.Size(200, 50);
            this.DeleteDbButton.TabIndex = 0;
            this.DeleteDbButton.Text = "Xóa cơ sở dữ liệu";
            this.DeleteDbButton.UseVisualStyleBackColor = true;
            this.DeleteDbButton.Click += new System.EventHandler(this.DeleteDbButton_Click);
            // 
            // CrawlAllButton
            // 
            this.CrawlAllButton.Location = new System.Drawing.Point(31, 54);
            this.CrawlAllButton.Name = "CrawlAllButton";
            this.CrawlAllButton.Size = new System.Drawing.Size(200, 50);
            this.CrawlAllButton.TabIndex = 0;
            this.CrawlAllButton.Text = "Cào toàn bộ trang web";
            this.CrawlAllButton.UseVisualStyleBackColor = true;
            this.CrawlAllButton.Click += new System.EventHandler(this.CrawlAllButton_Click);
            // 
            // ListCategories
            // 
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.Items.AddRange(new object[] {
            "Nhà đất bán",
            "Nhà đất cho thuê",
            "Dự án",
            "Tin tức",
            "Wiki BĐS",
            "Phong Thủy",
            "Nội-Ngoại thất",
            "Nhà môi giới",
            "Doanh nghiệp"});
            this.ListCategories.Location = new System.Drawing.Point(31, 142);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(200, 28);
            this.ListCategories.TabIndex = 8;
            this.ListCategories.Text = "Nhà đất bán";
            // 
            // ListCategoriesTitle
            // 
            this.ListCategoriesTitle.AutoSize = true;
            this.ListCategoriesTitle.Location = new System.Drawing.Point(31, 113);
            this.ListCategoriesTitle.Name = "ListCategoriesTitle";
            this.ListCategoriesTitle.Size = new System.Drawing.Size(112, 20);
            this.ListCategoriesTitle.TabIndex = 6;
            this.ListCategoriesTitle.Text = "Chọn danh mục";
            // 
            // CrawlAllTitle
            // 
            this.CrawlAllTitle.AutoSize = true;
            this.CrawlAllTitle.Location = new System.Drawing.Point(31, 21);
            this.CrawlAllTitle.Name = "CrawlAllTitle";
            this.CrawlAllTitle.Size = new System.Drawing.Size(189, 20);
            this.CrawlAllTitle.TabIndex = 9;
            this.CrawlAllTitle.Text = "Nhập trang để cào toàn bộ";
            // 
            // serverDBnameTitle
            // 
            this.serverDBnameTitle.AutoSize = true;
            this.serverDBnameTitle.Location = new System.Drawing.Point(264, 21);
            this.serverDBnameTitle.Name = "serverDBnameTitle";
            this.serverDBnameTitle.Size = new System.Drawing.Size(97, 20);
            this.serverDBnameTitle.TabIndex = 9;
            this.serverDBnameTitle.Text = "Tên server db";
            // 
            // serverDBportTitle
            // 
            this.serverDBportTitle.AutoSize = true;
            this.serverDBportTitle.Location = new System.Drawing.Point(490, 21);
            this.serverDBportTitle.Name = "serverDBportTitle";
            this.serverDBportTitle.Size = new System.Drawing.Size(35, 20);
            this.serverDBportTitle.TabIndex = 9;
            this.serverDBportTitle.Text = "Port";
            // 
            // userDBnameTitle
            // 
            this.userDBnameTitle.AutoSize = true;
            this.userDBnameTitle.Location = new System.Drawing.Point(703, 21);
            this.userDBnameTitle.Name = "userDBnameTitle";
            this.userDBnameTitle.Size = new System.Drawing.Size(113, 20);
            this.userDBnameTitle.TabIndex = 9;
            this.userDBnameTitle.Text = "Tên người dùng";
            // 
            // userDBpasswordTitle
            // 
            this.userDBpasswordTitle.AutoSize = true;
            this.userDBpasswordTitle.Location = new System.Drawing.Point(911, 21);
            this.userDBpasswordTitle.Name = "userDBpasswordTitle";
            this.userDBpasswordTitle.Size = new System.Drawing.Size(70, 20);
            this.userDBpasswordTitle.TabIndex = 9;
            this.userDBpasswordTitle.Text = "Mật khẩu";
            // 
            // DBnameTitle
            // 
            this.DBnameTitle.AutoSize = true;
            this.DBnameTitle.Location = new System.Drawing.Point(1133, 21);
            this.DBnameTitle.Name = "DBnameTitle";
            this.DBnameTitle.Size = new System.Drawing.Size(97, 20);
            this.DBnameTitle.TabIndex = 9;
            this.DBnameTitle.Text = "Tên database";
            // 
            // serverDBname
            // 
            this.serverDBname.Location = new System.Drawing.Point(264, 66);
            this.serverDBname.Name = "serverDBname";
            this.serverDBname.Size = new System.Drawing.Size(190, 27);
            this.serverDBname.TabIndex = 10;
            this.serverDBname.Text = "localhost";
            // 
            // serverDBport
            // 
            this.serverDBport.Location = new System.Drawing.Point(489, 66);
            this.serverDBport.Name = "serverDBport";
            this.serverDBport.Size = new System.Drawing.Size(190, 27);
            this.serverDBport.TabIndex = 10;
            this.serverDBport.Text = "5060";
            // 
            // userDBname
            // 
            this.userDBname.Location = new System.Drawing.Point(703, 66);
            this.userDBname.Name = "userDBname";
            this.userDBname.Size = new System.Drawing.Size(190, 27);
            this.userDBname.TabIndex = 10;
            this.userDBname.Text = "root";
            // 
            // userDBpassword
            // 
            this.userDBpassword.Location = new System.Drawing.Point(911, 66);
            this.userDBpassword.Name = "userDBpassword";
            this.userDBpassword.Size = new System.Drawing.Size(190, 27);
            this.userDBpassword.TabIndex = 10;
            this.userDBpassword.Text = "140300";
            // 
            // DBname
            // 
            this.DBname.Location = new System.Drawing.Point(1133, 66);
            this.DBname.Name = "DBname";
            this.DBname.ReadOnly = true;
            this.DBname.Size = new System.Drawing.Size(190, 27);
            this.DBname.TabIndex = 10;
            this.DBname.Text = "batdongsan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.DBname);
            this.Controls.Add(this.userDBpassword);
            this.Controls.Add(this.userDBname);
            this.Controls.Add(this.serverDBport);
            this.Controls.Add(this.serverDBname);
            this.Controls.Add(this.DBnameTitle);
            this.Controls.Add(this.userDBpasswordTitle);
            this.Controls.Add(this.userDBnameTitle);
            this.Controls.Add(this.serverDBportTitle);
            this.Controls.Add(this.serverDBnameTitle);
            this.Controls.Add(this.CrawlAllTitle);
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.StartPageNum);
            this.Controls.Add(this.PageRangeNum);
            this.Controls.Add(this.StartPageTitle);
            this.Controls.Add(this.ListCategoriesTitle);
            this.Controls.Add(this.PageRangeTitle);
            this.Controls.Add(this.TableResult);
            this.Controls.Add(this.TableTitle);
            this.Controls.Add(this.LoadDbButton);
            this.Controls.Add(this.DeleteDbButton);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.SaveToDbButton);
            this.Controls.Add(this.DeleteResultButton);
            this.Controls.Add(this.StopCrawl);
            this.Controls.Add(this.CrawlAllPagesButton);
            this.Controls.Add(this.CrawlAllButton);
            this.Controls.Add(this.CrawlSomePagesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1700, 850);
            this.MinimumSize = new System.Drawing.Size(1700, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batdongsan.com.vn Scraping Tool";
            ((System.ComponentModel.ISupportInitialize)(this.PageRangeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CrawlSomePagesButton;
        private Label TableTitle;
        private ListView TableResult;
        private Button DeleteResultButton;
        private Button SaveToDbButton;
        private Label PageRangeTitle;
        private NumericUpDown PageRangeNum;
        private Button LoadDbButton;
        private Button SaveToFileButton;
        private Button StopCrawl;
        private Label StartPageTitle;
        private NumericUpDown StartPageNum;
        private Button CrawlAllPagesButton;
        private Button DeleteDbButton;
        private Button CrawlAllButton;
        private ComboBox ListCategories;
        private Label ListCategoriesTitle;
        private Label CrawlAllTitle;
        private Label serverDBnameTitle;
        private Label serverDBportTitle;
        private Label userDBnameTitle;
        private Label userDBpasswordTitle;
        private Label DBnameTitle;
        public TextBox serverDBname;
        public TextBox serverDBport;
        public TextBox userDBname;
        public TextBox userDBpassword;
        public TextBox DBname;
    }
}