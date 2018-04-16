using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AnimationByVB : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator cubeAni;
    public string aniName;
    // Use this for initialization
    void Start()
    {
        //vbBtnObj = GameObject.Find("VirtualButtonPlay");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play(aniName);
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
}
