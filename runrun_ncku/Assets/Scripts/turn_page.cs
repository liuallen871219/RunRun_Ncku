using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_page : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fixed_time = fixed_time - Time.deltaTime;
        if (fixed_time <= 0)
        {
            seconds = seconds + 1;
            Debug.Log(seconds);
            fixed_time = 1.0f;
        }
        if (seconds == 5)
        {
            scene = "tree_intro_2";
            Initiate.Fade(scene, loadToColor, 0.8f);
        }
        if (seconds == 10)
        {
            scene = "main_game";
            Initiate.Fade(scene, loadToColor, 0.8f);
        }
    }
    static public float seconds = 0.0f, fixed_time = 1.0f;
    public string scene;
    public Color loadToColor = Color.white;
}
