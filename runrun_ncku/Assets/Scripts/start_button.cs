using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour, IPointerClickHandler
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
        Initiate.Fade(scene, loadToColor, 0.8f);
        Debug.Log("Load main game");
    }

    public string scene = "main_game";
    public Color loadToColor = Color.white;
}
