using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sudden_to_small_game : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if (gamemode == 1)
            scene = "tree";
        else
            scene = "ghost";
        Invoke("GoToSmallGame", 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void GoToSmallGame()
    {
        Initiate.Fade(scene, loadToColor, 0.8f);
    }

    public string scene;
    static public int gamemode;
    public Color loadToColor = Color.black;
}
