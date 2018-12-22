using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {  
            if (transform.position.y <= -2.5f)
                transform.position = transform.position + new Vector3(0, 1.7f, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (transform.position.y >= -5.9f)
                transform.position = transform.position + new Vector3(0, -1.7f, 0);
        }
        //Debug.Log(transform.position.y);
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.transform.name);
        if (c.transform.name == "coin_1")
        {
            score += 500;
            Debug.Log(score);
            Destroy(c.transform.parent.gameObject);
        }
        
    }
    int score=0;
}
