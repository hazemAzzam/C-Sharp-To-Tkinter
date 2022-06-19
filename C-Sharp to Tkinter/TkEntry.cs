using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkEntry
    {
        Tkinter tkinter = new Tkinter();
        TextBox textBox = new TextBox();
        TkFont font = new TkFont();

        public void Put(string parent, TextBox textBox)
        {
            this.textBox = textBox;
            font.Put(textBox.Font.Name, textBox.Font.Size, textBox.ForeColor);
            tkinter.Put(parent, textBox.Name, textBox.Height, textBox.Width, textBox.BackColor, textBox.Cursor.ToString(), textBox.BorderStyle.ToString(), textBox.Location.X, textBox.Location.Y, textBox.Dock.ToString(), 1);
        }

        public void draw()
        {
            List<string> lines = new List<string>();
            lines.Add($"        self.{textBox.Name} = Entry({tkinter.Draw()}, text='{textBox.Text}', font={font.Get()})");
            lines.Add($"        self.{textBox.Name}{tkinter.Place()})");

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
    }
}
