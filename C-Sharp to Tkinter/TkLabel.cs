using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkLabel
    {
        Tkinter tkinter = new Tkinter();
        Label label = new Label();
        TkFont font = new TkFont();

        public void Put(string parent, Label label)
        {
            this.label = label;
            font.Put(label.Font.Name, label.Font.Size, label.ForeColor);
            tkinter.Put(parent, label.Name, label.Height, label.Width, label.BackColor, label.Cursor.ToString(), label.FlatStyle.ToString(), label.Location.X, label.Location.Y, label.Dock.ToString(), 0);
        }
        public void draw()
        {
            List<string> lines = new List<string>();
            lines.Add($"        self.{label.Name} = Label({tkinter.Draw()}, text='{label.Text}', font={font.Get()})");
            lines.Add($"        self.{label.Name}{tkinter.Place()})");

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
    }
}
