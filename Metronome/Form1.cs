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
            metronomeKernel.m_nBars = Convert.ToInt32(BarsCount.Value);
        }

        private void Tempo_TextChanged(object sender, EventArgs e)
        {
            metronomeKernel.sTempo = TempoBox.Text;
            try
            {
                if (Convert.ToInt32(TempoBox.Text) >= 0 && Convert.ToInt32(TempoBox.Text) <= 300)
                    TempoBar.Value = Convert.ToInt32(TempoBox.Text);
            }
            catch (Exception)
            {
                TempoBar.Value = 0;
                Console.WriteLine();
            }
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
            if (metronomeKernel.m_bIsPlaying == true)
            {
                metronomeKernel.Stop();
                metronomeKernel.StartClick();
            }
        }

        private void EightNotes_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_nClicksPerBar = 2;
            if (metronomeKernel.m_bIsPlaying == true)
            {
                metronomeKernel.Stop();
                metronomeKernel.StartClick();
            }
        }

        private void EightNoteTriplets_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_nClicksPerBar = 3;
            if (metronomeKernel.m_bIsPlaying == true)
            {
                metronomeKernel.Stop();
                metronomeKernel.StartClick();
            }
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

        private void EnableBarCountCheckBox_CheckedChanged (object sender, EventArgs e)
        {
            BarsCount.Enabled = EnableBarCountCheckBox.Checked;
        }

        private void EnableTimerCheckBox_CheckedChanged (object sender, EventArgs e)
        {
            Timer.Enabled = EnableTimerCheckBox.Checked;
        }
        private void SetControlsEnabledOnClick(bool bEnabled)
        {
            TempoBox.Enabled = bEnabled;
            TempoBar.Enabled = bEnabled;
            Timer.Enabled = bEnabled;
            BarsCount.Enabled = bEnabled;
            EnableTimerCheckBox.Enabled = bEnabled;
            EnableBarCountCheckBox.Enabled = bEnabled;
            AccentUbBeatsCkeckBox.Enabled = bEnabled;
        }

        private void AccentUbBeatsCkeckBox_CheckedChanged(object sender, EventArgs e)
        {
            metronomeKernel.m_bIsAccentSet = AccentUbBeatsCkeckBox.Checked;
        }

      
    }
}
