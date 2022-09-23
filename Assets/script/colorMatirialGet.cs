using System;
using UnityEngine;

public class colorMatirialGet : MonoBehaviour
{
    public static colorMatirialGet sig;

    public Material[] materls;
    [SerializeField] private int Smes = 51;
    [SerializeField] private int tact = 5;
    [Range(1, 4)]
    public int Zatic;

    private void OnEnable()
    {
        sig = this;
    }

    public Material getMatiriols(Color col, int zatic = -1)
    {
        return getMatiriols((int)(col.r*255), (int)(col.g * 255), (int)(col.b * 255),zatic);
    }

    public Material getMatiriols(int R,int G,int B,int zatic = -1)
    {
        if (zatic <= -1) zatic = Zatic;
        switch (zatic)
        {
            case 1:
                R = (R / Smes); if (R > tact) R = tact;
                G = (G / Smes); if (G > tact) G = tact;
                B = (B / Smes); if (B > tact) B = tact;
                break;
            case 2:
                R = (int)Math.Round(((decimal)R / Smes)); if (R > tact) R = tact;
                G = (int)Math.Round(((decimal)G / Smes)); if (G > tact) G = tact;
                B = (int)Math.Round(((decimal)B / Smes)); if (B > tact) B = tact;
                break;
            case 3:
                int R2 = (R / Smes); if (R2 > tact) R2 = tact;
                int G2 = (G / Smes); if (G2 > tact) G2 = tact;
                int B2 = (B / Smes); if (B2 > tact) B2 = tact;
                R = (int)Math.Round(((decimal)R / Smes)); if (R > tact) R = tact;
                G = (int)Math.Round(((decimal)G / Smes)); if (G > tact) G = tact;
                B = (int)Math.Round(((decimal)B / Smes)); if (B > tact) B = tact;
                R = (R + R2) / 2;
                G = (G + G2) / 2;
                B = (B + B2) / 2;
                break;
            case 4:
                int R3 = (R / Smes); if (R3 > tact) R3 = tact;
                int G3 = (G / Smes); if (G3 > tact) G3 = tact;
                int B3 = (B / Smes); if (B3 > tact) B3 = tact;
                R = (int)Math.Round(((decimal)R / Smes)); if (R > tact) R = tact;
                G = (int)Math.Round(((decimal)G / Smes)); if (G > tact) G = tact;
                B = (int)Math.Round(((decimal)B / Smes)); if (B > tact) B = tact;
                R = (R * R3) / 2; if (R > tact) R = tact;
                G = (G * G3) / 2; if (G > tact) G = tact;
                B = (B * B3) / 2; if (B > tact) B = tact;
                break;
            default:
                Debug.LogError("Number");
                R = (R / Smes); if (R > tact) R = tact;
                G = (G / Smes); if (G > tact) G = tact;
                B = (B / Smes); if (B > tact) B = tact;
                break;
        }

        int podsot= ((R * 36) + (G * 6) + (B));
        if (materls.Length <= podsot)
            return materls[materls.Length-1];
        return materls[podsot];
    }


}