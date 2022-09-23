using UnityEngine;

namespace blocDrobitel
{
    public class blocHp : MonoBehaviour
    {
        public float StartHp;
        public float Hp;
        public bool kill { get; private set; }
        public Rigidbody2D rb;

        private void Awake()
        {
            Hp = StartHp;
        }

        public void NanestiYron(float Yron)
        {
            if (kill) return;

            Hp -= Yron;

            if (Hp <= 0)
            {
                kill = true;
                rb = gameObject.AddComponent<Rigidbody2D>();
                gameObject.tag = "bloc off";
                rb.mass = 0;
                gameObject.isStatic = false;

                LevelControlir.sig.ObzecSpavs.kolisestvo--;
            }
        }
    }
}