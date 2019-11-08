using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnnos : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject EyeSocketInfo;
    public GameObject SkullInfo;
    public GameObject CervicalInfo;
    public GameObject ScapulaInfo;
    public GameObject SternumInfo;
    public GameObject SacrumInfo;
    public GameObject PatellaInfo;
    public GameObject TibiaInfo;
    public GameObject FibulaInfo;
    public GameObject TarsalsInfo;

   
    void OnMouseDown()
    {
      

		switch (gameObject.name)
		{
			case "EyeSocket":
			EyeSocketInfo.SetActive(true);
			SkullInfo.SetActive(false);
			CervicalInfo.SetActive(false);
			ScapulaInfo.SetActive(false);
			SternumInfo.SetActive(false);
			SacrumInfo.SetActive(false);
			PatellaInfo.SetActive(false);
			TibiaInfo.SetActive(false);
			FibulaInfo.SetActive(false);
		    TarsalsInfo.SetActive(false);
			break;

            case "Skull":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(true);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "CervicalVerterbra":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(true);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Scapula":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(true);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Sternum":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(true);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Sacrum":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(true);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Patella":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(true);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Tibia":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(true);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(false);
            break;

            case "Fibula":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(true);
            TarsalsInfo.SetActive(false);
            break;

            case "Tarsals":
            EyeSocketInfo.SetActive(false);
            SkullInfo.SetActive(false);
            CervicalInfo.SetActive(false);
            ScapulaInfo.SetActive(false);
            SternumInfo.SetActive(false);
            SacrumInfo.SetActive(false);
            PatellaInfo.SetActive(false);
            TibiaInfo.SetActive(false);
            FibulaInfo.SetActive(false);
            TarsalsInfo.SetActive(true);
            break;
        }
    }
}
