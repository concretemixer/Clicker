using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaytimeControl : MonoBehaviour {

    GameObject sky;
    GameObject sun;
    City city;

    // Use this for initialization
    void Start () {
        sky = GameObject.Find("SkyDome");
        sun = GameObject.Find("Sun");
        city = GameObject.Find("CityRoot").GetComponent<City>();
    }

    float time = 12;
    float speed = 0.2f;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow) || true)
            time += Time.deltaTime * speed;
            
        if (Input.GetKey(KeyCode.DownArrow))
            time -= Time.deltaTime * speed;

        time = (time+24.0f) % 24.0f;

        //Debug.Log("time = " + time);
        UpdateLight();


        city.isDay = (time > 6) && (time < 21);
        city.time = (int)time;
    }

    void UpdateLight()
    {
        sky.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2((time+9.0f)/24.0f,0));
        sun.GetComponent<Light>().intensity = 0.1f + Mathf.Clamp(0.4f+Mathf.Cos(Mathf.PI*0.75f + Mathf.PI * 2 * (time / 24.0f)),0,0.9f);

    }


}
