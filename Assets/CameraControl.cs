using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        root = GameObject.Find("CityRoot");
    }

    private GameObject root;
    float leftBoundary = -128.9f;
    float rightBoundary = 204.81f;

    float speed = 10;
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
            if (transform.position.x < leftBoundary)
                transform.position = transform.position + Vector3.right * (rightBoundary - leftBoundary);

            foreach (var s in GetComponentsInChildren<Skyline>())
            {
                s.Move(-Time.deltaTime * speed);
            }
            foreach (var s in root.GetComponentsInChildren<BgParallax>())
            {
                s.Move(-Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) || true)
        {
            transform.position = transform.position + Vector3.right * Time.deltaTime * speed;
            if (transform.position.x > rightBoundary)
                transform.position = transform.position + Vector3.left * (rightBoundary - leftBoundary);

            foreach (var s in GetComponentsInChildren<Skyline>())
            {
                s.Move(Time.deltaTime* speed);
            }

            foreach (var s in root.GetComponentsInChildren<BgParallax>())
            {
                s.Move(Time.deltaTime * speed);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                //Vector3 touchBall = ray.origin + ray.direction * hit.distance;
                //target.transform.position = touchGround;  
                Building building = hit.collider.gameObject.GetComponent<Building>();
                if (building != null)
                    building.OnClick();
                else
                {
                    building = hit.collider.gameObject.GetComponentInParent<Building>();
                    if (building != null)
                        building.OnClick();
                }
            }
        }

    }
}
