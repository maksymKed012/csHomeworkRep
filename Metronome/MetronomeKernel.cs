using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Metronome
{
    enum eSubDivision { eQuaters = 0, eEighth, eTriplets }

    class MetronomeKernel
    {
        public string sTempo { set; get; }
        private int m_nBarsPlayed;
        private int m_nBars;
        private int m_nClicks;
        public int m_nClicksPerBar { set; get; }
        public bool m_bIsPlaying { set; get; }
        SoundPlayer player;
        void SetBarSubdivision(eSubDivision subdiv)
        {
            switch (subdiv)
            {
                case eSubDivision.eQuaters:
                    m_nClicksPerBar = 4;
                    break;
                case eSubDivision.eEighth:
                    m_nClicksPerBar = 8;
                    break;
                case eSubDivision.eTriplets:
                    m_nClicksPerBar = 12;
                    break;
            }
        }
        //bool IsPlaying() { return m_bIsPlaying; }
        public void Start()
        {
            int nTempo = Convert.ToInt32(sTempo);
            int  nCurrentTempo = ((60 * 1000) / (nTempo * m_nClicksPerBar));
            //SoundPlayer player = new SoundPlayer(Metronome.Properties.Resources.Click);
            if(!m_bIsPlaying)
                while (true)
                {
                    player.Play();
                    Thread.Sleep(nCurrentTempo);
                }
            m_bIsPlaying = true;
        }
        public void Stop()
        {
            if (m_bIsPlaying)
            {
                player.Stop();
            }
            m_bIsPlaying = false;
        }
        public MetronomeKernel() 
        {
            player = new SoundPlayer(Metronome.Properties.Resources.Click);
            m_nClicksPerBar = 4;
            sTempo = "60"; //Z!!
        }
    }
}
