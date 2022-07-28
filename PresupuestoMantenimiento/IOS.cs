using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public interface IOS
    {
        public Button CreateButton(string text);
        public Label CreateLabel(string Label);
        public Icon CreateIcon(string type);
    }
}
