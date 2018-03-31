using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnScript : MonoBehaviour, IVirtualButtonEventHandler{
    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject btnGrab;
    public GameObject cube;
    public GameObject hook;

    public float speed = 3.0f;

    private Animator anim;
    private bool isLeftBtnPressed = false;
    private bool isRightBtnPressed = false;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
      switch (vb.VirtualButtonName)
        {
            case "LeftBtn":
                isLeftBtnPressed = true;
                break;
            case "RightBtn":
                isRightBtnPressed = true;
                break;
            case "GrabBtn":
                anim.SetTrigger("startGrab");
                Debug.Log("BtnGrabPressed");
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "LeftBtn":
                isLeftBtnPressed = false;
                break;
            case "RightBtn":
                isRightBtnPressed = false;
                break;
            case "GrabBtn":
                Debug.Log("BtnGrabReleased");
                break;
        }
    }

    // Use this for initialization
    void Start () {
        btnLeft = GameObject.Find("LeftBtn");
        btnRight = GameObject.Find("RightBtn");
        btnGrab = GameObject.Find("GrabBtn");
        cube = GameObject.Find("Cube");
        hook = GameObject.Find("Hook");

        anim = hook.GetComponent<Animator>();

        btnLeft.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        btnRight.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        btnGrab.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
        if (isLeftBtnPressed)
        {
            cube.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (isRightBtnPressed)
        {
            cube.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
