
using System;

namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.hoverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(0, 44);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(848, 549);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.CanGoBackChanged += new System.EventHandler(this.wbBrowser_CanGoBackChanged);
            this.wbBrowser.CanGoForwardChanged += new System.EventHandler(this.wbBrowser_CanGoForwardChanged);
            // 
            // btBack
            // 
            this.btBack.Enabled = false;
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(8, 6);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(48, 32);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            this.btBack.MouseHover += new System.EventHandler(this.btBack_MouseHover);
            // 
            // btForward
            // 
            this.btForward.Enabled = false;
            this.btForward.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(62, 6);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(48, 32);
            this.btForward.TabIndex = 2;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // hoverLabel
            // 
            this.hoverLabel.AutoSize = true;
            this.hoverLabel.Location = new System.Drawing.Point(730, 13);
            this.hoverLabel.Name = "hoverLabel";
            this.hoverLabel.Size = new System.Drawing.Size(15, 12);
            this.hoverLabel.TabIndex = 3;
            this.hoverLabel.Text = " e";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 593);
            this.Controls.Add(this.hoverLabel);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "32014";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Label hoverLabel;
    }
}