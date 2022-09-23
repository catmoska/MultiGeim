using System.Collections;
using UnityEngine;

namespace blocDrobitel
{
    public class obzectSpavn : MonoBehaviour
    {
        public Texture2D[] texturas;
        public GameObject Cub;
        public bool zagruzka;
        public int Sloi;

        public int kolisestvo;
        public int Maxkolisestvo;

        public float perlinMnoz;
        public float gradus = 30;

        private void Start()
        {
            spavns();
        }

        public void spavns()
        {
            int i = (LevelControlir.sig.seveD.Level-1)%texturas.Length;
            StartCoroutine(spavn(texturas[i]));
        }

        IEnumerator spavn(Texture2D tex)
        {
            kolisestvo = 0;
            int W = tex.width;
            int H = tex.height;
            int sloi = Sloi;

            for (int Y = 0; Y < H; Y++)
            {
                for (int X = 0; X< W; X++)
                {
                    Color col = tex.GetPixel(X, Y);
                    if (col.a == 1)
                    {
                        //Debug.Log(X + " " + Y + " " + Mathf.PerlinNoise(X * Cub.transform.localScale.x, Y * Cub.transform.localScale.y) + " " + Mathf.PerlinNoise(X, Y));
                        float ner = Mathf.PerlinNoise(X*0.36f, Y*0.36f);
                        Random.InitState((int)(ner*10000));
                        Vector3 pos = 
                            new Vector3(X * Cub.transform.localScale.x, Y * Cub.transform.localScale.y, 
                            Random.Range(-perlinMnoz, perlinMnoz));
                        GameObject GO = Instantiate(Cub,transform.position + pos, Quaternion.Euler(new Vector2(Random.Range(-gradus, gradus), Random.Range(-gradus, gradus))));
                        MeshRenderer MR = GO.GetComponent<MeshRenderer>();
                        MR.material = colorMatirialGet.sig.getMatiriols(col);
                        kolisestvo++;
                    }
                }
                if (zagruzka)
                {
                    if (sloi <= 0)
                    {
                        sloi = Sloi;
                        yield return null;
                    }
                    else
                        sloi--;
                }
            }
            Maxkolisestvo = kolisestvo;
            yield return null;
        }

        public void restart()
        {
            GameObject[] gem = GameObject.FindGameObjectsWithTag("bloc off");
            for (int i = 0; i < gem.Length; i++) Destroy(gem[i]);
            gem = GameObject.FindGameObjectsWithTag("bloc on");
            for (int i = 0; i < gem.Length; i++) Destroy(gem[i]);
        }
    }
}


