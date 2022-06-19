namespace C_Sharp_to_Tkinter
{
    class Converter
    {
        public void convert(Form form, string name)
        {
            File.WriteAllText("tkinter.txt", string.Empty);

            Control.ControlCollection controls = form.Controls;

            for (int i = controls.Count - 1; i >= 0; i--)
            {
                switch (controls[i].GetType().Name)
                {

                    case "Panel":
                        convertPanel(name, (Panel)controls[i]);
                        break;

                    case "Button":
                        TkButton button = new TkButton();
                        button.Put(name, (Button)controls[i]);
                        button.draw();
                        break;
                    case "TextBox":
                        TkEntry tkEntry = new TkEntry();
                        tkEntry.Put(name, (TextBox)controls[i]);
                        tkEntry.draw();
                        break;

                    case "Label":
                        TkLabel tkLabel = new TkLabel();
                        tkLabel.Put(name, (Label)controls[i]);
                        tkLabel.draw();
                        break;

                    case "PictureBox":
                        TkPictureBox pictureBox = new TkPictureBox();
                        pictureBox.Put(name, (PictureBox)controls[i]);
                        pictureBox.draw();
                        break;
                }
            }

            List<string> lines = new List<string>();
            File.AppendAllText("tkinter.txt", $"        ## {name}\n");
            lines.Add($"        self.{name}.geometry('{form.Width}x{form.Height}')");
            TkColor background = new TkColor();
            background.put(form.BackColor);
            lines.Add($"        self.{name}.configure(background={background.get()})");
            File.AppendAllLines("tkinter.txt", lines.ToArray());
        }
        private void convertPanel(string parent, Panel panel)
        {
            TkFrame tkFrame = new TkFrame();
            tkFrame.put(parent, panel);
            tkFrame.draw();

            Control.ControlCollection controls = panel.Controls;
            for (int i = controls.Count - 1; i >= 0; i--)
            {
                switch (controls[i].GetType().Name)
                {
                    case "Panel":
                        convertPanel(panel.Name, (Panel)controls[i]);
                        break;

                    case "Button":
                        TkButton button = new TkButton();
                        button.Put(panel.Name, (Button)controls[i]);
                        button.draw();
                        break;
                    case "TextBox":
                        TkEntry tkEntry = new TkEntry();
                        tkEntry.Put(panel.Name, (TextBox)controls[i]);
                        tkEntry.draw();
                        break;
                    case "Label":
                        TkLabel tkLabel = new TkLabel();
                        tkLabel.Put(panel.Name, (Label)controls[i]);
                        tkLabel.draw();
                        break;

                    case "PictureBox":
                        TkPictureBox pictureBox = new TkPictureBox();
                        pictureBox.Put(panel.Name, (PictureBox)controls[i]);
                        pictureBox.draw();
                        break;
                }
            }
        }
    }
}
