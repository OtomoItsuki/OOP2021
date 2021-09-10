
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPubDate = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(133, 10);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(525, 28);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
            // 
            // lbTitles
            // 
            this.lbTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTitles.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 17;
            this.lbTitles.Location = new System.Drawing.Point(7, 64);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(194, 378);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btRead
            // 
            this.btRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRead.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(664, 11);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(86, 27);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesc.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(211, 104);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(539, 147);
            this.labelDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "更新日:";
            // 
            // labelPubDate
            // 
            this.labelPubDate.AutoSize = true;
            this.labelPubDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPubDate.Location = new System.Drawing.Point(283, 71);
            this.labelPubDate.Name = "labelPubDate";
            this.labelPubDate.Size = new System.Drawing.Size(14, 17);
            this.labelPubDate.TabIndex = 7;
            this.labelPubDate.Text = " ";
            // 
            // btView
            // 
            this.btView.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(623, 254);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(125, 27);
            this.btView.TabIndex = 8;
            this.btView.Text = "この記事を表示";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Visible = false;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 454);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.labelPubDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "32014";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPubDate;
        private System.Windows.Forms.Button btView;
    }
}

