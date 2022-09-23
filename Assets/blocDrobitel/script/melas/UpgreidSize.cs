using UnityEngine;

namespace blocDrobitel
{
    public class UpgreidSize : MonoBehaviour
    {
        public float[] size;
        public void updeites()
        {
            transform.localScale = Vector2.one * size[LevelControlir.sig.seveD.nroc.size];
        }
    }
}
