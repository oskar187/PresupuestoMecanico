using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class OSWindows : IOS
    {
        public Button CreateButton(string text)
        {
            return new WinButton(text);
        }

        public Icon CreateIcon(string type)
        {
            return new WinIcon(type);
        }

        public Label CreateLabel(string Label)
        {
            return new WinLabel(Label);
        }
    }
}
