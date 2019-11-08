using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class BrainLoader : MonoBehaviour
{
    private AssetBundleCreateRequest bundleRequest;

    private void Start()
    {
        bundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, "brain"));
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
            SceneManager.LoadScene("Brain");
        }
    }
}
