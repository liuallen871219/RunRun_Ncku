using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(how_button.how_click == true)
        {
            turn_page.fixed_time = 10000f;
            turn_page.seconds = 18f;
        }
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            turn_page.fixed_time = 1f;
            turn_page.seconds = 18f;
            SceneManager.LoadScene(3);
        }
	}
}
