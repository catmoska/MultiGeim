using UnityEngine;
using TMPro;

namespace blocDrobitel
{
    public class endLevel : MonoBehaviour
    {
        public int osibaka;
        public GameObject endCanvas;
        public GameObject EndPocazatel;
        public TMP_Text moneu;
        private bool GeimsNrosli;
        private int zarabotoc;

        private void Update()
        {
            updeitBox();
            updeitToplivo();
            if (GeimsNrosli != LevelControlir.sig.Geims)
            {
                zarabotoc = LevelControlir.sig.seveD.Moneus;
                GeimsNrosli = LevelControlir.sig.Geims;
            }
        }

        public void updeitBox()
        {
            if (!LevelControlir.sig.Geims) return;

            if (LevelControlir.sig.ObzecSpavs.kolisestvo <= osibaka)
            {
                novtor(true);
                LevelControlir.sig.LevelUp();
            }
        }

        public void updeitToplivo()
        {
            if (LevelControlir.sig.toplivo.topliva <= 0)
            {
                novtor(false);
            }
        }

        public void novtor(bool i)
        {
            endCanvas.SetActive(true);
            EndPocazatel.SetActive(i);
            this.enabled = false;
            LevelControlir.sig.Geims = false;
            moneu.text = Converters.convermMoneu(LevelControlir.sig.seveD.Moneus - zarabotoc) + "$";
        }

        public void Restart()
        {
            endCanvas.SetActive(false);
            EndPocazatel.SetActive(false);
            this.enabled = true;
        }
    }
}