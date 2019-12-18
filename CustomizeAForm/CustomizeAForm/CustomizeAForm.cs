﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomizeAForm 
{
    public partial class CustomizeAForm : Form 
    {
        public CustomizeAForm()
            => InitializeComponent();
        private void btnSave_Click(object sender, EventArgs e) 
        {
            StreamWriter file = new StreamWriter(@"..\\..\\..\\..\\..\\CustomizeAForm\\CustomizeAForm\\Settings.txt");
            if (colorListBox.SelectedItem.ToString() != "" && maskedWidth.Text != "" && maskedHeight.Text != "" && txtTitle.Text != "") {
                file.WriteLine(colorListBox.SelectedItem);
                file.WriteLine(maskedWidth.Text + "," + maskedHeight.Text);
                file.WriteLine(txtTitle.Text);
                file.Close();
                btnSave.Enabled = false;
            }
        }
    }
}
