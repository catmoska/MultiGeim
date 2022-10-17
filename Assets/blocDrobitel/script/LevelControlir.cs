using UnityEngine;

namespace blocDrobitel
{
    public class LevelControlir : MonoBehaviour
    {
        public static LevelControlir sig;

        [Header("Seves")]
        public seves seveD;

        [Header("nola sig")]
        public Moneu mon;
        public obzectSpavn ObzecSpavs;
        public toplivaControlir toplivo;
        public Magazin magaz;
        public globalAudio AudioGlobal;
        public pilaControlir pleir;
        public pleirPosision_cran PleirPOs_cran;
        public endLevel EndLevel;
        public LevalUI levelUI;


        [Header("GlobalNeremenai")]
        public bool Geims;
        public void SetGeims(bool nar) => Geims = nar;

        private void Awake()
        {
            sig = this;
            RSeve();
        }

        private void OnEnable()
        {
            sig = this;
        }

        public void LevelUp()
        {
            seveD.Level++;
            seveD.nroc.segments = 0;
            seveD.nroc.topliva = 0;
            seveD.nroc.power = 0; 
            seveD.nroc.size = 0;
        }

        public void Seve()
        {
            //PlayerPrefs.SetInt("blocDrobitel_Level", seveD.Level);
            //PlayerPrefs.SetInt("blocDrobitel_Moneus", seveD.Moneus);

            //PlayerPrefs.SetInt("blocDrobitel_segments", seveD.nroc.segments);
            //PlayerPrefs.SetInt("blocDrobitel_topliva", seveD.nroc.topliva);
            //PlayerPrefs.SetInt("blocDrobitel_power", seveD.nroc.power);
            //PlayerPrefs.SetInt("blocDrobitel_size", seveD.nroc.size);
            //PlayerPrefs.SetInt("blocDrobitel_Conveir", seveD.nroc.Conveir);
            //PlayerPrefs.SetInt("blocDrobitel_MaxTopliva", seveD.nroc.MaxTopliva);
            //PlayerPrefs.SetInt("blocDrobitel_Mnozetell", seveD.nroc.Mnozetell);
        }

        public void RSeve()
        {
            //seveD.def();
            //if (!PlayerPrefs.HasKey("blocDrobitel_seve"))
            //{
            //    PlayerPrefs.SetInt("blocDrobitel_seve", 10);
            //    seveD.defFull();
            //    return;
            //}

            //if (PlayerPrefs.HasKey("blocDrobitel_Level")) seveD.Level = PlayerPrefs.GetInt("blocDrobitel_Level");
            //if (PlayerPrefs.HasKey("blocDrobitel_Moneus")) seveD.Moneus = PlayerPrefs.GetInt("blocDrobitel_Moneus");

            //if (PlayerPrefs.HasKey("blocDrobitel_segments")) seveD.nroc.segments = PlayerPrefs.GetInt("blocDrobitel_segments");
            //if (PlayerPrefs.HasKey("blocDrobitel_topliva")) seveD.nroc.topliva = PlayerPrefs.GetInt("blocDrobitel_topliva");
            //if (PlayerPrefs.HasKey("blocDrobitel_power")) seveD.nroc.power = PlayerPrefs.GetInt("blocDrobitel_power");
            //if (PlayerPrefs.HasKey("blocDrobitel_size")) seveD.nroc.size = PlayerPrefs.GetInt("blocDrobitel_size");
            //if (PlayerPrefs.HasKey("blocDrobitel_Conveir")) seveD.nroc.Conveir = PlayerPrefs.GetInt("blocDrobitel_Conveir");
            //if (PlayerPrefs.HasKey("blocDrobitel_MaxTopliva")) seveD.nroc.MaxTopliva = PlayerPrefs.GetInt("blocDrobitel_MaxTopliva");
            //if (PlayerPrefs.HasKey("blocDrobitel_Mnozetell")) seveD.nroc.Mnozetell = PlayerPrefs.GetInt("blocDrobitel_Mnozetell");
        }

        private void OnDestroy()
        {
            Seve();
        }
        private void OnApplicationQuit()
        {
            Seve();
        }
        private void OnApplicationPause(bool pause)
        {
            if (pause)
                Seve();
        }
    }
}