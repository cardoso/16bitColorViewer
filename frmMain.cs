using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16bitColorViewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.Width = 270;
            UpdateBG();
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            UpdateBG();
        }

        public void UpdateBG()
        {
            try
            {
                this.pnBG.BackColor = GetColorFrom16bit(UInt16.Parse(txtColor.Text));
                lblRGB.Text =
                    " R: " + this.pnBG.BackColor.R +
                    " G: " + this.pnBG.BackColor.G +
                    " B: " + this.pnBG.BackColor.B;
            }
            catch { }

            Color negative = Color.FromArgb(255, 255 - this.pnBG.BackColor.R, 255 - this.pnBG.BackColor.G, 255 - this.pnBG.BackColor.B);
            lblColor.BackColor = negative;
            lblRGB.ForeColor = negative;
            cbTopMost.BackColor = negative;
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbTopMost.Checked;
        }

        public static Color GetColorFrom16bit(UInt16 n)
        {
            byte R = (byte)((n >> 11) << 3);
            byte G = (byte)((((n >> 5) << 5) >> 5) << 2);
            byte B = (byte)(((n << 11) >> 11) << 3);

            Color color = Color.FromArgb(R, G, B);

            return color;
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool expanded = false;
        private void btnExpand_Click(object sender, EventArgs e)
        {
            expanded = !expanded;

            if (expanded)
            {
                this.Width = 440;
                btnExpand.Text = "<";
            }
            else
            {
                this.Width = 270;
                btnExpand.Text = ">";
            }
        }

        public static UInt16 Get16bitFromRGB(int R, int G, int B)
        {
            return (UInt16)(((R >> 3) << 11) | ((G >> 2) << 5) | ((B >> 3)));
        }

        private void Updatetxt16bitFromRGB()
        {
            int R = 0;
            int G = 0;
            int B = 0;

            try { R = int.Parse(txtR.Text); }
            catch { R = 0; }

            try { G = int.Parse(txtG.Text); }
            catch { G = 0; }

            try { B = int.Parse(txtB.Text); }
            catch { B = 0; }

            txt16bitFromRGB.Text = Get16bitFromRGB(R, G, B).ToString();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            Updatetxt16bitFromRGB();
        }

        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            Updatetxt16bitFromRGB();
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Updatetxt16bitFromRGB();
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
