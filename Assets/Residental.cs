using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residental : Building  {

    [SerializeField]
    int capacity = 100;

    [SerializeField]
    int inhabitants = 10;

    public int Inhabitants
    {
        get
        {
            return inhabitants;
        }     
    }

    // Use this for initialization
    void Start () {
        city = GameObject.Find("CityRoot").GetComponent<City>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick()
    {
        inhabitants++;
        if (inhabitants > capacity)
            inhabitants = capacity;

        city.OnPopulationGrow();
    }
}
