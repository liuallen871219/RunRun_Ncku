using UnityEngine;
using System.Collections;

public class water : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }
    public Texture2D texture;
    // Use this for initialization
    void OnGUI()
    {
        Rect rect = new Rect(Input.mousePosition.x - (texture.width / 2),

        Screen.height - Input.mousePosition.y - (texture.height / 2),

        texture.width, texture.height);

        GUI.DrawTexture(rect, texture);
    }
}