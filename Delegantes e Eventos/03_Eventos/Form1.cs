using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           

            btnCodificar.Click += btnCodificar_Click;
        }

        private void btnCodificar_Click(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode VideoEnc = new VideoEncode();
            VideoEnc.Encoded += new Email().EnviarMensagem;
            VideoEnc.Encoded += new SMS().EnviarMensagem;

            VideoEnc.Encode(video);
        }
    }
}
