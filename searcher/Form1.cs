using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace searcher
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        public void search_button_Click(object sender, EventArgs e)
        {
            string textbox = search_box.Text;
            string textbox_mod = textbox.Replace(" ", "+");

            if (Google.Checked)
            { 
                System.Diagnostics.Process.Start("www.google.de/search?q=" + textbox_mod);
            }

            else if (Wikipedia.Checked)
            {
                System.Diagnostics.Process.Start("https://de.wikipedia.org/w/index.php?search=" + textbox_mod);
            }

            else if (Linguee.Checked)
            {
                System.Diagnostics.Process.Start("www.linguee.de/deutsch-englisch/search?source=auto&query=" + textbox_mod);
            }

            else if (DeepL.Checked)
            {
                System.Diagnostics.Process.Start("www.deepl.com/translator");
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            search_box.Text = "";
        }
    }
}
