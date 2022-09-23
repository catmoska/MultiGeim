using UnityEngine;

namespace blocDrobitel
{
    public class pleirYron : MonoBehaviour
    {
        public float[] Sila;

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "bloc on")
            {
                blocHp BH = collision.gameObject.GetComponent<blocHp>();
                if (BH) BH.NanestiYron(Sila[LevelControlir.sig.seveD.nroc.power]);
            }
        }
    }
}