using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;

        }

        private void hakıımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Yunus Balıkcı tarafından yapıldı","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Url="https://www.imdb.com/title/tt1392190/";
        }

        private void ıLoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Url="https://www.imdb.com/title/tt0431308/?ref_=nv_sr_srsg_2";
        }

        private void yıldızlarınArasındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Url= "https://www.imdb.com/title/tt0454586/?ref_=nv_sr_srsg_1";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Url="https://www.imdb.com/title/tt1457767/?ref_=nv_sr_srsg_0";
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Url = "https://www.imdb.com/title/tt1355644/?ref_=nv_sr_srsg_0";
        }

        private void webControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
