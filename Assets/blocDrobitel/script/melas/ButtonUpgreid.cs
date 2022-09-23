using UnityEngine;

public class ButtonUpgreid : MonoBehaviour
{
    public bool naztia;
    public Animator an;
    public GameObject c1;
    public GameObject c2;

    private void Start()
    {
        nazal();
    }

    public void nazal()
    {
        naztia = !naztia;
        an.SetBool("def", naztia);
        c1.SetActive(naztia);
        c2.SetActive(!naztia);
    }
}
