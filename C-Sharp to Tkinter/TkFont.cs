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
        string fontStyle;
        TkColor color = new TkColor();
        public void Put(Font font, Color color)
        {
            this.fontFamily = font.Name;
            this.fontSize = (int)font.Size;
            this.fontStyle = font.Style.ToString();
            this.color.put(color);
        }
        public void Put(string fontFamily, float fontSize, string fontStyle, Color color)
        {
            this.fontFamily = fontFamily;
            this.color.put(color);
            this.fontSize = (int)fontSize;
            this.fontStyle = fontStyle;
        }
        public string Get()
        {
            return $"('{fontFamily}', '{fontSize}', '{fontStyle.ToLower()}'), fg={color.get()}";
        }
    }
}
