using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{
    internal class TkColor
    {
        Color color;

        public void put(Color color)
        {
            this.color = color;
        }

        public string get()
        {
            return $"{RGBtoHEX(color)}";
        }

        private string RGBtoHEX(Color color)
        {
            return $"'#{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}'";
        }

    }
}
