using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnScript : MonoBehaviour, IVirtualButtonEventHandler{
    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject cube;

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
        }
    }

    // Use this for initialization
    void Start () {
        btnLeft = GameObject.Find("LeftBtn");
        btnRight = GameObject.Find("RightBtn");
        cube = GameObject.Find("Cube");

        btnLeft.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        btnRight.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
        if (isLeftBtnPressed)
        {
            cube.transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        if (isRightBtnPressed)
        {
            cube.transform.Translate(Vector3.back * 5.0f * Time.deltaTime);
        }
    }
}
