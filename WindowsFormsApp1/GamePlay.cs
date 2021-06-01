using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GamePlay : Form
    {
        public Random rand = new Random();
        public GamePlay()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(PlayerManager1);
            myThread.Start();
        }

        public void PlayerManager1()
        {
            Thread myThread = new Thread(PlayerManager2);
            myThread.Start();

            int posX = 640;
            var startTime1 = System.Diagnostics.Stopwatch.StartNew();
            do
            {
                posX -= rand.Next(1, 10);
                Thread.Sleep(rand.Next(60, 80));
                PlayerButton1.Location = new Point(posX, 80);
            }
            while (posX >= 0);

            startTime1.Stop();
            textBox1.Text = $"Player1 Finish Time: {startTime1.ElapsedMilliseconds} - Milliseconds";
        }

        public void PlayerManager2()
        {
            Thread myThread = new Thread(PlayerManager3);
            myThread.Start();

            int posX = 640;
            var startTime2 = System.Diagnostics.Stopwatch.StartNew();
            do
            {
                posX -= rand.Next(1, 10);
                Thread.Sleep(rand.Next(60, 80));
                PlayerButton2.Location = new Point(posX, 215);
            }
            while (posX >= 0);

            startTime2.Stop();
            textBox2.Text = $"Player2 Finish Time: {startTime2.ElapsedMilliseconds} - Milliseconds";
        }

        public void PlayerManager3()
        {
            int posX = 640;
            var startTime3 = System.Diagnostics.Stopwatch.StartNew();
            do
            {
                posX -= rand.Next(1, 10);
                Thread.Sleep(rand.Next(60, 80));
                PlayerButton3.Location = new Point(posX, 350);
            }
            while (posX >= 0);

            startTime3.Stop();
            textBox3.Text = $"Player3 Finish Time: {startTime3.ElapsedMilliseconds} - Milliseconds";
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(PlayerManager1);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            myThread.Start();
        }
    }
}
