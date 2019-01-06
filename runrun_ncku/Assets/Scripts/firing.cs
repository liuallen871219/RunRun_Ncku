using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firing : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        InvokeRepeating("generate_fire", 10, 0.5f);
        Invoke("gameover",30);
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            sound.Play();
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {
                
                Debug.Log(hit.collider.name);
                Destroy(hit.collider.gameObject);
                fire_num--;
            }
        }
    }
    void generate_fire()
    {
        if (start)
        {
            Instantiate(fire).transform.position = new Vector3(Random.Range(-1f,4.2f),Random.Range(-1.6f,0.7f),0);
            fire_num++;
        }
    }
    void gameover()
    {
        start = false;
        if (fire_num > 5)
        {
            result = "搶救失敗";
            text.text = result;
        }
        else
        {
            result = "搶救成功 分數+2000";
            text.text = result;
            Player_Control.score += 2000;
        }
        Invoke("backToMainGame", 5);
    }
    void backToMainGame()
    {
        Initiate.Fade(scene, loadToColor, 0.8f);
    }
    public int  fire_num=0;
    public bool start = true;
    public GameObject fire;
    public string result;
    public Text text;
    public AudioSource sound;
    public string scene="main_game";
    public Color loadToColor = Color.black;

}
