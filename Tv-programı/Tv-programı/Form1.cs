using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tv_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://31.210.157.109/360tv/360tvlive2/playlist.m3u8 ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://media.netd.com.tr/S2/HLS_LIVE/cnn_turk/index.m3u8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://yayin3.canlitv.com:1935/canlitv/disney/playlist.m3u8 ";
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://live.netd.com.tr/S1/HLS_LIVE/dreamturktv/index.m3u8";
        }
    }
}
