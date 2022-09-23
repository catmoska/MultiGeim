using UnityEngine;

namespace blocDrobitel
{
    public class AudioMotor : MonoBehaviour
    {
        public float mosnastEnd;
        public float sag = 0.01f;
        public AudioSource AS;

        private void FixedUpdate()
        {
            if (!LevelControlir.sig.Geims)
            {
                AS.volume *= 0.9f;
                mosnastEnd = 0;
                return;
            }
            float plei = LevelControlir.sig.pleir.mosnast;
            if (plei!= mosnastEnd)
            {
                if(plei> mosnastEnd)
                    mosnastEnd += sag;
                else
                    mosnastEnd -= sag;
                
                if(Mathf.Abs( mosnastEnd - plei)< sag)
                    mosnastEnd = plei;
            }
            AS.volume = Mathf.Clamp(mosnastEnd, 0, 0.8f)+0.2f;
        }
    }
}