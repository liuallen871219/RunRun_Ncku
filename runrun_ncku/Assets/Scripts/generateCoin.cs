﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("generate", 2, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void generate()
    {
        Instantiate(coin).transform.position = new Vector3(10, Mathf.Round(Random.Range(-1, 1.5f)) * 1.7f + (-2.60f), 0);
        //Debug.Log(Mathf.Round(Random.Range(-1, 1)));
    }
    public GameObject coin;
    public float time;
}
