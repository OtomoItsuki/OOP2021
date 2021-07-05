
namespace StopWacth {
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
            this.components = new System.ComponentModel.Container();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            this.brStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Interval = 10;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(22, 186);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(154, 84);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // brStop
            // 
            this.brStop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.brStop.Location = new System.Drawing.Point(22, 291);
            this.brStop.Name = "brStop";
            this.brStop.Size = new System.Drawing.Size(154, 84);
            this.brStop.TabIndex = 1;
            this.brStop.Text = "ストップ";
            this.brStop.UseVisualStyleBackColor = true;
            this.brStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(191, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 84);
            this.button3.TabIndex = 1;
            this.button3.Text = "スタート";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(191, 186);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(154, 84);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 362);
            this.textBox1.TabIndex = 2;
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(12, 9);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(333, 132);
            this.lbTimerDisp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 395);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.brStop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button brStop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTimerDisp;
    }
}

