
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
            this.btLap = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.lbLap = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Interval = 3;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(10, 140);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(195, 84);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // brStop
            // 
            this.brStop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.brStop.Location = new System.Drawing.Point(10, 245);
            this.brStop.Name = "brStop";
            this.brStop.Size = new System.Drawing.Size(195, 84);
            this.brStop.TabIndex = 1;
            this.brStop.Text = "ストップ";
            this.brStop.UseVisualStyleBackColor = true;
            this.brStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btLap
            // 
            this.btLap.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLap.Location = new System.Drawing.Point(229, 245);
            this.btLap.Name = "btLap";
            this.btLap.Size = new System.Drawing.Size(186, 84);
            this.btLap.TabIndex = 1;
            this.btLap.Text = "ラップ";
            this.btLap.UseVisualStyleBackColor = true;
            this.btLap.Click += new System.EventHandler(this.btLap_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(229, 140);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(186, 84);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(12, 9);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(403, 96);
            this.lbTimerDisp.TabIndex = 3;
            // 
            // lbLap
            // 
            this.lbLap.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbLap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLap.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLap.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLap.FormattingEnabled = true;
            this.lbLap.ItemHeight = 21;
            this.lbLap.Location = new System.Drawing.Point(435, 9);
            this.lbLap.Name = "lbLap";
            this.lbLap.Size = new System.Drawing.Size(130, 319);
            this.lbLap.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 340);
            this.Controls.Add(this.lbLap);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLap);
            this.Controls.Add(this.brStop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button brStop;
        private System.Windows.Forms.Button btLap;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.ListBox lbLap;
    }
}

