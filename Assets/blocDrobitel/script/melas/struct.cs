using UnityEngine.UI;
using TMPro;

namespace blocDrobitel
{
    /////////////////magaz
    [System.Serializable]
    public struct NrocascaStoimost
    {
        public int[] segments;
        public int[] topliva;
        public int[] power;
        public int[] size;

        public int[] Conveir;
        public int[] MaxTopliva;
        public int[] Mnozetell;
    }

    [System.Serializable]
    public struct guiSclad
    {
        public imeig_text segments;
        public imeig_text topliva;
        public imeig_text power;
        public imeig_text size;

        public imeig_text Conveir;
        public imeig_text MaxTopliva;
        public imeig_text Mnozetell;
    }

    [System.Serializable]
    public struct imeig_text
    {
        public Image ime;
        public TMP_Text text;
    }

    ///////////////////glavni

    [System.Serializable]
    public struct SevesDeta
    {
        public int Level;
        public int Moneus;

        public nrocasca nroc;

        public void def()
        {
            Level = 1;
            Moneus = 0;
        }

        public void defFull()
        {
            def();
        }
    }

    [System.Serializable]
    public struct nrocasca
    {
        public int segments;
        public int topliva;
        public int power;
        public int size;

        public int Conveir;
        public int MaxTopliva;
        public int Mnozetell;
    }
}