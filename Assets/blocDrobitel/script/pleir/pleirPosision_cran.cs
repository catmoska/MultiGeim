using UnityEngine;

namespace blocDrobitel
{
    public class pleirPosision_cran : MonoBehaviour
    {
        public Transform pleir;
        public Vector2[] pleirLevel;

        public GameObject[] crans;

        public void updeites()
        {
            if (LevelControlir.sig.Geims) return;
            pleir.position = pleirLevel[LevelControlir.sig.seveD.nroc.segments];
            pleir.rotation = Quaternion.identity;

            for(int i = 0; i < crans.Length; i++)
                crans[i].SetActive(false);
            crans[LevelControlir.sig.seveD.nroc.segments].SetActive(true);
        }
    }
}

