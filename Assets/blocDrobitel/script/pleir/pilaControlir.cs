using System;
using UnityEngine;

namespace blocDrobitel
{
    public class pilaControlir : MonoBehaviour
    {
        public float Speed;
        private Rigidbody2D Rb2;
        public Transform posStart;
        public float radiysDistanses;
        public float mosnast;

        public DynamicJoystick Djast;

        private void Start()
        {
            Rb2 = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            Rb2.isKinematic = !LevelControlir.sig.Geims;
            digasa();
            Debug.DrawRay(transform.position, Rb2.velocity, Color.blue);
            Debug.DrawRay(posStart.position, (Vector2)(transform.position - posStart.position).normalized * radiysDistanses, Color.black);
        }

        private void digasa()
        {
            if (!LevelControlir.sig.Geims)
            {
                Rb2.velocity *=0.9f;
                return;
            }
            float Xmuv = diMax(Djast.Horizontal, Input.GetAxis("Horizontal"));
            float Ymuv = diMax(Djast.Vertical, Input.GetAxis("Vertical"));


            Rb2.velocity = new Vector2(Xmuv, Ymuv) * Speed;
            mosnast = Mathf.Clamp(Math.Abs(Xmuv) + Math.Abs(Xmuv), 0, 1);
        }

        public float diMax(float a, float b)
        {
            if (Math.Abs(a) > Math.Abs(b))
                return a;
            return b;
        }
    }
}

