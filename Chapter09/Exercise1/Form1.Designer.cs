
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btFileOpen = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAllOpen = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 77);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(546, 361);
            this.tbOutput.TabIndex = 0;
            // 
            // btFileOpen
            // 
            this.btFileOpen.Location = new System.Drawing.Point(13, 13);
            this.btFileOpen.Name = "btFileOpen";
            this.btFileOpen.Size = new System.Drawing.Size(95, 48);
            this.btFileOpen.TabIndex = 1;
            this.btFileOpen.Text = "開く";
            this.btFileOpen.UseVisualStyleBackColor = true;
            this.btFileOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(114, 42);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(151, 19);
            this.tbKeyWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "キーワード";
            // 
            // btAllOpen
            // 
            this.btAllOpen.Location = new System.Drawing.Point(271, 13);
            this.btAllOpen.Name = "btAllOpen";
            this.btAllOpen.Size = new System.Drawing.Size(95, 48);
            this.btAllOpen.TabIndex = 4;
            this.btAllOpen.Text = "ReadAllLines";
            this.btAllOpen.UseVisualStyleBackColor = true;
            this.btAllOpen.Click += new System.EventHandler(this.btAllOpen_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(393, 13);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(95, 48);
            this.btReadLines.TabIndex = 5;
            this.btReadLines.Text = "ReadLines";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btAllOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btFileOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btFileOpen;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAllOpen;
        private System.Windows.Forms.Button btReadLines;
    }
}

