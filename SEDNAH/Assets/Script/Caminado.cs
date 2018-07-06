using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminado : MonoBehaviour {


    private float X;
    private float Z;
    
    private float Speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");
        

        transform.Translate(X*Speed, 0, Z*Speed);
        
	}
}
