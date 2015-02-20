using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Metronome
{
    //TODO : timer & barcount checkboxes; radiobuttons for timer/barcount; 
    enum eSubDivision { eQuaters = 0, eEighth, eTriplets }

    class MetronomeKernel
    {
        public bool m_bIsControlsAvailable { set; get; }
        public bool m_bIsAccentSet { set; get; }
        public string m_sTempo { set; get; }
        private int m_nBarsPlayed;
        public int m_nBars { get; set; }
        private int m_nClicks;
        public int m_nClicksPerBar { set; get; }
        public bool m_bIsPlaying { set; get; }
        SoundPlayer m_PlayerHighSound;
        SoundPlayer m_PlayerLowSound;
        SoundPlayer m_PlayerAvgSound;
        public Thread m_ClickThread;
        void SetBarSubdivision(eSubDivision subdiv)
        {
            switch (subdiv)
            {
                case eSubDivision.eQuaters:
                    m_nClicksPerBar = 1;
                    break;
                case eSubDivision.eEighth:
                    m_nClicksPerBar = 2;
                    break;
                case eSubDivision.eTriplets:
                    m_nClicksPerBar = 3;
                    break;
            }
        }
        public void Click()
        {
            try
            {
                int nTempo = Convert.ToInt32(m_sTempo);
                int nCurrentTempo = ((60 * 1000) / (nTempo * m_nClicksPerBar));
                if (!m_bIsPlaying)
                {
                    m_bIsPlaying = true;
                    m_bIsControlsAvailable = false;
                    while (true)
                    {
                        if (m_nClicks == m_nClicksPerBar * 4)
                        {
                            m_nBarsPlayed++;
                            m_nClicks = 0;
                            if (m_nBarsPlayed == m_nBars)
                                Stop();
                        }
                        if (m_nClicks == 0 && m_bIsAccentSet == true)
                            m_PlayerHighSound.Play();
                        else if ((m_nClicks != 0 && m_nClicksPerBar == 2 && m_nClicks % 2 == 0 && m_bIsAccentSet == true) ||
                                ((m_nClicks != 0 && m_nClicksPerBar == 3 && m_nClicks % 3 == 0 && m_bIsAccentSet == true)))
                            m_PlayerLowSound.Play();
                        else
                            m_PlayerAvgSound.Play();
                        Thread.Sleep(nCurrentTempo);
                        m_nClicks++;
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("No tempo specified.\nPlease specify tempo value.",
                                                                         "PISTON!",
                                                              MessageBoxButtons.OK,
                                                           MessageBoxIcon.Warning);
            }

            catch (System.DivideByZeroException)
            {
                this.Stop();
                MessageBox.Show("0 is too slow.\nEven you are better than this!",
                                                                        "PISTON!",
                                                             MessageBoxButtons.OK,
                                                          MessageBoxIcon.Warning);
            }
           
        }
        public void Stop()
        {
            if (m_bIsPlaying)
            {
                m_PlayerHighSound.Stop();
                m_PlayerLowSound.Stop();
                m_ClickThread.Abort();
                m_nClicks = 0;
            }
            m_bIsPlaying = false;
            m_bIsControlsAvailable = true;
        }
        public MetronomeKernel() 
        {
            m_PlayerHighSound = new SoundPlayer(Metronome.Properties.Resources.HighSeiko);
            m_PlayerLowSound = new SoundPlayer(Metronome.Properties.Resources.MARIMBA1);
            m_PlayerAvgSound = new SoundPlayer(Metronome.Properties.Resources.MARIMBA2);
            m_nClicksPerBar = 1;
            m_sTempo = "60"; //Z!!
            m_nBars = 100;
        }
        public void StartClick()
        {
            m_ClickThread = new Thread(Click);
            m_ClickThread.Start();
        }
    }
}
