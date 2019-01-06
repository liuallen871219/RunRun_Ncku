using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateTool : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("generate", 10, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void generate()
    {
        Instantiate(tool).transform.position = new Vector3(10, Mathf.Round(Random.Range(-1, 1.5f)) * 1.7f + (-5.25f), 0);
        //Debug.Log(Mathf.Round(Random.Range(-1, 1)));
    }
    public GameObject tool;
    public float time;
}
