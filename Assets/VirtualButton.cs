using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator anim;
    VirtualButtonBehaviour virtualButton;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        virtualButton = GetComponent<VirtualButtonBehaviour>();
        virtualButton.RegisterEventHandler(this);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
