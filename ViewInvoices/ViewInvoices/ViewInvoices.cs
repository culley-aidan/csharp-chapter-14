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

namespace ViewInvoices
{
    public partial class ViewInvoices : Form
    {
        const char DELIM = ',';
        const string FILENAME = "Invoices.txt";
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public ViewInvoices()
            => InitializeComponent();
        private void btnRecords_Click(object sender, EventArgs e)
        {
            recordIn = reader.ReadLine();
            fields = recordIn.Split(DELIM);
            invoiceBox.Text = fields[0];
            nameBox.Text = fields[1];
            amountBox.Text = fields[2];
        }
    }
}
