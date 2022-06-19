using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkFont
    {
        string fontFamily = "";
        int fontSize;
        TkColor color = new TkColor();

        public void Put(string fontFamily, float fontSize, Color color)
        {
            this.fontFamily = fontFamily;
            this.color.put(color);
            this.fontSize = (int)fontSize;
        }
        public string Get()
        {
            return $"('{fontFamily}', '{fontSize}'), fg={color.get()}";
        }
    }
}
