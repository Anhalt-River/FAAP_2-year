using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Geometric_experience
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path, richTextBox1.Text);
        }

        private void btmLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            string text = File.ReadAllText(path);
            richTextBox1.Text = text;
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            if (punAdd.Visible == false)
            {
                punAdd.Visible = true;
            }
            else
            {
                punAdd.Visible = false;
            }
        }

        private void btnFigChoose_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(textBoxX1.Text); int y1 = Convert.ToInt32(textBoxY1.Text);
                Point P1 = new Point(x1, y1);
                string result = "";
                switch (listFigChoose.SelectedIndex)
                {
                    case 0:
                        int Sx2 = Convert.ToInt32(textBoxX2.Text); int Sy2 = Convert.ToInt32(textBoxY2.Text);
                        Point S_P2 = new Point(Sx2, Sy2);
                        result = ("Segment " + $"{P1},{S_P2}");
                        break;
                    case 1:
                        int Tx2 = Convert.ToInt32(textBoxX2.Text); int Ty2 = Convert.ToInt32(textBoxY2.Text);
                        Point T_P2 = new Point(Tx2, Ty2);
                        int Tx3 = Convert.ToInt32(textBoxX3.Text); int Ty3 = Convert.ToInt32(textBoxY3.Text);
                        Point T_P3 = new Point(Tx3, Ty3);
                        result = ("Triangle " + $"{P1},{T_P2},{T_P3}");
                        break;
                    case 2:
                        int Rx2 = Convert.ToInt32(textBoxX2.Text); int Ry2 = Convert.ToInt32(textBoxY2.Text);
                        Point R_P2 = new Point(Rx2, Ry2);
                        int Rx3 = Convert.ToInt32(textBoxX3.Text); int Ry3 = Convert.ToInt32(textBoxY3.Text);
                        Point R_P3 = new Point(Rx3, Ry3);
                        int Rx4 = Convert.ToInt32(textBoxX4.Text); int Ry4 = Convert.ToInt32(textBoxY4.Text);
                        Point R_P4 = new Point(Rx4, Ry4);
                        result = ("Rectangle " + $"{P1},{R_P2},{R_P3},{R_P4}");
                        break;
                    case 3:
                        result = ("Circle " + $"{P1},{textBoxRadius.Text}");
                        break;
                }
                richTextBox1.AppendText(result);
                richTextBox1.SelectedText += "\r";
            }
            catch (Exception f)
            {
                return;
            }
        }

        private void listFigChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            panUnifAll.Visible = true;
            pan1.Visible = false;
            pan2.Visible = false;
            pan3.Visible = false;
            pan4.Visible = false;
            panRadius.Visible = false;
            btnClearUnif.PerformClick();
            switch (listFigChoose.SelectedIndex)
            {
                case 0:
                    pan1.Visible = true;
                    pan2.Visible = true;
                    break;
                case 1:
                    pan1.Visible = true;
                    pan2.Visible = true;
                    pan3.Visible = true;
                    break;
                case 2:
                    pan1.Visible = true;
                    pan2.Visible = true;
                    pan3.Visible = true;
                    pan4.Visible = true;
                    break;
                case 3:
                    pan1.Visible = true;
                    panRadius.Visible = true;
                    break;
            }
        }

        private void btnClearUnif_Click(object sender, EventArgs e)
        {
            textBoxX1.ResetText(); textBoxY1.ResetText();
            textBoxX2.ResetText(); textBoxY2.ResetText();
            textBoxX3.ResetText(); textBoxY3.ResetText();
            textBoxX4.ResetText(); textBoxY4.ResetText();
            textBoxRadius.ResetText();

        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btmLook_Click(object sender, EventArgs e)
        {
            if (panLookTemp.Visible == false)
            {
                panLookTemp.Visible = true;
            }
            else
            {
                panLookTemp.Visible = false;
            }
        }
    }
}
