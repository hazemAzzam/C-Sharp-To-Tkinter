using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkFrame
    {
        Tkinter tkinter = new Tkinter();
        Panel panel = new Panel();

        public void put(string parent, Panel panel)
        {
            this.panel = panel;
            tkinter.Put(parent, panel.Name, panel.Height, panel.Width, panel.BackColor, panel.Cursor.ToString(), panel.BorderStyle.ToString(), panel.Location.X, panel.Location.Y, panel.Dock.ToString(), 0);
        }


        public void draw()
        {
            List<string> lines = new List<string>();
            lines.Add($"        self.{panel.Name} = Frame({tkinter.Draw()}, height={panel.Height}, width={panel.Width})");
            lines.Add($"        self.{panel.Name}{tkinter.Place()})");

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
    }
}
