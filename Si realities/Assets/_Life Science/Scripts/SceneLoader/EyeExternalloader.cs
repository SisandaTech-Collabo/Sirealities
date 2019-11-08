using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class EyeExternalloader : MonoBehaviour
{
	private AssetBundleCreateRequest bundleRequest;

	private void Start()
	{
		bundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, "eyeexternal"));
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
			SceneManager.LoadScene("EyeExternal");
		}
	}
}

