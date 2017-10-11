using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBForm
{
    public partial class RGBFORM : Form
    {
        OIL oil=new OIL();
        RGBFORM formrgb;
        public RGBFORM()
        {
            InitializeComponent();
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            
        }
        public void ColorRead(int red, int green, int blue)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            oil.BackColor = Color.FromArgb(trackBar2.Value, trackBar1.Value, trackBar3.Value);
            oil.Show();

        }
    }
}
