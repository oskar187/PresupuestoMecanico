using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class WinLabel : Label
    {
        string label;
        public WinLabel(string label)
        {
            this.label = label;
        }

        public override string Paint()
        {
            return "<<" + label + ">>";   
        }
    }
}
