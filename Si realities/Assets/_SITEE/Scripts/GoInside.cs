using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoInside : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject inside;
    public GameObject Outside;
    public GameObject OutsideWithLabel;
    public GameObject InsideWithLabel;
    public ActivateInformation ActInfo;
    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   public void bakene()
    {
        inside.SetActive(true);
        Outside.SetActive(false);
        OutsideWithLabel.SetActive(false);
        ActInfo.InSideInfoDeactivate();
        

    }

    public void tswada()
    {
        inside.SetActive(false);
        InsideWithLabel.SetActive(false);
        Outside.SetActive(true);
        ActInfo.OutSideInfoDeactivate();
       
       
    }
}