using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkButton
    {
        Tkinter tkinter = new Tkinter();
        Button button = new Button();
        TkFont font = new TkFont();

        public void Put(string parent, Button button)
        {
            this.button = button;
            font.Put(button.Font.Name, button.Font.Size, button.ForeColor);
            tkinter.Put(parent, button.Name, button.Height, button.Width, button.BackColor, button.Cursor.ToString(), button.FlatStyle.ToString(), button.Location.X, button.Location.Y, button.Dock.ToString(), button.FlatAppearance.BorderSize);
        }

        public void draw()
        {
            List<string> lines = new List<string>();
            if (button.BackgroundImage != null)
            {
                TkImage background = new TkImage();
                background.Put(button.Name, button.Width, button.Height);
                lines.Add(background.draw(button.BackgroundImage));
            }
            TkColor foreColor = new TkColor();
            foreColor.put(button.ForeColor);

            string line = $"        self.{button.Name} = Button({tkinter.Draw()}, text='{button.Text}', bd={button.FlatAppearance.BorderSize}, font={font.Get()}, highlightbackground={foreColor.get()}";
            if (button.BackgroundImage != null)
            {
                line += $", image=self.{button.Name}_img";
            }
            line += ")";

            lines.Add(line);
            lines.Add($"        self.{button.Name}{tkinter.Place()})");

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
    }
}
