using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainLogic : MonoBehaviour
{
    // Start is called before the first frame update

    Animator brainAnim;

    void Start()
    {
        brainAnim = GetComponent<Animator>();
    }

    public void Expand()
    {
        brainAnim.SetTrigger("Open");
    }

    public void Shrink()
    {
        brainAnim.SetTrigger("Close");
    }
}
