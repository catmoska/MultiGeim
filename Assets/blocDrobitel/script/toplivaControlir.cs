using UnityEngine;
using UnityEngine.UI;

namespace blocDrobitel
{
    public class toplivaControlir : MonoBehaviour
    {
        public float[] tonlivaColisestvo;
        public float topliva;
        public float maxtopliva;
        public Slider slid;

        private void Start()
        {
            restart();
        }

        private void FixedUpdate()
        {
            if(LevelControlir.sig.Geims)
            toplivaUpdeit(LevelControlir.sig.pleir.mosnast);
        }

        public void toplivaUpdeit(float toplivo)
        {
            if (toplivo <= 0) return;
            topliva -= toplivo* Time.fixedDeltaTime;
            updeitGui();
            if (topliva <= 0)
            {
                LevelControlir.sig.Geims = false;
            }
        }

        public void updeitGui()
        {
            maxtopliva = tonlivaColisestvo[tonlivaColisestvo.Length -
                LevelControlir.sig.magaz.Nstoimost.MaxTopliva.Length -
                LevelControlir.sig.seveD.nroc.MaxTopliva-1];
            slid.value = topliva / maxtopliva;
        }

        public void restart()
        {
            topliva = tonlivaColisestvo[LevelControlir.sig.seveD.nroc.topliva];
            updeitGui();
        }
    }
}