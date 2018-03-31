using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public static SpawnManager instance = null;
    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}

    public void GravityOn()
    {
        sp1.GetComponent<Rigidbody>().useGravity = true;
        sp2.GetComponent<Rigidbody>().useGravity = true;
        sp3.GetComponent<Rigidbody>().useGravity = true;
        sp4.GetComponent<Rigidbody>().useGravity = true;
    }

    public void GravityOff()
    {
        sp1.GetComponent<Rigidbody>().useGravity = false;
        sp2.GetComponent<Rigidbody>().useGravity = false;
        sp3.GetComponent<Rigidbody>().useGravity = false;
        sp4.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
