using UnityEngine;
using UnityEngine.SceneManagement;

namespace menu
{
    public class nerexodSenes : MonoBehaviour
    {
        public static void nerexod(int sen)
        {
            Debug.LogWarning(sen);
            SceneManager.LoadScene(sen);
        }
    }
}

