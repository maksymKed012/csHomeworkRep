using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Metronome
{
    //TODO : debug bar counter.
    enum eSubDivision { eQuaters = 0, eEighth, eTriplets }

    class MetronomeKernel
    {
        public string sTempo { set; get; }
        private int m_nBarsPlayed;
        public int m_nBars { get; set; }
        private int m_nClicks;
        public int m_nClicksPerBar { set; get; }
        public bool m_bIsPlaying { set; get; }
        SoundPlayer m_Player;
        Thread m_ClickThread;
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
            int nTempo = Convert.ToInt32(sTempo);
            int  nCurrentTempo = ((60 * 1000) / (nTempo * m_nClicksPerBar));
            if (!m_bIsPlaying)
            {
                m_bIsPlaying = true;
                while (true)
                {
                    if (m_nClicks > m_nClicksPerBar * 4)
                    {
                        m_nBarsPlayed++;
                        m_nClicks = 0;
                        if (m_nBarsPlayed > m_nBars)
                            Stop() ;
                    }
                    m_Player.Play();
                    Thread.Sleep(nCurrentTempo);
                    m_nClicks++;
                }
            }
        }
        public void Stop()
        {
            if (m_bIsPlaying)
            {
                m_Player.Stop();
                m_ClickThread.Abort();
            }
            m_bIsPlaying = false;
        }
        public MetronomeKernel() 
        {
            //m_ClickThread = new Thread(Click);
            m_Player = new SoundPlayer(Metronome.Properties.Resources.Click);
            //Thread ClickThread = new Thread(player.Play());
            m_nClicksPerBar = 1;
            sTempo = "60"; //Z!!
        }
        public void StartClick()
        {
            m_ClickThread = new Thread(Click);
            m_ClickThread.Start();
        }
    }
}
