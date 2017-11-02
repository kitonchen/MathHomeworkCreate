using System;
using System.Collections;
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
    public partial class MainView : Form
    {
        private MainViewController mcontroller;
        public MainViewController MController
        {
            get { return mcontroller; }
            set { mcontroller = value; }
        }

        public MainView()
        {
            InitializeComponent();
        }

        public void DrawMonthCalendar(MonthCalendar monthCalendar)
        {
              
        }

        //窗体大小自适应
        AutoSizeFormClass asc = new AutoSizeFormClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void MainPage_SizeChanged(object sender,EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        //end 窗体大小自适应

        private void Button_getanswer_Click(object sender, EventArgs e)
        {

        }

        private void Button_createhomework_Click(object sender, EventArgs e)
        {//生成一个作业配置视图
            //绑定视图与控制器
            CreateHomeworkController createHomeworkController = new CreateHomeworkController(new HomeworkCreateView());
            //获取文件名
            createHomeworkController.SetFileDate(monthCalendar.SelectionStart.ToString("yyyyMMdd"));
            //显示视图
            createHomeworkController.mainfrm.ShowDialog();
        }

    }
}
