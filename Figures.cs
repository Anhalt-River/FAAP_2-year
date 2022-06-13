using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Geometric_experience;
using System.Drawing;

/* -----------------------
 * Geometric_figures_3 ---
 * -----------------------
 * Bakirov Karim_220 group
 */

namespace Geometric_experience
{
    public class Figures
    {
        List<Figure> Disc;
        public Figures()
        {
            Disc = new List<Figure>();
        }

        public void Add(Figure a)
        {
            Disc.Add(a);
        }

        public void Save(string path)
        {
            try
            {
                StreamWriter fileInfo = new StreamWriter(path);
                foreach (Figure c in Disc)
                {
                    fileInfo.WriteLine(c);
                }
                fileInfo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
               DialogResult result = MessageBox.Show(
                "Exception: " + e.Message,
                "Ошибка сохранения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                     
                }
            }
        }


        public void Load(string path)
        {
            Disc = new List<Figure>();
            try
            {
                StreamReader fileInfo = new StreamReader(path);
                string line = fileInfo.ReadLine();
                while (line != null)
                {
                    Listening(line);
                    line = fileInfo.ReadLine();
                }
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(
                 "Exception: " + e.Message,
                 "Ошибка загрузки",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);
            }
        }



        public void Listening(string line)
        {
            Point[] points = new Point[4];
            string[] newline = line.Split(";");
            string[] row_color = newline[0].Split(",");
            byte[] byte_mashap = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                string[] row_byte = row_color[i].Split(":");
                byte_mashap[i] = Convert.ToByte(row_byte[1]);
            }
            byte a = byte_mashap[0]; byte r = byte_mashap[1]; byte g = byte_mashap[2]; byte b = byte_mashap[3];
            Color color = Color.FromArgb(a, r, g, b);
            int size = Convert.ToInt32(newline[1]);
            Pen pen = new Pen(color, size);

            switch (newline[2])
            {
                case "Segment":
                    for (int i = 3; i < 5; i++)
                    {
                        string[] ar = (newline[i]).Split();
                        int x1 = Convert.ToInt32(ar[0]);
                        int y1 = Convert.ToInt32(ar[1]);
                        points[i - 3] = new Point(x1, y1);
                    }
                    Figure segment = new Segment(points[0], points[1]);
                    segment.Upen = pen;
                    Disc.Add(segment);
                    break;
                case "Triangle":
                    for (int i = 3; i < 6; i++)
                    {
                        string[] bt = (newline[i]).Split();
                        int x2 = Convert.ToInt32(bt[0]);
                        int y2 = Convert.ToInt32(bt[1]);
                        points[i - 3] = new Point(x2, y2);
                    }
                    Figure triangle = new Triangle(points[0], points[1], points[2]);
                    triangle.Upen = pen;
                    Disc.Add(triangle);
                    break;
                case "Rectangle":
                    Point center_rectanglus = new Point(); int height = 0; int weight = 0;
                    string[] cr = (newline[3]).Split();
                    int x3 = Convert.ToInt32(cr[0]);
                    int y3 = Convert.ToInt32(cr[1]);
                    center_rectanglus = new Point(x3, y3);
                    height = Convert.ToInt32(newline[4]); weight = Convert.ToInt32(newline[5]);
                    Figure rectangle = new Rectangle(center_rectanglus, weight, height);
                    rectangle.Upen = pen;
                    Disc.Add(rectangle);
                    break;
                case "Circle":
                    string[] ac = newline[3].Split();
                    int x = Convert.ToInt32(ac[0]);
                    int y = Convert.ToInt32(ac[1]);
                    Point center_circle = new Point(x, y);
                    Figure circle = new Circle(center_circle, Convert.ToInt32(newline[4]));
                    circle.Upen = pen;
                    Disc.Add(circle);
                    break;
                default:
                    Figure unknown = new Figure();
                    unknown.Upen = pen;
                    Disc.Add(unknown);
                    break;
            }
        }

        public void DrawAll(Graphics taked_holst, ref PictureBox taked_picturebox)
        {
            Bitmap bmp = new Bitmap(taked_picturebox.Width, taked_picturebox.Height);

            taked_picturebox.Image = bmp;

            using (taked_holst = Graphics.FromImage(taked_picturebox.Image))
            {
                foreach (Figure c in Disc)
                {
                    taked_holst = c.Draw(c.Upen, taked_holst);
                }
            }
        }
    }
}
