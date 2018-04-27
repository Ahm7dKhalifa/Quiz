using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class StopVideo : MonoBehaviour, IVirtualButtonEventHandler
{ 

    public GameObject parent;
    public GameObject vbBtnObj;
    // Use this for initialization
    void Start()
    {
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    //DisableAllChild
    public void DisableAllChild()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
   

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        DisableAllChild();
        Debug.Log("Button released");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
        Debug.Log("Button released");
    }
}
