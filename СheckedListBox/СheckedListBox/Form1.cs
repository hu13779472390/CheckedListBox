using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkedListBox
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            checkedListBox1.AddItem(new CheckedListBoxItem("First Item", false));
            checkedListBox1.AddItem(new CheckedListBoxItem("Second Item", true));
            checkedListBox1.AddItem(new CheckedListBoxItem("Third Item", false));
            checkedListBox1.AddItem(new CheckedListBoxItem("Fourth Item", true));

            
          


        }

       

    }
}
