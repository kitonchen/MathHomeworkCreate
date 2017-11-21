using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_create
{
    public class MainModel:ModelLinker
    {
        private string mfileDate = null;

        public string MfileDate { get => mfileDate; set => mfileDate = value; }

        public string GetFileDate()
        {
            return MfileDate;
        }
    }

    
}
