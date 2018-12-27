using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
   
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {  
            if (transform.position.y <= -4.2f)
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
            score_text.text =  score.ToString() ;
            Debug.Log(score);
            Destroy(c.transform.parent.gameObject);
        }
        if(c.transform.name =="image")
        {
            currentHealth = currentHealth - 5;
            Debug.Log(currentHealth);
            Hurt.sizeDelta = new Vector2(currentHealth, Hurt.sizeDelta.y);

        }
        
    }
    
    int score=0;
    public const int maxHealth = 200;
    public int currentHealth = maxHealth;

    //血量條

    public RectTransform HealthBar, Hurt;
    public Text score_text;
    
   
}
