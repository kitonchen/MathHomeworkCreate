namespace homework_create
{
    partial class HomeworkCreateView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuesNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ques_type = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paper_size = new System.Windows.Forms.ComboBox();
            this.ensure = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.homeworkset_minnum = new System.Windows.Forms.NumericUpDown();
            this.homeworkset_maxnum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.openWordFile = new System.Windows.Forms.OpenFileDialog();
            this.saveWordFile = new System.Windows.Forms.SaveFileDialog();
<<<<<<< HEAD:计算题生成/View/HomeworkCreateView.Designer.cs
          
=======
            this.folderBrowserWordfile = new System.Windows.Forms.FolderBrowserDialog();
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c:计算题生成/View/HomeworkCreateView.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.QuesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkset_minnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkset_maxnum)).BeginInit();
            this.SuspendLayout();
            // 
            // QuesNum
            // 
            this.QuesNum.Location = new System.Drawing.Point(147, 9);
            this.QuesNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.QuesNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.QuesNum.Name = "QuesNum";
            this.QuesNum.Size = new System.Drawing.Size(120, 21);
            this.QuesNum.TabIndex = 0;
            this.QuesNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "题目数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "题目类型";
            // 
            // ques_type
            // 
            this.ques_type.FormattingEnabled = true;
            this.ques_type.Items.AddRange(new object[] {
            "加(+)",
            "减(-)",
            "乘(*)",
            "除(/)"});
            this.ques_type.Location = new System.Drawing.Point(147, 53);
            this.ques_type.Name = "ques_type";
            this.ques_type.Size = new System.Drawing.Size(120, 68);
            this.ques_type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "纸张大小";
            // 
            // paper_size
            // 
            this.paper_size.FormattingEnabled = true;
            this.paper_size.Items.AddRange(new object[] {
            "A4",
            "A3"});
            this.paper_size.Location = new System.Drawing.Point(146, 133);
            this.paper_size.Name = "paper_size";
            this.paper_size.Size = new System.Drawing.Size(121, 20);
            this.paper_size.TabIndex = 6;
            // 
            // ensure
            // 
            this.ensure.Location = new System.Drawing.Point(133, 228);
            this.ensure.Name = "ensure";
            this.ensure.Size = new System.Drawing.Size(75, 23);
            this.ensure.TabIndex = 7;
            this.ensure.Text = "确定";
            this.ensure.UseVisualStyleBackColor = true;
            this.ensure.Click += new System.EventHandler(this.Ensure_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(226, 228);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // homeworkset_minnum
            // 
            this.homeworkset_minnum.Location = new System.Drawing.Point(145, 171);
            this.homeworkset_minnum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.homeworkset_minnum.Name = "homeworkset_minnum";
            this.homeworkset_minnum.Size = new System.Drawing.Size(58, 21);
            this.homeworkset_minnum.TabIndex = 9;
            // 
            // homeworkset_maxnum
            // 
            this.homeworkset_maxnum.Location = new System.Drawing.Point(209, 171);
            this.homeworkset_maxnum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.homeworkset_maxnum.Name = "homeworkset_maxnum";
            this.homeworkset_maxnum.Size = new System.Drawing.Size(58, 21);
            this.homeworkset_maxnum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "数值范围";
            // 
            // openWordFile
            // 
            this.openWordFile.FileName = "openFileDialog1";
            // 
            // HomeworkCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.homeworkset_maxnum);
            this.Controls.Add(this.homeworkset_minnum);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ensure);
            this.Controls.Add(this.paper_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ques_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuesNum);
            this.Name = "HomeworkCreateView";
            this.Text = "homework_set";
            this.Load += new System.EventHandler(this.Homework_set_Load);
            this.SizeChanged += new System.EventHandler(this.MainPage_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.QuesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkset_minnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkset_maxnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown QuesNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ques_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paper_size;
        private System.Windows.Forms.Button ensure;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown homeworkset_minnum;
        private System.Windows.Forms.NumericUpDown homeworkset_maxnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openWordFile;
        private System.Windows.Forms.SaveFileDialog saveWordFile;
<<<<<<< HEAD:计算题生成/View/HomeworkCreateView.Designer.cs
       
=======
        private System.Windows.Forms.FolderBrowserDialog folderBrowserWordfile;
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c:计算题生成/View/HomeworkCreateView.Designer.cs
    }
}