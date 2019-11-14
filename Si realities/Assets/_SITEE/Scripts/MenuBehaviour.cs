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
                SceneManager.LoadScene("HeartSitee");
                break;

            case (1):
                Application.OpenURL("https://sparknterest.com/collections/si-tee");
                break;

            case (2):
                SceneManager.LoadScene("Info");
                break;

            case (3):
                SceneManager.LoadScene("BrainLoader");
                break;
            case (4):
                SceneManager.LoadScene("HeartLoader");
                break;
            case (5):
                SceneManager.LoadScene("SkeletonLoader");
                break;
            case (6):
                SceneManager.LoadScene("DigestiveLoader");
                break;
            case (7):
                SceneManager.LoadScene("EyeExternalLoader");
                break;
            case (8):
                SceneManager.LoadScene("EyeInternalLoader");
                break;
            case (9):
                SceneManager.LoadScene("KidneyLoader");
                break;
            case (10):
                SceneManager.LoadScene("LungsLoader");
                break;







        }
    }
}
