using UnityEngine;
namespace blocDrobitel
{
    public class conveirLevel : MonoBehaviour
    {
        public GameObject conv;
        public conveirDvizenia CD;
        public float[] lev;

        private void Start()
        {
            restart();
        }

        public void restart()
        {
            conv.SetActive(LevelControlir.sig.seveD.nroc.Conveir != 0);
            CD.siola = lev[LevelControlir.sig.seveD.nroc.Conveir];

        }
    }
}