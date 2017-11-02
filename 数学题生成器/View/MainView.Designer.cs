namespace homework_create
{
    partial class MainView
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
            this.button_createhomework = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button_readhistory = new System.Windows.Forms.Button();
            this.button_getanswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_createhomework
            // 
            this.button_createhomework.Location = new System.Drawing.Point(382, 117);
            this.button_createhomework.Name = "button_createhomework";
            this.button_createhomework.Size = new System.Drawing.Size(75, 23);
            this.button_createhomework.TabIndex = 0;
            this.button_createhomework.Text = "作业生成";
            this.button_createhomework.UseVisualStyleBackColor = true;
            this.button_createhomework.Click += new System.EventHandler(this.Button_createhomework_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // button_readhistory
            // 
            this.button_readhistory.Location = new System.Drawing.Point(382, 75);
            this.button_readhistory.Name = "button_readhistory";
            this.button_readhistory.Size = new System.Drawing.Size(75, 23);
            this.button_readhistory.TabIndex = 5;
            this.button_readhistory.Text = "读取记录";
            this.button_readhistory.UseVisualStyleBackColor = true;
            this.button_readhistory.Click += new System.EventHandler(this.Button_readhistory_Click);
            // 
            // button_getanswer
            // 
            this.button_getanswer.Location = new System.Drawing.Point(382, 161);
            this.button_getanswer.Name = "button_getanswer";
            this.button_getanswer.Size = new System.Drawing.Size(75, 23);
            this.button_getanswer.TabIndex = 6;
            this.button_getanswer.Text = "输出带答案版本";
            this.button_getanswer.UseVisualStyleBackColor = true;
            this.button_getanswer.Click += new System.EventHandler(this.Button_getanswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(262, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "题目数量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 213);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_getanswer);
            this.Controls.Add(this.button_readhistory);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.button_createhomework);
            this.Name = "MainView";
            this.Text = "数学计算题生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainPage_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_createhomework;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button button_readhistory;
        private System.Windows.Forms.Button button_getanswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

