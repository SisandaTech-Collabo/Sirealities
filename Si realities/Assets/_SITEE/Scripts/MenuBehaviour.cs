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

        }
    }
}
