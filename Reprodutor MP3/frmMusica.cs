using System;
using System.Windows.Forms;


namespace MyMp3Player
{
    public partial class frmMusica : Form
    {
     
        public frmMusica()
        {
            InitializeComponent();
          
        }
       
        private void btnPasta_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            btnRetroceder.Enabled = true;
           
          
        }

        private void btnReproduzir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            btnReproduzir.Enabled = false;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnRetroceder.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            btnReproduzir.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = true;




        }
    }
}