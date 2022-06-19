using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkImage
    {
        string name;
        int width;
        int height;

        public void Put(string name, int width, int height)
        {
            this.name = name;
            this.width = width;
            this.height = height;
        }

        public string draw(Image image)
        {
            image.Save($"Resources\\{name}.png");
            return $"        self.{name}_img = ImageTk.PhotoImage(Image.open('Resources\\\\{name}.png').resize(({width}, {height}), Image.Resampling.LANCZOS))";
        }
    }
}
