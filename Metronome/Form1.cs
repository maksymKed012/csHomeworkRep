using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;
namespace Metronome
{
    public  partial class MetronomeForm : Form
    {
        private MetronomeKernel metronomeKernel;
        public MetronomeForm()
        {
            metronomeKernel = new MetronomeKernel();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Bars_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Tempo_TextChanged(object sender, EventArgs e)
        {
            metronomeKernel.sTempo = TempoBox.Text;
        }

        private void TempoBar_Scroll(object sender, EventArgs e)
        {

        }

        private void StartStop_Click(object sender, EventArgs e)
        {

        }

        private void QuaterNotes_CheckedChanged(object sender, EventArgs e)
        {
           // if (this.
        }

        private void EightNotes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EightNoteTriplets_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetronomeForm_Load(object sender, EventArgs e)
        {

        }

        private void StartStop_MClick(object sender, MouseEventArgs e)
        {
            if (!metronomeKernel.m_bIsPlaying)
                metronomeKernel.Start();
            else
                metronomeKernel.Stop();
        }
    }
}
