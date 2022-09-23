using UnityEngine;

public class localizatPos : MonoBehaviour
{
    public Vector3 pos;
    
    public bool RBon;
    public bool R2D;
    private Rigidbody2D RB2;
    private Rigidbody RB;
    void Update()
    {
        transform.localPosition = pos;
        if (RBon)
        {
            if (R2D)
            {
                if (RB2)
                    RB2.velocity *= 0;
                else
                    RB2 = GetComponent<Rigidbody2D>();
            }
            else
            {
                if (RB) 
                    RB2.velocity *= 0;
                else
                    RB = GetComponent<Rigidbody>();
            }
        }
    }
}
