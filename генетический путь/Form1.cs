using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace генетический_путь
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<Dot[]> dots = new List<Dot[]>();
        int MaxGenerate = 20;
        int DeapGenerate = 2;
        Point finish;
        Point mous;
        bool isMous = false;
        bool Plaing = false;
        bool DrawAgain = true;
        int Generations = 0;
        Thread t1;

        private void NewGeneration()
        {
            int sum = 0;
            for (int i = dots.Count - 1; i >= 0 && i >= dots.Count - DeapGenerate; i--)
                sum += dots[i].Length;

            Dot[] mothers = new Dot[sum];
            for (int i = dots.Count - 1, k = 0; i >= 0 && i >= dots.Count - DeapGenerate; i--)
                for (int j = 0; j < dots[i].Length; j++, k++)
                    mothers[k] = dots[i][j];

            dots.Add(new Dot[MaxGenerate]);
            for (int i = 0; i < MaxGenerate; i++)
                dots[dots.Count - 1][i] = Dot.Select(mothers).GetDot();

            for (int i = 0; i < MaxGenerate; i++)
                if (isMous)
                    dots[dots.Count - 1][i].SetScore(mous);
                else
                    dots[dots.Count - 1][i].SetScore(finish);
        }
        private Dot MaxScore(Dot[] newDots)
        {
            Dot max = newDots[0];
            for (int i = 1; i < newDots.Length; i++)
                if (newDots[i].Score > max.Score) max = newDots[i];
            return max;
        }
        private void Simulation()
        {
            while (Plaing)
            {
                Generations++;
                NewGeneration();
                Dot winer = MaxScore(dots[dots.Count - 1]);
                if (winer.Score == 1)
                {
                    Plaing = false;
                    Invoke((Action)(() => StartStopButton.Text = "Start"));
                }
                if (AllCheckBox.Checked) DrawAll();
                else DrawWay(winer);
                if (DelCheckBox.Checked)
                    while (dots.Count > DeapGenerate)
                        dots.RemoveAt(0);
                Invoke((Action)(() => { label3.Text = Generations.ToString(); }));
                Thread.Sleep(25);
            }
        }
        private void ClearImage(Graphics g)
        {
            g.Clear(Color.White);
            Point Begining = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g.DrawLine(new Pen(Color.Black), Begining.X, 0, Begining.X, pictureBox1.Height);
            g.DrawLine(new Pen(Color.Black), 0, Begining.Y, pictureBox1.Width, Begining.Y);
            int min = Math.Min(Begining.X, Begining.Y) / (Math.Max(Math.Abs(finish.X), Math.Abs(finish.Y)) + 10);
            g.DrawEllipse(new Pen(Color.Green, 2), Begining.X + finish.X * min - 3, Begining.Y + finish.Y * min - 3, 7, 7);
        }
        private void DrawWay(Dot last)
        {
            if (pictureBox1.Width != 0 || pictureBox1.Height != 0)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Point Begining = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
                ClearImage(g);
                int min = Math.Min(Begining.X, Begining.Y) / (Math.Max(Math.Abs(finish.X), Math.Abs(finish.Y)) + 10);
                do
                {
                    if (last.Mather != null)
                        g.DrawLine(new Pen(Color.Black), (float)(Begining.X + last.X * min), (float)(Begining.Y + last.Y * min),
                            (float)(Begining.X + last.Mather.X * min), (float)(Begining.Y + last.Mather.Y * min));
                    g.FillEllipse(new SolidBrush(Color.Red), (float)(Begining.X + last.X * min - 1), (float)(Begining.Y + last.Y * min - 1), 2, 2);
                    last = last.Mather;
                } while (last != null);
                Invoke((Action)(() => pictureBox1.Image = bmp));
                DrawAgain = true;
            }
        }
        private void DrawAll()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            if (DrawAgain || DelCheckBox.Checked)
            {
                ClearImage(g);

                foreach(Dot[] x in dots) DrawGeneratoin(x, g);
                DrawAgain = false;
            }
            else 
            {
                bmp = (Bitmap)pictureBox1.Image;
                g = Graphics.FromImage(bmp);
                DrawGeneratoin(dots[dots.Count - 1], g);
            }
            Invoke((Action)(() => pictureBox1.Image = bmp));
        }
        private void DrawGeneratoin(Dot[] index, Graphics g)
        {
            if (pictureBox1.Width != 0 || pictureBox1.Height != 0)
            {
                Point Begining = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
                int min = Math.Min(Begining.X, Begining.Y) / (Math.Max(Math.Abs(finish.X), Math.Abs(finish.Y)) + 10);
                for (int j = 0; j < index.Length; j++)
                {
                    if (index[j].Mather != null)
                        g.DrawLine(new Pen(Color.Black), (float)(Begining.X + index[j].X * min), (float)(Begining.Y + index[j].Y * min),
                            (float)(Begining.X + index[j].Mather.X * min), (float)(Begining.Y + index[j].Mather.Y * min));
                    g.FillEllipse(new SolidBrush(Color.Red), (float)(Begining.X + index[j].X * min - 1), (float)(Begining.Y + index[j].Y * min - 1), 2, 2);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            MaxTrackBar.Value = MaxGenerate;
            DeapTrackBar.Value = DeapGenerate;
            label1.Text = MaxGenerate.ToString();
            label2.Text = DeapGenerate.ToString();
            label3.Text = "0";
        }
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            DrawAgain = true;
            if (Plaing)
            {
                Plaing = false;
                StartStopButton.Text = "Start";
                Thread.Sleep(10);
            }
            else
            {
                dots.Clear();
                finish = new Point(rand.Next(-70, 71), rand.Next(-70, 71));
                dots.Add(new Dot[1]);
                dots[0][0] = new Dot(0, 0);
                dots[0][0].SetScore(finish);
                MaxGenerate = MaxTrackBar.Value;
                DeapGenerate = DeapTrackBar.Value;
                Generations = 0;

                if (t1 != null) t1.Abort();
                t1 = new Thread(Simulation);
                StartStopButton.Text = "Stop";
                Plaing = true;
                t1.Start();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1 != null) t1.Abort();
        }
        private void MaxTrackBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = MaxTrackBar.Value.ToString();
        }
        private void DeapTrackBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = DeapTrackBar.Value.ToString();
        }
        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            DrawAgain = true;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            isMous = true;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            isMous = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point m = e.Location;
            Point Begining = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            m.X -= Begining.X;
            m.Y -= Begining.Y;
            int min = Math.Min(Begining.X, Begining.Y) / (Math.Max(Math.Abs(finish.X), Math.Abs(finish.Y)) + 10);
            m.X /= min;
            m.Y /= min;
            mous = m;
        }
    }
}

class Dot
{
    private static Random rand = new Random();
    public Dot Mather { get; private set; } = null;
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Score { get; private set; }

    public Dot(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public Dot(double X, double Y, Dot Mather)
    {
        this.X = X;
        this.Y = Y;
        this.Mather = Mather;
    }
    public Dot GetDot()
    {
        Dot dot = new Dot(X, Y, this);
        double angle = rand.NextDouble() * 2 * Math.PI;
        dot.X += Math.Cos(angle);
        dot.Y += Math.Sin(angle);
        return dot;

    }
    public void SetScore(Point end)
    {
        double t = 1 / Math.Sqrt((end.X - X) * (end.X - X) + (end.Y - Y) * (end.Y - Y));
        if (t > 1) Score = 1;
        else Score = t;
    }

    public static Dot Select(Dot[] dots)
    {
        double[] scores = new double[dots.Length];
        scores[0] = dots[0].Score;
        for (int i = 1; i < scores.Length; i++)
            scores[i] = scores[i - 1] + dots[i].Score;
        double t = rand.NextDouble() * scores[scores.Length - 1];
        for (int i = 0; i < scores.Length; i++)
            if (t <= scores[i]) return dots[i];
        return dots[rand.Next(dots.Length)];
    }
}