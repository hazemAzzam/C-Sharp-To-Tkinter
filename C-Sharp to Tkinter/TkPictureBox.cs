using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkPictureBox
    {
        Tkinter tkinter = new Tkinter();
        PictureBox pictureBox = new PictureBox();

        public void Put(string parent, PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.tkinter.Put(parent, pictureBox.Name, pictureBox.Height, pictureBox.Width, pictureBox.BackColor, pictureBox.Cursor.ToString(), "Flat", pictureBox.Location.X, pictureBox.Location.Y, pictureBox.Dock.ToString(), 0);
        }

        public void draw()
        {
            TkImage tkImage = new TkImage();
            tkImage.Put(pictureBox.Name, pictureBox.Width, pictureBox.Height);

            

            List<string> lines = new List<string>();

            lines.Add($"{tkImage.draw(pictureBox.BackgroundImage)}");
            lines.Add($"        self.{pictureBox.Name}=Label({tkinter.Draw()}, image=self.{pictureBox.Name}_img)");
            lines.Add($"        self.{pictureBox.Name}{tkinter.Place()})");

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
    }
}
