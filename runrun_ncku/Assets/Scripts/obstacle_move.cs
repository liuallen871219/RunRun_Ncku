using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_move : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("coinMove", 0.01f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public float move_speed = -0.02f;
    void coinMove()
    {
        transform.position = transform.position + new Vector3(move_speed, 0, 0);
        if (transform.position.x < -10.0f)
        {
            Destroy(transform.gameObject);

        }
    }
}
