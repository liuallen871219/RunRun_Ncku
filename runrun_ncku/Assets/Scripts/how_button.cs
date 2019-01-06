using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class how_button : MonoBehaviour, IPointerClickHandler
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerClick(PointerEventData e)
    {
        //SceneManager.LoadScene(1);
        how_click = true;
        Initiate.Fade(scene, loadToColor, 0.8f);
        Debug.Log("Load how to play game");
    }

    public string scene = "begin_intro_2";
    static public bool how_click = false; 
    public Color loadToColor = Color.white;
}
