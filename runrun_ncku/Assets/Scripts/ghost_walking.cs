using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_walking : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.GetChild(1).Rotate(0, 180, 0);
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * new Vector3(1, 0, 0) * Time.deltaTime;
        if(transform.position.x < -7 || transform.position.x > 7)
        {
            speed *= -1;
            transform.GetChild(1).Rotate(0, 180, 0);
        }
    }
/*    void OnCollisionEnter2D(Collision2D c)
    {
        //Debug.Log(c.transform.name);
        if (c.collider.name == "collider1" || c.collider.name == "collider2")
        {
            speed *= -1;
            transform.Rotate(0, 180, 0);
        }
    }*/

    int speed = -1;
}