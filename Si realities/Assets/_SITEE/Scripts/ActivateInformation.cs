using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInformation : MonoBehaviour
{
    // Start is called before the first frame update



    //Outside
    
    public GameObject OutsideHeartNonAnimated;
    public GameObject OutsideHeartAnimated;
    public AudioSource OutsideHeartAS;
   

    //Inside
    
    public GameObject InsideheartNonAnimated;
    public GameObject InsideHeartAnimated;
    public AudioSource InsideHeartAS;
    //public Animation InsideHeartAni;

    //Outside
    public void OutsideInfoActivate()
    {

        
        OutsideHeartNonAnimated.SetActive(true);
        OutsideHeartAnimated.SetActive(false);
        
     
    }
    public void OutSideInfoDeactivate()
    {



        OutsideHeartNonAnimated.SetActive(false);
        OutsideHeartAnimated.SetActive(true);
        OutsideHeartAS.Play();
       
    }

    //Inside
    public void InsideInfoActivate()
    {

      
        InsideheartNonAnimated.SetActive(true);
        InsideHeartAnimated.SetActive(false);
      
    }
    public void InSideInfoDeactivate()
    {

       
        InsideheartNonAnimated.SetActive(false);
        InsideHeartAnimated.SetActive(true);
        InsideHeartAS.Play();
        
    }
}
