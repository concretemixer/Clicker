using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    [SerializeField]
    float consumption = 0;

    protected City city = null;

	// Use this for initialization
	void Start () {
        city = GameObject.Find("CityRoot").GetComponent<City>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnClick()
    {
        Debug.Log("Click");
    }

    virtual protected float GetPowerConsumption()
    {
        return 0;
    }

    virtual protected float GetMaintainanceCost()
    {
        return 0;
    }

}
