using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainAnnos : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject FrontalLobesInfo;
	public GameObject ParientalLobesInfo;
	public GameObject TemporalLobesInfo;
	public GameObject OccipitalLobesInfo;


	void OnMouseDown()
	{


		switch (gameObject.name)
		{
			case "FrontalLobesBTN":
				FrontalLobesInfo.SetActive(true);
				ParientalLobesInfo.SetActive(false);
				TemporalLobesInfo.SetActive(false);
				OccipitalLobesInfo.SetActive(false);
				

				break;

			case "ParientalLobesBTN":
                FrontalLobesInfo.SetActive(false);
                ParientalLobesInfo.SetActive(true);
                TemporalLobesInfo.SetActive(false);
                OccipitalLobesInfo.SetActive(false);
                break;

			case "TemporalLobesBTN":
                FrontalLobesInfo.SetActive(false);
                ParientalLobesInfo.SetActive(false);
                TemporalLobesInfo.SetActive(true);
                OccipitalLobesInfo.SetActive(false);
                break;

			case "OccipitalLobesBTN":
                FrontalLobesInfo.SetActive(false);
                ParientalLobesInfo.SetActive(false);
                TemporalLobesInfo.SetActive(true);
                OccipitalLobesInfo.SetActive(false);
                break;

			


		}
	}
}
