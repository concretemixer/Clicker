using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour {

    [SerializeField] Text text;

    public int population = 0;
    public float money = 1000;
    public float energy = 100;
    public float supples = 0;

    public bool isDay = true;
    public int time;

    // Use this for initialization
    void Start () {
        OnPopulationGrow();		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = string.Format("${0:F2} PP:{1} E:{2:F2} S:{3:F2} | {5} {4}", money, population, energy, supples, isDay?"Day":"Night", time);
	}

    public void OnPopulationGrow()
    {
        population = 0;
        foreach (var residental in GetComponentsInChildren<Residental>())
        {
            population += residental.Inhabitants;
        }
    }
}
