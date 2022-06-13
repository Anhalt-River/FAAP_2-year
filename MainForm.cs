using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

/* 
 * -----------------------
 * Geometric_figures_3 ---
 * -----------------------
 * Bakirov Karim_220 group
 * -----------------------
*/

namespace Geometric_experience
{


    public partial class MainForm : Form
    {
        private Figures Collection;
        protected Graphics holst;

        public MainForm()
        {
            InitializeComponent();;
            holst = pictureMainBox1.CreateGraphics();
            Collection = new Figures();
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            Collection.Save(path);
        }

        private void btmLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            btmClear.PerformClick();
            Collection.Load(path);
            Collection.DrawAll(holst, ref pictureMainBox1);
        }

        private void listFigChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnData.Visible = true;
            pndata1.Visible = false;
            pndata2.Visible = false;
            pndata3.Visible = false;
            pnradius.Visible = false;
            pnWidthHeight.Visible = false;
            btnClearUnif.PerformClick();
            switch (listBoxUnifAll.SelectedIndex)
            {
                case 0:
                    pndata1.Visible = true;
                    pndata2.Visible = true;
                    break;
                case 1:
                    pndata1.Visible = true;
                    pndata2.Visible = true;
                    pndata3.Visible = true;
                    break;
                case 2:
                    pndata1.Visible = true;
                    pnWidthHeight.Visible = true;
                    break;
                case 3:
                    pndata1.Visible = true;
                    pnradius.Visible = true;
                    break;
            }
        }

        private void btnClearUnif_Click(object sender, EventArgs e)
        {
            tBoxX1.ResetText(); tBoxY1.ResetText();
            tBoxX2.ResetText(); tBoxY2.ResetText();
            tBoxX3.ResetText(); tBoxY3.ResetText();
            tBoxWidth.ResetText(); tBoxHeight.ResetText();
            tBoxRadius.ResetText();

        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            pictureMainBox1.Image = null;
            holst = pictureMainBox1.CreateGraphics();
            Collection = new Figures();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btmColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                btmColor.BackColor = colorDialog1.Color;
        }

        private void btmDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(tBoxX1.Text); int y1 = Convert.ToInt32(tBoxY1.Text);
                Point P1 = new Point(x1, y1);
                Figure newfigure = new Figure();
                Color taked_color = btmColor.BackColor;
                int size = Convert.ToInt32(textBoxSize.Text);
                Pen main_pen = new Pen(taked_color, size);
                switch (listBoxUnifAll.SelectedIndex)
                {
                    case 0:
                        int Sx2 = Convert.ToInt32(tBoxX2.Text); int Sy2 = Convert.ToInt32(tBoxY2.Text);
                        Point S_P2 = new Point(Sx2, Sy2);
                        newfigure = new Segment(P1, S_P2);
                        break;
                    case 1:
                        int Tx2 = Convert.ToInt32(tBoxX2.Text); int Ty2 = Convert.ToInt32(tBoxY2.Text);
                        Point T_P2 = new Point(Tx2, Ty2);
                        int Tx3 = Convert.ToInt32(tBoxX3.Text); int Ty3 = Convert.ToInt32(tBoxY3.Text);
                        Point T_P3 = new Point(Tx3, Ty3);
                        newfigure = new Triangle(P1, T_P2, T_P3);
                        Point[] points = new Point[3];
                        points[0] = P1;
                        points[1] = T_P2;
                        points[2] = T_P3;
                        break;
                    case 2:
                        int width = Convert.ToInt32(tBoxWidth.Text);
                        int height = Convert.ToInt32(tBoxHeight.Text);
                        newfigure = new Rectangle(P1, width, height);
                        break;
                    case 3:
                        newfigure = new Circle(P1, Convert.ToInt32(tBoxRadius.Text));
                        break;
                }
                newfigure.Draw(main_pen, holst);
                Collection.Add(newfigure);
            }
            catch (Exception f)
            {
                DialogResult result = MessageBox.Show(
                "Exception: " + f.Message,
                "Ошибка создания",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {

                }
            }
        }
    }
}
