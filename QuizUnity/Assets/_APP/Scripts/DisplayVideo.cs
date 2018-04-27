using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisplayVideo : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject parent;
    public GameObject vbBtnObj;
    // Use this for initialization
    void Start()
    {
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

   
    //EnableAllChild
    public void EnableAllChild()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(true);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        EnableAllChild();
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
        Debug.Log("Button released");
    }
}
