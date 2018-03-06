using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyline : MonoBehaviour {

    [SerializeField]
    float rotateK = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(float amount)
    {
        transform.Rotate(Vector3.down, amount * rotateK);
    }
}
