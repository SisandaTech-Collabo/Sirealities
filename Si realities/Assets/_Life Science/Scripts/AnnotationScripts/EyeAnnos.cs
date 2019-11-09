using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeAnnos : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update

    public GameObject CorneaInfo;
    public GameObject PupilInfo;
    public GameObject IrisInfo;
    public GameObject RetinaInfo;
    public GameObject OpticNerveInfo;
    void OnMouseDown()
    {


        switch (gameObject.name)
        {
            case "CorneaBTN":
                CorneaInfo.SetActive(true);
                PupilInfo.SetActive(false);
                IrisInfo.SetActive(false);
                RetinaInfo.SetActive(false);
                OpticNerveInfo.SetActive(false);

                break;

            case "PupilBTN":
                CorneaInfo.SetActive(false);
                PupilInfo.SetActive(true);
                IrisInfo.SetActive(false);
                RetinaInfo.SetActive(false);
                OpticNerveInfo.SetActive(false);
                break;

            case "IrisBTN":
                CorneaInfo.SetActive(false);
                PupilInfo.SetActive(false);
                IrisInfo.SetActive(true);
                RetinaInfo.SetActive(false);
                OpticNerveInfo.SetActive(false);
                break;

            case "RetinaBTN":
                CorneaInfo.SetActive(false);
                PupilInfo.SetActive(false);
                IrisInfo.SetActive(false);
                RetinaInfo.SetActive(true);
                OpticNerveInfo.SetActive(false);
                break;

            case "OpticNerveBTN":
                CorneaInfo.SetActive(false);
                PupilInfo.SetActive(false);
                IrisInfo.SetActive(false);
                RetinaInfo.SetActive(false);
                OpticNerveInfo.SetActive(true);
                break;


        }
    }
}