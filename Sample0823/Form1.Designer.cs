﻿
namespace Sample0823 {
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
            this.Value = new System.Windows.Forms.TextBox();
            this.Jyou = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Exec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsePow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Value.Location = new System.Drawing.Point(13, 13);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 50);
            this.Value.TabIndex = 0;
            // 
            // Jyou
            // 
            this.Jyou.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Jyou.Location = new System.Drawing.Point(182, 13);
            this.Jyou.Name = "Jyou";
            this.Jyou.Size = new System.Drawing.Size(100, 50);
            this.Jyou.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result.Location = new System.Drawing.Point(509, 13);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(178, 50);
            this.Result.TabIndex = 1;
            // 
            // Exec
            // 
            this.Exec.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exec.Location = new System.Drawing.Point(354, 11);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(149, 52);
            this.Exec.TabIndex = 2;
            this.Exec.Text = "結果→";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "の";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(284, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "乗";
            // 
            // cbUsePow
            // 
            this.cbUsePow.AutoSize = true;
            this.cbUsePow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbUsePow.Location = new System.Drawing.Point(13, 91);
            this.cbUsePow.Name = "cbUsePow";
            this.cbUsePow.Size = new System.Drawing.Size(231, 34);
            this.cbUsePow.TabIndex = 5;
            this.cbUsePow.Text = "Powメソッド使用";
            this.cbUsePow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUsePow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Jyou);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Jyou;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbUsePow;
    }
}

