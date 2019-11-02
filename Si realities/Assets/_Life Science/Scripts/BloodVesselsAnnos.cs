using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodVesselsAnnos : MonoBehaviour
{
    public GameObject redveinlabel;
    public GameObject redveininfo;
    public GameObject bluveinlabel;
    public GameObject bluveininfo;
    public GameObject MenuObj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        //ZAcube
        if (gameObject.name == "Redvein")
        {
            redveinlabel.SetActive(true);
            redveininfo.SetActive(true);
            bluveinlabel.SetActive(false);
            bluveininfo.SetActive(false);

            MenuObj.SetActive(false);

        }

        //ZAcube
        if (gameObject.name == "BluVein")
        {
            redveinlabel.SetActive(false);
            redveininfo.SetActive(false);
            bluveinlabel.SetActive(true);
            bluveininfo.SetActive(true);

            MenuObj.SetActive(false);
        }

        //ZAcube


        //ZAcube

    }

}