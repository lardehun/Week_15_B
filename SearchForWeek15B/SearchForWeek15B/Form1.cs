using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForWeek15B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void srcButton_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(ptrnTextBox.Text, RegexOptions.IgnoreCase);
            foreach (var listBoxItem in textListBox.Items)
            {
                if (r.Match(listBoxItem.ToString()).Success)
                {
                    matchedListBox.Items.Add(listBoxItem);
                } 
            }
        }
    }
}
