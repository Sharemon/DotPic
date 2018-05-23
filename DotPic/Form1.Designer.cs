namespace DotPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxOrigin = new System.Windows.Forms.PictureBox();
            this.pbxDot = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDot)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxOrigin
            // 
            this.pbxOrigin.Image = ((System.Drawing.Image)(resources.GetObject("pbxOrigin.Image")));
            this.pbxOrigin.Location = new System.Drawing.Point(49, 45);
            this.pbxOrigin.Name = "pbxOrigin";
            this.pbxOrigin.Size = new System.Drawing.Size(512, 512);
            this.pbxOrigin.TabIndex = 0;
            this.pbxOrigin.TabStop = false;
            // 
            // pbxDot
            // 
            this.pbxDot.Image = ((System.Drawing.Image)(resources.GetObject("pbxDot.Image")));
            this.pbxDot.Location = new System.Drawing.Point(619, 45);
            this.pbxDot.Name = "pbxDot";
            this.pbxDot.Size = new System.Drawing.Size(512, 512);
            this.pbxDot.TabIndex = 0;
            this.pbxDot.TabStop = false;
            this.pbxDot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxDot_MouseClick);
            this.pbxDot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxDot_MouseMove);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(49, 390);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 12);
            this.lblStatus.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 611);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbxDot);
            this.Controls.Add(this.pbxOrigin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxOrigin;
        private System.Windows.Forms.PictureBox pbxDot;
        private System.Windows.Forms.Label lblStatus;
    }
}

