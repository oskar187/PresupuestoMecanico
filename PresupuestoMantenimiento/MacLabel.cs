using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class MacLabel : Label
    {
        string label;
        public MacLabel(string label)
        {
            this.label = label;
        }

        public override string Paint()
        {
            return "**" + label + "**";
        }
    }
}
