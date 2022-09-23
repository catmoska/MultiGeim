using UnityEngine;

namespace blocDrobitel
{
    public class conveirDvizenia : MonoBehaviour
    {
        public float siola;
        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "bloc off")
            {
                Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                rb.AddForce(siola * Vector2.left* 0.001f);
            }
        }
    }
}
