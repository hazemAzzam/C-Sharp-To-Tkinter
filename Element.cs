using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    public struct Size
    {
        public int width { get; set; }
        public int height { get; set; }
        public string Width()
        {
            return width.ToString();
        }
        public string Height()
        {
            return height.ToString();
        }
    }
    public struct Point
    {
        public int x;
        public int y;
        public string X()
        {
            return x.ToString();
        }
        public string Y()
        {
            return y.ToString();
        }
    }
    public struct Font
    {
        public string name;
        public int size;
        public Color color;
        public string print()
        {
            return $"('{name}', '{size}')";
        }
    }
    public struct Color
    {
        public int R;
        public int G;
        public int B;
        public string toHEX()
        {
            return "'#" + R.ToString("X2") + G.ToString("X2") + B.ToString("X2") + "'";
        }
    }
    internal class Element
    {
        public string panelName { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public Size size { get; set; }
        public Point location { get; set; }

        public Font font { get; set; }
        public Color bg { get; set; }

        public string flatStyle { get; set; }

        public int borderwidth { get; set; } = 1;
        public bool isBackground { get; set; }

        public void createFrame(Panel panel)
        {
            List<string> lines = new List<string>();
            Color backColor = new Color();
            backColor.R = panel.BackColor.R; 
            backColor.B = panel.BackColor.B; 
            backColor.G = panel.BackColor.G;
            lines.Add($"        self.{panel.Name} = Frame(self.root, width={panel.Width}, height={panel.Height}, bg={backColor.toHEX()})");
            if (panel.Dock.ToString() == "None")
            {
                lines.Add($"        self.{panel.Name}.place(x={panel.Location.X}, y={panel.Location.Y})");
            }
            else
            {
                lines.Add($"        self.{panel.Name}.pack(side={panel.Dock.ToString().ToUpper().Replace("FILL", "CENTER")}, fill=BOTH)");
            }
            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
        public void print()
        {
            Dictionary<string, string> Style = new Dictionary<string, string>()
            {
                {"Flat", "SOLID"},
                {"Standard", "FLAT" },
                {"Popup", "GROOVE" },
                {"None", "FLAT" },
                {"FixedSingle", "RAISED" }
            };

            if (type == "TextBox")
            {
                type = "Entry";
            }

            List<string> lines = new List<string>();
            if (type == "PictureBox")
            {
                lines.Add($"        self.{name}_img = ImageTk.PhotoImage(Image.open('Resources\\\\{name}.jpg').resize(({size.Width()}, {size.Height()}), Image.ANTIALIAS))");
                lines.Add($"        self.{name} = Label(self.{panelName}, image = self.{name}_img)");
                lines.Add($"        self.{name}.place(width = {size.Width()}, height = {size.Height()}, x = {location.X()}, y = {location.Y()})");
            }
            else if (isBackground)
            {
                lines.Add($"        self.{name}_img = ImageTk.PhotoImage(Image.open('Resources\\\\{name}.jpg').resize(({size.Width()}, {size.Height()}), Image.ANTIALIAS))");
                lines.Add($"        self.{name} = {type}(self.{panelName}, text = '{text}', font = {font.print()}, bg = {bg.toHEX()}, fg = {font.color.toHEX()},image = self.{name}_img, relief={Style[flatStyle]})");
                lines.Add($"        self.{name}.place(width = {size.Width()}, height = {size.Height()}, x = {location.X()}, y = {location.Y()})");
            }
            else
            {
                lines.Add($"        self.{name} = {type}(self.{panelName}, text = '{text}', font = {font.print()}, bg = {bg.toHEX()}, fg = {font.color.toHEX()}, relief={Style[flatStyle]}, borderwidth={borderwidth})");
                lines.Add($"        self.{name}.place(width = {size.Width()}, height = {size.Height()}, x = {location.X()}, y = {location.Y()})");
            }

            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }

        public void createElements(Panel panel)
        {
            Control.ControlCollection controls = panel.Controls;

            foreach (Control control in controls)
            {
                Element element = new Element();

                // panel name
                element.panelName = panel.Name;

                // name
                element.name = control.Name;

                // type
                element.type = control.GetType().ToString().Replace("System.Windows.Forms.", "");

                // text
                element.text = control.Text;

                //size
                Size size = new Size();
                size.width = control.Size.Width;
                size.height = control.Size.Height;
                element.size = size;

                // location
                Point location = new Point();
                location.x = control.Location.X;
                location.y = control.Location.Y;
                element.location = location;

                // font
                Font font = new Font();
                font.name = control.Font.Name;
                font.size = (int)control.Font.Size;
                // font - fontColor
                Color fontColor = new Color();
                fontColor.R = control.ForeColor.R;
                fontColor.G = control.ForeColor.G;
                fontColor.B = control.ForeColor.B;
                font.color = fontColor;
                element.font = font;

                // background Color
                Color bg = new Color();
                bg.R = control.BackColor.R;
                bg.G = control.BackColor.G;
                bg.B = control.BackColor.B;
                element.bg = bg;

                // flat style and borderwidth
                if (element.type == "Button")
                {
                    element.flatStyle = ((Button)control).FlatStyle.ToString();
                    element.borderwidth = ((Button)control).FlatAppearance.BorderSize;
                }
                else if (element.type == "TextBox")
                {
                    element.flatStyle = ((TextBox)control).BorderStyle.ToString();
                }
                else if (element.type == "Label")
                    element.flatStyle = "None";
                else
                    element.flatStyle = "FixedSingle";

                

                // backgroun Image
                if (control.BackgroundImage != null)
                {
                    element.isBackground = true;
                    control.BackgroundImage.Save($"Resources\\{element.name}.jpg");
                }
                else
                {
                    element.isBackground = false;
                }
                // image Location
                if (element.type == "PictureBox")
                {
                    ((PictureBox)control).Image.Save($"Resources\\{element.name}.jpg");
                }
                element.print();
            }
        }
        public void toTkinter(Form form)
        {
            File.WriteAllText("tkinter.txt", string.Empty);

            foreach (Panel panel in form.Controls)
            {
                createFrame(panel);
                createElements(panel);
            }

            File.AppendAllText("tkinter.txt", $"        self.root.geometry('{form.Size.Width}x{form.Size.Height}')\n");
            Color panelColor = new Color();
            panelColor.R = form.BackColor.R;
            panelColor.G = form.BackColor.G;
            panelColor.B = form.BackColor.B;
            File.AppendAllText("tkinter.txt", $"        self.root.configure(bg = {panelColor.toHEX()})");
        }
    }
}
