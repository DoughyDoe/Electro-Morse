using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOff : MonoBehaviour {

    public float exitTime = 7.75f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("TurnOff", exitTime);
	}

    void TurnOff()
    {
        gameObject.SetActive(false);
    }
}
