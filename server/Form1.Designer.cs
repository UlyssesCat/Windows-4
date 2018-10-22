namespace server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.TextBox();
            this.lsvMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "消息列表";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(3, 27);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(623, 411);
            this.Text.TabIndex = 1;
            // 
            // lsvMessage
            // 
            this.lsvMessage.FormattingEnabled = true;
            this.lsvMessage.ItemHeight = 15;
            this.lsvMessage.Location = new System.Drawing.Point(11, 35);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(120, 94);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.SelectedIndexChanged += new System.EventHandler(this.lsvMessage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.ListBox lsvMessage;
    }
}

