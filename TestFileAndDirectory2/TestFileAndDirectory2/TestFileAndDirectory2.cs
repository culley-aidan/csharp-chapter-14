using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileAndDirectory2
{
    public partial class TestFileAndDirectory2 : Form
    {
        string[] files;
        public TestFileAndDirectory2()
            =>   InitializeComponent();
        private void TestFileAndDirectory2_Load(object sender, EventArgs e)
        {
            string directory = "..\\..\\Epic_Directory";
            if (Directory.Exists(directory))
            {
                files = Directory.GetFiles(directory);
                foreach (string str in files)
                {
                    checkDirectories.Items.Add(str);
                }
            }
        }

        private void checkDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file;
            if (checkDirectories.SelectedIndex != -1)
            {
                file = files[checkDirectories.SelectedIndex];
                lblCreation.Text = $"{file} {File.GetCreationTimeUtc(file).ToString("mm/dd/yyyy @ hh:mm")}";
            }
        }
    }
}
