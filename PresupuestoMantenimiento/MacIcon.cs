using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class MacIcon : Icon
    {
        string type;
        public MacIcon(string type)
        {
            this.type = type;
        }

        public override string Paint()
        {
            string resultado = "";
            switch(type)
            {
                case "Alerta":
                    resultado = "     ** \n" +
                        "  **   ** \n" +
                        " ** ALERTA ** \n " +
                        "  **  ** \n" +
                        "      **";
                    break;
                case "Peligro":
                    break;
            } 
            return resultado;
        }
    }
}
