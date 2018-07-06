using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public GameObject obj;
    private float RX;
    private float RY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RX = Input.GetAxis("Mouse X");
        RY = Input.GetAxis("Mouse Y");

        this.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
        transform.Rotate(-RY, RX, 0);
    }
}
