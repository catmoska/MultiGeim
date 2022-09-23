using UnityEngine;
using UnityEngine.Events;

namespace blocDrobitel
{
    public class Magazin : MonoBehaviour
    {
        public NrocascaStoimost Nstoimost;
        public guiSclad sclad;

        public Color onCol;
        public Color offCol;
        public string max = "Max";

        public UnityEvent nocunca = new UnityEvent();

        private void Start()
        {
            GueUpdeit();
            nocunca.Invoke();
        }

        public void nocupca(int Sto)
        {
            Izalator(Sto);
            GueUpdeit();
            nocunca.Invoke();
        }

        public void Izalator(int Sto)
        {
            switch (Sto)
            {
                case 0:
                    int segments = LevelControlir.sig.seveD.nroc.segments;
                    if (segments >= Nstoimost.segments.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.segments[segments]))
                        LevelControlir.sig.seveD.nroc.segments++;
                    break;
                case 1:
                    int topliva = LevelControlir.sig.seveD.nroc.topliva;
                    if (topliva >= (Nstoimost.topliva.Length- Nstoimost.MaxTopliva.Length 
                        + LevelControlir.sig.seveD.nroc.MaxTopliva)) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.topliva[topliva]))
                        LevelControlir.sig.seveD.nroc.topliva++;
                    break;
                case 2:
                    int power = LevelControlir.sig.seveD.nroc.power;
                    if (power >= Nstoimost.power.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.power[power]))
                        LevelControlir.sig.seveD.nroc.power++;
                    break;
                case 3:
                    int sizes = LevelControlir.sig.seveD.nroc.size;
                    if (sizes >= Nstoimost.size.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.size[sizes]))
                        LevelControlir.sig.seveD.nroc.size++;
                    break;

                case 4:
                    int Conveir = LevelControlir.sig.seveD.nroc.Conveir;
                    if (Conveir >= Nstoimost.Conveir.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.Conveir[Conveir]))
                        LevelControlir.sig.seveD.nroc.Conveir++;
                    break;
                case 5:
                    int MaxTopliva = LevelControlir.sig.seveD.nroc.MaxTopliva;
                    if (MaxTopliva >= Nstoimost.MaxTopliva.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.MaxTopliva[MaxTopliva]))
                        LevelControlir.sig.seveD.nroc.MaxTopliva++;
                    break;
                case 6:
                    int Mnozetell = LevelControlir.sig.seveD.nroc.Mnozetell;
                    if (Mnozetell >= Nstoimost.Mnozetell.Length) return;
                    if (LevelControlir.sig.mon.Nocunka(Nstoimost.Mnozetell[Mnozetell]))
                        LevelControlir.sig.seveD.nroc.Mnozetell++;
                    break;
                default:
                    Debug.LogError("Eroor => Magazin => nocupca => " + Sto);
                    break;

            }
        }

        public void GueUpdeit()
        {
            ///////////////
            if (LevelControlir.sig.seveD.nroc.segments >= Nstoimost.segments.Length)
            {
                sclad.segments.ime.color = offCol;
                sclad.segments.text.text = max;
            }
            else
            {
                sclad.segments.ime.color = onCol;
                sclad.segments.text.text = Nstoimost.segments[LevelControlir.sig.seveD.nroc.segments].ToString();
            }
            ///////////////
            if (LevelControlir.sig.seveD.nroc.topliva >= (Nstoimost.topliva.Length - Nstoimost.MaxTopliva.Length + LevelControlir.sig.seveD.nroc.MaxTopliva))
            {
                sclad.topliva.ime.color = offCol;
                sclad.topliva.text.text = max;
            }
            else
            {
                sclad.topliva.ime.color = onCol;
                sclad.topliva.text.text = Nstoimost.topliva[LevelControlir.sig.seveD.nroc.topliva].ToString();
            }
            ///////////////
            if (LevelControlir.sig.seveD.nroc.power >= Nstoimost.power.Length)
            {
                sclad.power.ime.color = offCol;
                sclad.power.text.text = max;
            }
            else
            {
                sclad.power.ime.color = onCol;
                sclad.power.text.text = Nstoimost.power[LevelControlir.sig.seveD.nroc.power].ToString();
            }
            ///////////////
            if (LevelControlir.sig.seveD.nroc.size >= Nstoimost.size.Length)
            {
                sclad.size.ime.color = offCol;
                sclad.size.text.text = max;
            }
            else
            {
                sclad.size.ime.color = onCol;
                sclad.size.text.text = Nstoimost.size[LevelControlir.sig.seveD.nroc.size].ToString();
            }
            ///////////////

            if (LevelControlir.sig.seveD.nroc.Conveir >= Nstoimost.Conveir.Length)
            {
                sclad.Conveir.ime.color = offCol;
                sclad.Conveir.text.text = max;
            }
            else
            {
                sclad.Conveir.ime.color = onCol;
                sclad.Conveir.text.text = Nstoimost.Conveir[LevelControlir.sig.seveD.nroc.Conveir].ToString();
            }
            ///////////////
            if (LevelControlir.sig.seveD.nroc.MaxTopliva >= Nstoimost.MaxTopliva.Length)
            {
                sclad.MaxTopliva.ime.color = offCol;
                sclad.MaxTopliva.text.text = max;
            }
            else
            {
                sclad.MaxTopliva.ime.color = onCol;
                sclad.MaxTopliva.text.text = Nstoimost.MaxTopliva[LevelControlir.sig.seveD.nroc.MaxTopliva].ToString();
            }
            ///////////////
            if (LevelControlir.sig.seveD.nroc.Mnozetell >= Nstoimost.Mnozetell.Length)
            {
                sclad.Mnozetell.ime.color = offCol;
                sclad.Mnozetell.text.text = max;
            }
            else
            {
                sclad.Mnozetell.ime.color = onCol;
                sclad.Mnozetell.text.text = Nstoimost.Mnozetell[LevelControlir.sig.seveD.nroc.Mnozetell].ToString();
            }

        }
    }
}
