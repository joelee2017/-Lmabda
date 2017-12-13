namespace 認識Lmabda
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnodd = new System.Windows.Forms.Button();
            this.btnCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "圓面積";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCircleArea_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(163, 207);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnodd
            // 
            this.btnodd.Location = new System.Drawing.Point(163, 274);
            this.btnodd.Name = "btnodd";
            this.btnodd.Size = new System.Drawing.Size(75, 23);
            this.btnodd.TabIndex = 2;
            this.btnodd.Text = "奇數";
            this.btnodd.UseVisualStyleBackColor = true;
            this.btnodd.Click += new System.EventHandler(this.btnodd_Click);
            // 
            // btnCreateButton
            // 
            this.btnCreateButton.Location = new System.Drawing.Point(163, 144);
            this.btnCreateButton.Name = "btnCreateButton";
            this.btnCreateButton.Size = new System.Drawing.Size(75, 23);
            this.btnCreateButton.TabIndex = 3;
            this.btnCreateButton.Text = "新button";
            this.btnCreateButton.UseVisualStyleBackColor = true;
            this.btnCreateButton.Click += new System.EventHandler(this.btnCreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 391);
            this.Controls.Add(this.btnCreateButton);
            this.Controls.Add(this.btnodd);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnodd;
        private System.Windows.Forms.Button btnCreateButton;
    }
}

