using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigestiveSystem : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject EsophagusInfo;
	public GameObject LiverInfo;
	public GameObject GallBladderInfo;
	public GameObject LargeInstestineInfo;
	public GameObject SmallIntestineInfo;
	public GameObject RectumInfo;

	void OnMouseDown()
	{


		switch (gameObject.name)
		{
			case "EsophagusBTN":
				EsophagusInfo.SetActive(true);
				LiverInfo.SetActive(false);
				GallBladderInfo.SetActive(false);
				LargeInstestineInfo.SetActive(false);
				SmallIntestineInfo.SetActive(false);
				RectumInfo.SetActive(false);
				break;

			case "LiverBTN":
				EsophagusInfo.SetActive(false);
				LiverInfo.SetActive(true);
				GallBladderInfo.SetActive(false);
				LargeInstestineInfo.SetActive(false);
				SmallIntestineInfo.SetActive(false);
				RectumInfo.SetActive(false);
				break;

			case "GallBladderBTN":
				EsophagusInfo.SetActive(false);
				LiverInfo.SetActive(false);
				GallBladderInfo.SetActive(true);
				LargeInstestineInfo.SetActive(false);
				SmallIntestineInfo.SetActive(false);
				RectumInfo.SetActive(false);
				break;

			case "LargeInstestineBTN":
				EsophagusInfo.SetActive(false);
				LiverInfo.SetActive(false);
				GallBladderInfo.SetActive(false);
				LargeInstestineInfo.SetActive(true);
				SmallIntestineInfo.SetActive(false);
				RectumInfo.SetActive(false);
				break;

			case "SmallInstestineBTN":
				EsophagusInfo.SetActive(false);
				LiverInfo.SetActive(false);
				GallBladderInfo.SetActive(false);
				LargeInstestineInfo.SetActive(false);
				SmallIntestineInfo.SetActive(true);
				RectumInfo.SetActive(false);
				break;

			case "RectumBTN":
				EsophagusInfo.SetActive(false);
				LiverInfo.SetActive(false);
				GallBladderInfo.SetActive(false);
				LargeInstestineInfo.SetActive(false);
				SmallIntestineInfo.SetActive(false);
				RectumInfo.SetActive(true);
				break;


		}
	}
}
