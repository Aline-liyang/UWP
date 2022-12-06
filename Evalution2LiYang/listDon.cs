using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalution2LiYang
{
    class listDon
    {
        public string Name { get; set; }
        public int Don { get; set; }

        public listDon(string name, int don)
        {
            Name = name;
            Don = don;
        }
        public int showDon()
        {
            return Don;
        }
    }
}
