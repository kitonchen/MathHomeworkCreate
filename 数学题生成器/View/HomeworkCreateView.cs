using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_create
{
    public partial class HomeworkCreateView : Form
    {
      
        public HomeworkCreateView()
        {
            InitializeComponent();
        }

        //控制器
        private CreateHomeworkController mcontroller;

        public CreateHomeworkController MController
        {
            get { return mcontroller; }
            set { mcontroller = value; }
        }//end 控制器
      
        //窗体大小自适应
        AutoSizeFormClass asc = new AutoSizeFormClass();

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        //end 窗体大小自适应

        private void Homework_set_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void Ensure_Click(object sender, EventArgs e)
        {
            if (Check_args() == false)//视图参数合法性检查
            {
                return;
            }

            DialogResult MsgBoxResult;//读取对话框的结果
            MsgBoxResult = MessageBox.Show("是否根据默认模板文件生成？\n" +
                                            "题目数量: "+QuesNum.Value+"\n"+
                                            "纸张大小："+paper_size.Text.ToString(),//内容
                                            "提示",//标题
                                            MessageBoxButtons.YesNo,//按钮：是否形式
                                            MessageBoxIcon.Question,//对话框图标为询问
                                            MessageBoxDefaultButton.Button1);//默认按钮是

            if (MsgBoxResult == DialogResult.Yes)
            {
                //设置此次配置
                mcontroller.SetConfig(mcontroller.GetTypes(this.ques_type),//提取运算类型的字符
                                                        (int)QuesNum.Value,//获取题目数量
                                                        (int)homeworkset_maxnum.Value,//获取范围最大值
                                                        (int)homeworkset_minnum.Value);//获取范围最小值
                //执行生产任务
                mcontroller.RunCreateTask(saveWordFile);
            }
            //#TODO 部根据模板 
        }

        //关闭窗口
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check_args()
        {
            if (QuesNum.Value > QuesNum.Maximum || QuesNum.Value < QuesNum.Minimum)
            {
                MessageBox.Show("题目数量至少100道，不超过999道", "提示", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
                return false;
            }//检查题目数量

            if (ques_type.CheckedItems.Count < 1)
            {
                MessageBox.Show("必须选择至少一种类型的运算","提示", 
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }//检查运算类型

            if(paper_size.Text.ToString() == "")
            {
                MessageBox.Show("请选择纸张大小", "提示",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }//检查纸张大小

            //检查数值范围
            if(homeworkset_minnum.Value >homeworkset_minnum.Maximum ||homeworkset_minnum.Value < homeworkset_minnum.Minimum)
            {
                MessageBox.Show("最小数值的范围为：-100~100", "提示",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (homeworkset_maxnum.Value > homeworkset_maxnum.Maximum || homeworkset_maxnum.Value < homeworkset_maxnum.Minimum)
            {
                MessageBox.Show("最大数值的范围为：-100~100", "提示",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (homeworkset_maxnum.Value < homeworkset_minnum.Value)
            {
                MessageBox.Show("数值范围设置有误（最小数值大于最大数值）", "提示",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }

            if(homeworkset_maxnum.Value - homeworkset_minnum.Value < 20)
            {
                MessageBox.Show("最大最小值建议差值范围小于20，减少出现重复题目的次数", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }//end 检查数值范围

            GC.Collect();
            return true;
        }
   
    }
}
