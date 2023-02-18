namespace C_Sharp_to_Tkinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Converter convert = new Converter();
            convert.convert(this, "master");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }
    }
}    