using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_create
{
    public  class MainViewController
    {
        //控制器关联的视图和模型
        public MainView mainfrm;
        public CreateHomeworkModel mainmodel;

        public MainViewController(MainView manfrm)
        {
            this.mainfrm = manfrm;
            this.mainfrm.MController = this;
            mainmodel = new CreateHomeworkModel();
        }
     
    }
   
}
