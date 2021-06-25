
namespace Exercise3 {
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
            this.InputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.TextBoxWord4Count = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.TextBoxStrBuilder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxReplaceFrom = new System.Windows.Forms.TextBox();
            this.textBoxReplaceTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // InputStrText
            // 
            this.InputStrText.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputStrText.Location = new System.Drawing.Point(38, 51);
            this.InputStrText.Name = "InputStrText";
            this.InputStrText.Size = new System.Drawing.Size(642, 34);
            this.InputStrText.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_1.Location = new System.Drawing.Point(38, 108);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(142, 32);
            this.Button5_3_1.TabIndex = 3;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(222, 107);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(100, 31);
            this.TextBoxSpaceCount.TabIndex = 4;
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(222, 253);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(458, 31);
            this.TextBoxWordChange.TabIndex = 4;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_2.Location = new System.Drawing.Point(38, 170);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(142, 31);
            this.Button5_3_2.TabIndex = 5;
            this.Button5_3_2.Text = "big → small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_3.Location = new System.Drawing.Point(38, 306);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(142, 33);
            this.Button5_3_3.TabIndex = 6;
            this.Button5_3_3.Text = "単語をカウント";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount.Location = new System.Drawing.Point(222, 308);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(100, 31);
            this.TextBoxWordCount.TabIndex = 7;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_4.Location = new System.Drawing.Point(38, 359);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(142, 47);
            this.Button5_3_4.TabIndex = 8;
            this.Button5_3_4.Text = "4文字以下の\r\n単語を表示";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // TextBoxWord4Count
            // 
            this.TextBoxWord4Count.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWord4Count.Location = new System.Drawing.Point(222, 365);
            this.TextBoxWord4Count.Name = "TextBoxWord4Count";
            this.TextBoxWord4Count.Size = new System.Drawing.Size(458, 31);
            this.TextBoxWord4Count.TabIndex = 9;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_5.Location = new System.Drawing.Point(38, 440);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(142, 35);
            this.Button5_3_5.TabIndex = 10;
            this.Button5_3_5.Text = "StringBuilder";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // TextBoxStrBuilder
            // 
            this.TextBoxStrBuilder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxStrBuilder.Location = new System.Drawing.Point(222, 440);
            this.TextBoxStrBuilder.Name = "TextBoxStrBuilder";
            this.TextBoxStrBuilder.Size = new System.Drawing.Size(458, 31);
            this.TextBoxStrBuilder.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(218, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "変換前の文字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(473, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "変換後の文字";
            // 
            // TextBoxReplaceFrom
            // 
            this.TextBoxReplaceFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TextBoxReplaceFrom.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxReplaceFrom.Location = new System.Drawing.Point(222, 204);
            this.TextBoxReplaceFrom.Name = "TextBoxReplaceFrom";
            this.TextBoxReplaceFrom.Size = new System.Drawing.Size(203, 31);
            this.TextBoxReplaceFrom.TabIndex = 14;
            // 
            // textBoxReplaceTo
            // 
            this.textBoxReplaceTo.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxReplaceTo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxReplaceTo.Location = new System.Drawing.Point(477, 204);
            this.textBoxReplaceTo.Name = "textBoxReplaceTo";
            this.textBoxReplaceTo.Size = new System.Drawing.Size(203, 31);
            this.textBoxReplaceTo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(60, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "変換後の文字列";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReplaceTo);
            this.Controls.Add(this.TextBoxReplaceFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxStrBuilder);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.TextBoxWord4Count);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.InputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputStrText;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox TextBoxWord4Count;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox TextBoxStrBuilder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxReplaceFrom;
        private System.Windows.Forms.TextBox textBoxReplaceTo;
        private System.Windows.Forms.Label label4;
    }
}

