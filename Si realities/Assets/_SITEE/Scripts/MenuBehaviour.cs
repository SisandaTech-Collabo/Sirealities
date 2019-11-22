using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour {

    public void menubeh(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("Explore");
                break;

            case (1):
                Application.OpenURL("https://sparknterest.com/collections/si-tee");
                break;

            case (2):
                SceneManager.LoadScene("Info");
                break;

            case (3):
                SceneManager.LoadScene("Brain");
                break;
            case (4):
                SceneManager.LoadScene("Heart");
                break;
            case (5):
                SceneManager.LoadScene("Skeleton");
                break;
            case (6):
                SceneManager.LoadScene("Digestive");
                break;
            case (7):
                SceneManager.LoadScene("EyeExternal");
                break;
            case (8):
                SceneManager.LoadScene("EyeInternal");
                break;
            case (9):
                SceneManager.LoadScene("Kidney");
                break;
            case (10):
                SceneManager.LoadScene("Lungs");
                break;







        }
    }
}
