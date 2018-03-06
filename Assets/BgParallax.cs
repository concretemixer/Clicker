using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgParallax : MonoBehaviour {

    [SerializeField]
    private float parallaxK = 1;


    Vector3 initialPos;
	// Use this for initialization
	void Start () {
        initialPos = transform.position;
	}

    bool visible = false;
	// Update is called once per frame
	void Update () {
        visible = false;
        foreach (var r in GetComponentsInChildren<Renderer>())
            if (r.isVisible)
            {
                visible = true;
                break;
            }

	}

    public void Move(float amount)
    {
        if (visible)
            transform.position = transform.position + Vector3.right * amount * parallaxK;
        else
            transform.position = initialPos;
    }
}
