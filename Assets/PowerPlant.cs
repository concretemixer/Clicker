﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlant : Building {

	// Use this for initialization
	void Start () {
        city = GameObject.Find("CityRoot").GetComponent<City>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClick()
    {
        city.energy += 1;
    }
}
