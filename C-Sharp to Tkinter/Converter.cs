using System.Windows.Forms;

namespace C_Sharp_to_Tkinter
{
    class Converter
    {
        public void convert(Form form, string name)
        {
            File.WriteAllText("tkinter.txt", string.Empty);

            // Create a new Control.ControlCollection to hold the sorted controls
            List<Control> sortedControls = new List<Control>();
            

            // Get an ordered enumerable of all controls on the form
            var orderedEnumerable = form.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ThenBy(c => c.Name);

            // Add the sorted controls to the new Control.ControlCollection
            foreach (var control in orderedEnumerable)
            {
                sortedControls.Add(control);
            }


            foreach (Control control in sortedControls)
            {
                switch (control.GetType().Name)
                {
                    case "Panel":
                        convertPanel(name, (Panel)control);
                        break;

                    case "Button":
                        TkButton button = new TkButton();
                        button.Put(name, (Button)control);
                        button.draw();
                        break;
                    case "TextBox":
                        TkEntry tkEntry = new TkEntry();
                        tkEntry.Put(name, (TextBox)control);
                        tkEntry.draw();
                        break;

                    case "Label":
                        TkLabel tkLabel = new TkLabel();
                        tkLabel.Put(name, (Label)control);
                        tkLabel.draw();
                        break;

                    case "PictureBox":
                        TkPictureBox pictureBox = new TkPictureBox();
                        pictureBox.Put(name, (PictureBox)control);
                        pictureBox.draw();
                        break;
                }
            }

            List<string> lines = new List<string>();
            File.AppendAllText("tkinter.txt", $"\n\t\t## {name}\n");
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

            // Create a new Control.ControlCollection to hold the sorted controls
            List<Control> sortedControls = new List<Control>();


            // Get an ordered enumerable of all controls on the form
            var orderedEnumerable = panel.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ThenBy(c => c.Name);

            // Add the sorted controls to the new Control.ControlCollection
            foreach (var control in orderedEnumerable)
            {
                sortedControls.Add(control);
            }

            for (int i = sortedControls.Count - 1; i >= 0; i--)
            {
                switch (sortedControls[i].GetType().Name)
                {
                    case "Panel":
                        convertPanel(panel.Name, (Panel)sortedControls[i]);
                        break;

                    case "Button":
                        TkButton button = new TkButton();
                        button.Put(panel.Name, (Button)sortedControls[i]);
                        button.draw();
                        break;
                    case "TextBox":
                        TkEntry tkEntry = new TkEntry();
                        tkEntry.Put(panel.Name, (TextBox)sortedControls[i]);
                        tkEntry.draw();
                        break;
                    case "Label":
                        TkLabel tkLabel = new TkLabel();
                        tkLabel.Put(panel.Name, (Label)sortedControls[i]);
                        tkLabel.draw();
                        break;

                    case "PictureBox":
                        TkPictureBox pictureBox = new TkPictureBox();
                        pictureBox.Put(panel.Name, (PictureBox)sortedControls[i]);
                        pictureBox.draw();
                        break;
                }
            }
        }
    }
}
