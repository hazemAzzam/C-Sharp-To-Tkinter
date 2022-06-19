using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_to_Tkinter
{

    internal class Tkinter
    {
        public string name = "";
        public string parent = "";
        public string type = "";
        public int height;
        public int width;
        public int bd = 0; // border width
        public TkColor bg = new(); // background

        readonly Dictionary<string, string> Cursors = new()
        {
            {"Default", "arrow" },
            {"Cross", "crosshair" },
            {"IBeam", "xterm" },
            {"No", "X_cursor" },
            {"SizeAll", "fleur" },
            {"SizeNWSE", "top_left_corner" },
            {"SizeNS", "sb_v_double_arrow" },
            {"SizeWE", "sb_h_double_arrow" },
            {"UpArrow", "sb_up_arrow" },
            {"WaitCursor", "watch" },
            {"Help", "question_arrow" }
        };

        public string cursor = "";

        readonly Dictionary<string, string> Relief = new()
        {
            {"None", "flat" },
            {"Flat", "flat" },
            {"Popup", "raised" },
            {"Standard", "solid" },
            {"System", "groove" },
            {"Fixed3D", "solid" },
            {"FixedSingle", "solid" }
        };

        public string relief = "";

        public int x;
        public int y;

        public string dock = "None";

        public void Put(string parent, string name, int height, int width, Color bg, string cursor, string relief, int x, int y, string dock, int bd)
        {
            this.parent = parent;
            this.name = name; 
            this.height = height;
            this.width = width;
            this.bg.put(bg);
            this.cursor = cursor;
            this.relief = relief;
            this.x = x;
            this.y = y;
            this.dock = dock;
            this.bd = bd;
        }

        public string Draw()
        {
            File.AppendAllText("tkinter.txt", $"        \n## {name}\n");

            string line = "";

            // assign parent
            line += $"self.{parent}";

            // assign bg
            line += $", bg={bg.get()}";

            // assign cursor
            cursor = cursor.Replace("[Cursor: ", "").Replace("]", "");
            cursor = Cursors[cursor];
            line += $", cursor='{cursor}'";

            // assign relief
            relief = Relief[relief];
            line += $", relief='{relief}'";

            // assign bd
            line += $", bd={bd}";

            return line;
        }

        public string Place()
        {
            string line = "";

            if (dock == "None")
            {
                line += $".place(x={x}, y={y}, width={width}, height={height}";
            }
            else if (dock == "Fill")
            {
                line += $".pack(expand=1, fill=BOTH";
            }
            else
            {
                line += $".pack(side={dock.ToUpper()}, fill=BOTH";
            }
            return line;
        }
    }
}
