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
            TempoBox.Text = "60";
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
            metronomeKernel.m_nBars = Convert.ToInt32(BarsCount.Value);
        }

        private void Tempo_TextChanged(object sender, EventArgs e)
        {
            metronomeKernel.sTempo = TempoBox.Text;
        }

        private void TempoBar_Scroll(object sender, EventArgs e)
        {
            TempoBox.Text = TempoBar.Value.ToString();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {

        }

        private void QuaterNotes_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_nClicksPerBar = 1;
        }

        private void EightNotes_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_nClicksPerBar = 2;
        }

        private void EightNoteTriplets_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_nClicksPerBar = 3;
        }

        private void MetronomeForm_Load(object sender, EventArgs e)
        {

        }

        private void StartStop_MClick(object sender, MouseEventArgs e)
        {
            if (!metronomeKernel.m_bIsPlaying)
            {
                metronomeKernel.StartClick();//metronomeKernel.Start();
                SetControlsEnabledOnClick(false);
            }
            else
            {
                metronomeKernel.Stop();
                SetControlsEnabledOnClick(true);
            }
        }
        private void SetControlsEnabledOnClick(bool bEnabled)
        {
            TempoBox.Enabled = bEnabled;
            TempoBar.Enabled = bEnabled;
            Timer.Enabled = bEnabled;
            BarsCount.Enabled = bEnabled;
        }
    }
}
