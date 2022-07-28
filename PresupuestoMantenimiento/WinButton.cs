using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class WinButton : Button
    {
        private string text;

        public WinButton(string text)
        {
            this.text = text;
        }

        public override string Paint()
        {
            return " ------- \n " +
               " | " + text + " | \n" +
               " -------- \n "; ;
        }
    }
}
