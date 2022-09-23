using UnityEngine;
using UnityEngine.Events;

namespace blocDrobitel
{
    public class ResetLevel : MonoBehaviour
    {
        public GameObject menu;
        public GameObject geim;
        public UnityEvent restarts = new UnityEvent();

        public void restart()
        {
            LevelControlir.sig.ObzecSpavs.restart();
            LevelControlir.sig.Seve();
            LevelControlir.sig.ObzecSpavs.spavns();
            LevelControlir.sig.Geims = false;
            LevelControlir.sig.toplivo.restart();
            LevelControlir.sig.PleirPOs_cran.updeites();
            LevelControlir.sig.EndLevel.Restart();
            LevelControlir.sig.levelUI.restart();
            LevelControlir.sig.magaz.GueUpdeit();
            restarts.Invoke();
            geim.SetActive(false);
            menu.SetActive(true);
        }
    }
}
