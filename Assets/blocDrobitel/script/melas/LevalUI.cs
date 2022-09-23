using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace blocDrobitel
{
    public class LevalUI : MonoBehaviour
    {
        public TMP_Text tex;

        public float prosli;
        public Slider slid;

        private void Start()
        {
            restart();
        }

        void Update()
        {
            float i = 1-((float)LevelControlir.sig.ObzecSpavs.kolisestvo / (float)LevelControlir.sig.ObzecSpavs.Maxkolisestvo);
            if (i != prosli)
            {
                slid.value = i;
                prosli = i;
            }
        }

        public void restart()
        {
            tex.text = "Level " + LevelControlir.sig.seveD.Level;
        }
    }
}