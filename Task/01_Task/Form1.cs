﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;

namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e) // Não tem para essa versão. 
        {
            string url = txtSite.Text;

            WebClient web = new WebClient();
            //string html = web.DownloadString(url); Metodo Sincrono
            await web.DownloadStringTaskAsync(new Uri(url));
            txtResultado.Text = html;

        }

    }
}
