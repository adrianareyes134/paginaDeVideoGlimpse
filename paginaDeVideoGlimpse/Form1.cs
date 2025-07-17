using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paginaDeVideoGlimpse
{
    public partial class Form1 : Form
    {

        // Lista donde se guardarán todos los videos subidos
        List<string> listaVideos = new List<string>();

        // Índice del video actual
        int indiceActual = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnstory2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalirdevideos_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Le diste like al video!");
        }

        private void btnshare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Reposteaste este video!");
        }

        private void btnglimpse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de video|*.mp4;*.avi;*.mov";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaVideo = ofd.FileName;
                listaVideos.Add(rutaVideo); // 👈 lo agregamos a la lista

                indiceActual = listaVideos.Count - 1; // Nos posicionamos en el último video
                playervideo.URL = rutaVideo;
                playervideo.Ctlcontrols.play();

                MessageBox.Show("¡Subiste un video! 🎥");
            }
        }

        private void GlimpseNow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de video|*.mp4;*.avi;*.mov";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playervideo.URL = ofd.FileName;
                MessageBox.Show("¡Subiste un nuevo Glimpse!");
            }
        }

        List<string> videos = new List<string>() {
            "video1.mp4",
            "video2.mp4",
            "video3.mp4"
};
        int currentVideoIndex = 0;

        private void btncambiar1_Click(object sender, EventArgs e)
        {
            if (listaVideos.Count == 0) return;

            indiceActual++;
            if (indiceActual >= listaVideos.Count)
                indiceActual = 0;

            playervideo.URL = listaVideos[indiceActual];
            playervideo.Ctlcontrols.play();
        }

        private void btncambiar2_Click(object sender, EventArgs e)
        {
            if (listaVideos.Count == 0) return;

            indiceActual++;
            if (indiceActual >= listaVideos.Count)
                indiceActual = 0;

            playervideo.URL = listaVideos[indiceActual];
            playervideo.Ctlcontrols.play();
        }
    }
}
