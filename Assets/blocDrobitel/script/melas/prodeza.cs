using UnityEngine;

namespace blocDrobitel
{
    public class prodeza : MonoBehaviour
    {
        public ParticleSystem ps;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "bloc off")
            {
                Destroy(collision.gameObject);
                ps.Play();
                LevelControlir.sig.mon.AddMoneus((int)(1+(LevelControlir.sig.seveD.nroc.Mnozetell*0.1f + 1f)));
            }
        }
    }
}