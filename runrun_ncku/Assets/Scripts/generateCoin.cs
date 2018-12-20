using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("generate", 5, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void generate()
    {
        Instantiate(coin).transform.position = new Vector3(5, Random.Range(-1, 1) * 0.5f + (-4.28f), 0);
    }
    public GameObject coin;
}
