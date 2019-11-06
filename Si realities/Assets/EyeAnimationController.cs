using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation EyeExternal;
    //public GameObject ExpandBtn;
    //public GameObject ContractBtn;

    void Start()
    {
        EyeExternal.Play("idle");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Expand()
    {
        EyeExternal.Play("expand");
        //ExpandBtn.SetActive(false);
        //ContractBtn.SetActive(true);
    }

    public void Contract()
    {
        EyeExternal.Play("contract");
        //ExpandBtn.SetActive(true);
        //ContractBtn.SetActive(false);
    }

}
