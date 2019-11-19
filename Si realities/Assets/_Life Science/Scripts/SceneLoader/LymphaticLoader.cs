using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LymphaticLoader : MonoBehaviour
{
    private AssetBundleCreateRequest bundleRequest;

    private void Start()
    {
        bundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, "lymphatic"));
        if (bundleRequest == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
    }

    private void Update()
    {
        if (bundleRequest.isDone)
        {
            StartCoroutine(OpenScene());
            
        }
        IEnumerator OpenScene()
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("LymphaticSystem");
        }

    }
        
}
