using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class MicroPaint : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pioro;
        public MicroPaint()
        {
            InitializeComponent();
            imgObrazek.Image = new Bitmap(524, 437);
            g = Graphics.FromImage(imgObrazek.Image);
            pioro = new Pen(Color.Black);
        }


        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        OpenFileDialog otworz = new OpenFileDialog();
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Otworz = new OpenFileDialog();

            Otworz.InitialDirectory = "C:\\Obrazki";
            Otworz.Title = "Otwórz plik";

            Otworz.Filter = "Pliki bmp|*.bmp|Pliki jpeg|*.jpg|Pliki gif|*.gif";

            Otworz.Multiselect = false;

            try
            {

                Otworz.ShowDialog();
                if (Otworz.FileName != "")
                {
                    Image rysunek;
                    string strNazwaPliku = Otworz.FileName;
                    rysunek = Image.FromFile(strNazwaPliku);
                    Clipboard.SetImage(rysunek);

                    rysunek = new Bitmap(strNazwaPliku);

                    g.DrawImage(rysunek, 0, 0);
                    imgObrazek.Refresh();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd odczytu pliku." + ex.Message, "Zakończenie programu", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        SaveFileDialog Zapisz = new SaveFileDialog();
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                imgObrazek.Image.Save(dialog.FileName);
        }

        private void czyscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            imgObrazek.Refresh();
        }

        private void tracksize_Scroll(object sender, EventArgs e)
        {
            double liczba;
            liczba = trkSize.Value;
            lblSize.Text = Convert.ToString(liczba);

            int rozmiar = trkSize.Value;
            pioro.Width = rozmiar;
        }





        private void imgObrazek_Click(object sender, EventArgs e)
        {

        }

        private void imgObrazek_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;
                imgObrazek.Refresh();
            }
        }


        private void imgObrazek_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;
                imgObrazek.Refresh();
            }
        }

        private void buttKolory_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = lblkolor.BackColor;
            dialog.ShowDialog();
            lblkolor.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
        }

        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = lblkolor.BackColor;
            dialog.ShowDialog();
            lblkolor.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
        }

        private void MicroPaint_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Black;
            lblkolor.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Aqua;
            lblkolor.BackColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Navy;
            lblkolor.BackColor = Color.Navy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Blue;
            lblkolor.BackColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Yellow;
            lblkolor.BackColor = Color.Yellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Maroon;
            lblkolor.BackColor = Color.Maroon;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            pioro.Color = Color.Fuchsia;
            lblkolor.BackColor = Color.Fuchsia;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Olive;
            lblkolor.BackColor = Color.Olive;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.White;
            lblkolor.BackColor = Color.White;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Red;
            lblkolor.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Aqua;
            lblkolor.BackColor = Color.Aqua;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Lime;
            lblkolor.BackColor = Color.Lime;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.GreenYellow;
            lblkolor.BackColor = Color.GreenYellow;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Green;
            lblkolor.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Maroon;
            lblkolor.BackColor = Color.Maroon;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pioro.Color = Color.Teal;
            lblkolor.BackColor = Color.Teal;
        }

        private void buttKolory_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = lblkolor.BackColor;
            dialog.ShowDialog();
            lblkolor.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
        }

    }
}