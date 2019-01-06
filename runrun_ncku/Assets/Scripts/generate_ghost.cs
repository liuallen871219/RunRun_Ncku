using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generate_ghost : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("generate", 5, time);
        Invoke("gameover", 30);
    }
	
	// Update is called once per frame
	void Update () {
        if (state)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("fuck");
                foreach (GameObject x in list)
                {
                    if (x.transform.name == "ghost_up(Clone)")
                    {
                        list.Remove(x);
                        Destroy(x);
                        score += 100;
                        break;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("fuck");
                foreach (GameObject x in list)
                {
                    if (x.transform.name == "ghost_left(Clone)")
                    {
                        list.Remove(x);
                        Destroy(x);
                        score += 100;
                        break;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("fuck");
                foreach (GameObject x in list)
                {
                    if (x.transform.name == "ghost_down(Clone)")
                    {
                        list.Remove(x);
                        Destroy(x);
                        score += 100;
                        break;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("fuck");
                foreach (GameObject x in list)
                {
                    if (x.transform.name == "ghost_right(Clone)")
                    {
                        list.Remove(x);
                        Destroy(x);
                        score += 100;
                        break;
                    }
                }
            }
        }
    }
    void generate()
    {
        if (state)
        {
            switch (Random.Range(0, 4))
            {
                case 1:
                    temp = Instantiate(up);
                    temp.transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-1.6f, 1.6f), 0);
                    list.Add(temp);
                    break;
                case 2:
                    temp = Instantiate(left);
                    temp.transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-1.6f, 1.6f), 0);
                    list.Add(temp);
                    break;
                case 3:
                    temp = Instantiate(down);
                    temp.transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-1.6f, 1.6f), 0);
                    list.Add(temp);
                    break;
                case 4:
                    temp = Instantiate(right);
                    temp.transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-1.6f, 1.6f), 0);
                    list.Add(temp);
                    break;
                default:
                    break;
            }
        }
    }
    void gameover()
    {
        Debug.Log("haha");
        state = false;
        text.text = "遊戲結束 獲得" + score.ToString() + "分";
        Invoke("backToMainGame", 5);
    }
    void backToMainGame()
    {
        Player_Control.score += score;
        Initiate.Fade(scene, loadToColor, 0.8f);
    }
    public GameObject  up, down, right, left ,temp;
    public float time;
    public int score=0;
    public string scene = "main_game";
    public Color loadToColor = Color.black;
    public bool state=true;
    public Text text;
    List<GameObject> list = new List<GameObject>(); 
}
