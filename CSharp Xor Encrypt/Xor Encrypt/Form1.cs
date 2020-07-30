using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xor_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxes_KePress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1')
            {
                e.Handled = true;
            }
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            byte Code = Convert.ToByte(DataTextBox.Text, 2);
            byte Key = Convert.ToByte(KeyTextBox.Text, 2);
            ResultLabel.Text = Convert.ToString(Code ^ Key, 2);
        }
    }
}
