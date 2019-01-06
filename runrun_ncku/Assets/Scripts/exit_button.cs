using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class exit_button : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData e)
    {
        Application.Quit();
    }
}
