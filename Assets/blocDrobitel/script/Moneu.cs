using UnityEngine;
using TMPro;

namespace blocDrobitel
{
    public class Moneu : MonoBehaviour
    {
        public TMP_Text text;

        private void Start()
        {
            RenderingUIupdeit();
        }

        public void AddMoneus(int suma)
        {
            if (suma <= 0) return;

            LevelControlir.sig.seveD.Moneus += suma;
            RenderingUIupdeit();
        }

        public bool Nocunka(int stoimost)
        {
            if (stoimost > LevelControlir.sig.seveD.Moneus)
                return false;
            LevelControlir.sig.seveD.Moneus -= stoimost;
            RenderingUIupdeit();
            return true;
        }

        public void RenderingUIupdeit()
        {
            
            text.text = Converters.convermMoneu(LevelControlir.sig.seveD.Moneus).ToString() + "$";
        }
    }

}
