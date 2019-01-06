using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
        source = gameObject.GetComponent<AudioSource>();
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
        fixed_time = fixed_time - Time.deltaTime;
        if (fixed_time <= 0)
        {
            seconds = seconds + 1;
            Debug.Log(seconds);
            fixed_time = 1.0f;
        }
        if (seconds == 30)
        {
            sudden_to_small_game.gamemode = 1;
            scene = "tree_intro_1";
            Initiate.Fade(scene, loadToColor, 2.0f);
        }
        if (seconds == 62)
        {
            sudden_to_small_game.gamemode = 2;
            scene = "taiwanese_intro_1";
            Initiate.Fade(scene, loadToColor, 2.0f);
        }
        if (seconds == 94)
        {
            //scene = "taiwanese_intro_1";
            //Initiate.Fade(scene, loadToColor, 2.0f);
        }
        //Debug.Log(transform.position.y);
        score_text.text = score.ToString();
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
            source.clip = music_1;
            source.Play();

        }
        if(c.transform.name =="image")
        {
            if (!wudi_state)
            {
                currentHealth = currentHealth - 5;
                Destroy(c.transform.parent.gameObject);
                Debug.Log(currentHealth);
                Hurt.sizeDelta = new Vector2(currentHealth, Hurt.sizeDelta.y);
            }

        }
        if (c.transform.name == "tool")
        {
            Destroy(c.transform.parent.gameObject);
            Debug.Log("tool");
            wudi_source.Play();
            wudi_state = true;
            Invoke("wudi_to_normal", 5);

        }
    }
    void wudi_to_normal()
    {
        wudi_state = false;
    }
    static public int score=0;
    public const int maxHealth = 200;
    public int currentHealth = maxHealth;
    static public float seconds = 0.0f, fixed_time = 1.0f;
    //血量條

    public RectTransform HealthBar, Hurt;
    public Text score_text;
    public AudioClip music_1;
    public AudioClip music_2;
    public AudioClip wudi;
    public AudioSource source ,wudi_source;
    public string scene;
    public Color loadToColor = Color.white;
    public bool wudi_state = false;

}
