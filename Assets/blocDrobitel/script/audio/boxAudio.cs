using System.Collections;
using UnityEngine;

namespace blocDrobitel
{
    //[RequireComponent(typeof(AudioSource))]
    public class boxAudio : MonoBehaviour
    {
        public AudioSource AS;
        private bool stolknavenia;
        public blocHp BHP;
        public globalAudio GA;
        private bool nerviuRB = true;

        private void Awake()
        {
            AS.enabled = false;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (stolknavenia) return;
            stolknavenia = true;
            if (AS.isPlaying) return;
            if (GA.nomer >= GA.MaxNomer) return;

            if (BHP.kill)
            {
                string teg = collision.gameObject.tag;
                if (teg == "Player")
                {
                    if (nerviuRB)
                    {
                        nerviuRB = false;
                        AS.outputAudioMixerGroup = GA.AMG_slomalsa_Box;
                        Play(GA.GETRslomalsa_Box());
                        return;
                    }

                    if (GA.nrasent_lomania_Box < Random.value) 
                    {
                        AS.outputAudioMixerGroup = GA.AMG_lomania_Box;
                        Play(GA.GETRlomania_Box(), true); 
                    }
                    else 
                    {
                        AS.outputAudioMixerGroup = GA.AMG_obsi_Box;
                        Play(GA.GETRobsi_Box(), true); 
                    }
                    return;
                }
                else
                {
                    float mag = GA.Magnityda;
                    Rigidbody2D rbb = collision.gameObject.GetComponent<Rigidbody2D>();
                    if (rbb)
                        mag = rbb.velocity.magnitude;

                    if (mag < BHP.rb.velocity.magnitude) return;

                    float sila = Mathf.Clamp(BHP.rb.velocity.magnitude, 0, 1);
                    if (sila < 0.01 && rbb) return;
                    else if (!rbb) sila = 1;
                    if (teg == "bloc off" || teg == "bloc on")
                    {
                        if (GA.nrasent_nadeniaBox_Box < Random.value)
                        {
                            AS.outputAudioMixerGroup = GA.AMG_nadeniaBox_Box;
                            Play(GA.GETRnadeniaBox_Box(), false, sila);
                        }
                        else 
                        {
                            AS.outputAudioMixerGroup = GA.AMG_nadenia_Box;
                            Play(GA.GETRnadenia_Box(), false, sila);
                        }
                        return;
                    }
                    else
                    {
                        if (GA.nrasent_nadeniaNoBox_Box < Random.value)
                        {
                            AS.outputAudioMixerGroup = GA.AMG_nadeniaNoBox_Box;
                            Play(GA.GETRnadeniaNoBox_Box(), false, sila);
                        }
                        else 
                        {
                            AS.outputAudioMixerGroup = GA.AMG_nadenia_Box;
                            Play(GA.GETRnadenia_Box(), false, sila); 
                        }
                        return;
                    }
                }
            }
            else
            {
                if (GA.nrasent_lomania_Box < Random.value)
                {
                    AS.outputAudioMixerGroup = GA.AMG_lomania_Box;
                    Play(GA.GETRlomania_Box());
                }
                else
                {
                    AS.outputAudioMixerGroup = GA.AMG_obsi_Box;
                    Play(GA.GETRobsi_Box());
                }
                return;
            }
        }

        private void LateUpdate()
        {
            stolknavenia = false;
        }

        private void Start()
        {
            if (!BHP) BHP = GetComponent<blocHp>();
            GA = LevelControlir.sig.AudioGlobal;
        }

        private void Play(AudioClip Ac, bool zagluhona = false, float velu= 1)
        {
            float volume = (zagluhona ?
                Random.Range(GA.max_nriglus_value_Box, GA.max_nriglus_value_Box) :
                Random.Range(GA.min_value_Box, GA.max_value_Box)) *
                ((GA.nerexod1 <= GA.nomer) ? ((GA.nerexod2 <= GA.nomer)? GA.nerexod2_velu : GA.nerexod1_velu) : 1 )* velu;

            AS.volume = volume;
            AS.priority =(int)((1-volume) * 255)+5;
            AS.pitch = Random.Range(GA.min_pitch_Box, GA.max_pitch_Box);
            AS.panStereo = Random.Range(-GA.yxi_Box, GA.yxi_Box);
            AS.spatialBlend = Random.Range(GA.min_2D_Box, GA.max_3D_Box);

            AS.clip = Ac;
            AS.enabled = true;
            AS.Play();
            GA.AddNomer();
            StartCoroutine(musicMinus(Ac));
        }

        private bool musicMinusV;
        public IEnumerator musicMinus(AudioClip Ac)
        {
            musicMinusV = true;
            yield return new WaitForSeconds(Ac.length+0.01f);
            musicMinusV = false;
            GA.MinusNomer();
            AS.enabled = false;
        }

        private void OnDisable()
        {
            if(musicMinusV) GA.MinusNomer();
        }
    }
}
