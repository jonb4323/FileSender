using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSender
{
    public partial class FileSender6000 : Form
    {
        public string current_status = "IDLE"; // Default status
        public FileSender6000()
        {
            InitializeComponent();
        }

        string[] file_paths;

        private void button3_Click(object sender, EventArgs e)
        {
            char exitKey = ' ';
            while (exitKey != 'q') {
                using (var dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder";

                    if (dlg.ShowDialog(this) == DialogResult.OK) {
                        string folder = dlg.SelectedPath;
                        string src_addr = folder;
                        file_paths.Append(src_addr);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
