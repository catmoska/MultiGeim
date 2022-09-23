using UnityEngine;
using UnityEngine.Audio;

namespace blocDrobitel
{
    public class globalAudio : MonoBehaviour
    {
        [Header("AudioClip")]
        public AudioClip[] obsi_Box;
        public AudioClip[] lomania_Box;
        public AudioClip[] slomalsa_Box;
        public AudioClip[] nadeniaBox_Box;
        public AudioClip[] nadeniaNoBox_Box;
        public AudioClip[] nadenia_Box;

        [Header("nrasent")]
        [Range(0, 1)] public float nrasent_lomania_Box;
        [Range(0, 1)] public float nrasent_slomalsa_Box;
        [Range(0, 1)] public float nrasent_nadeniaBox_Box;
        [Range(0, 1)] public float nrasent_nadeniaNoBox_Box;
        [Range(0, 1)] public float nrasent_nadenia_Box;


        public AudioClip GETRobsi_Box() => obsi_Box[Random.Range(0, obsi_Box.Length)];
        public AudioClip GETRlomania_Box() => lomania_Box[Random.Range(0, lomania_Box.Length)];
        public AudioClip GETRslomalsa_Box() => slomalsa_Box[Random.Range(0, slomalsa_Box.Length)];
        public AudioClip GETRnadeniaBox_Box() => nadeniaBox_Box[Random.Range(0, nadeniaBox_Box.Length)];
        public AudioClip GETRnadeniaNoBox_Box() => nadeniaNoBox_Box[Random.Range(0, nadeniaNoBox_Box.Length)];
        public AudioClip GETRnadenia_Box() => nadenia_Box[Random.Range(0, nadenia_Box.Length)];

        [Header("value")]
        [Range(0, 1)] public float max_value_Box;
        [Range(0, 1)] public float min_value_Box;
        [Range(0, 1)] public float max_nriglus_value_Box;
        [Range(0, 1)] public float min_nriglus_value_Box;

        [Header("pitch")]
        [Range(-3, 3)] public float max_pitch_Box;
        [Range(-3, 3)] public float min_pitch_Box;

        [Header("yxi")]
        [Range(0, 1)] public float yxi_Box;

        [Header("3D-2D")]
        [Range(0, 1)] public float max_3D_Box;
        [Range(0, 1)] public float min_2D_Box;

        [Header("nomer")]
        [HideInInspector] public int nomer;
        [Range(1, 255)] public int MaxNomer;
        [Range(1, 255)] public int nerexod1;
        [Range(1, 255)] public int nerexod2;

        [Range(0, 1)] public float nerexod1_velu;
        [Range(0, 1)] public float nerexod2_velu;

        public void AddNomer() => nomer++;
        public void MinusNomer() => nomer--;
        [Header("defolt")]
        [Range(0, 100)]
        public float Magnityda; 
        public AudioMixerGroup AMG_obsi_Box;
        public AudioMixerGroup AMG_lomania_Box;
        public AudioMixerGroup AMG_slomalsa_Box;
        public AudioMixerGroup AMG_nadeniaBox_Box;
        public AudioMixerGroup AMG_nadeniaNoBox_Box;
        public AudioMixerGroup AMG_nadenia_Box;



    }
}
