using UnityEngine;
namespace blocDrobitel
{
    [CreateAssetMenu(fileName = "sev", menuName = "blocDrobitel/sev")]
    public class seves : ScriptableObject
    {
        public int Level;
        public int Moneus;

        public nrocasca nroc;

        public void def()
        {
            Level = 1;
            Moneus = 0;
        }

        public void defFull()
        {
            def();
        }
    }
}