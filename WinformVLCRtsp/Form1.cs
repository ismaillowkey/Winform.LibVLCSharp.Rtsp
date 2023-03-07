using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformVLCRtsp
{
    public partial class Form1 : Form
    {
        // from nuget
        // add LibVLCSharp
        // add LibVLCSharp.Winform
        // add VideoLAN.LibVLC.Windows

        LibVLCSharp.Shared.LibVLC libVLC = new LibVLC();
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoView1.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libVLC);
        }

        private void BtnStream_Click(object sender, EventArgs e)
        {

            videoView1.MediaPlayer.Play(new Media(libVLC, TxtURLrtsp.Text, FromType.FromLocation));
        }

        
    }
}
