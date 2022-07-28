using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class Aplication
    {
        public IOS plataforma;
        List<GUIObject> GUI;

        //Creamos un Constructor de Plataforma para asignar la plataforma que se envie al momento de crear la aplicacion
        public Aplication(IOS plataforma)
        {
            this.plataforma = plataforma;
            GUI = new List<GUIObject>();
        }

        public void CrearIU()
        {
            Label titulo = plataforma.CreateLabel("Are you sure?");
            Label mensaje = plataforma.CreateLabel("One deleted, you will not be able to recover this!");
            Icon iconoAlerta = plataforma.CreateIcon("Alerta");
            Button buttonOK = plataforma.CreateButton("OK");
            Button buttonCancelar = plataforma.CreateButton("Cancelar");

            GUI.Add(titulo);
            GUI.Add(mensaje);
            GUI.Add(iconoAlerta);
            GUI.Add(buttonOK);
            GUI.Add(buttonCancelar);
        }

        public void Paint()
        {
            string pantalla="";

            foreach(var objeto in GUI)
            {
                pantalla += objeto.Paint() + "\n"; 
            }

            Console.WriteLine(pantalla);
        }
    }
}
