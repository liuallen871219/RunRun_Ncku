using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class healthBar : MonoBehaviour
{

    //血量設定

    public const int maxHealth = 100;

    public int currentHealth = maxHealth;

    //血量條

    public RectTransform HealthBar, Hurt;

    void Update()

    {

        //按下H鈕扣血

        if (Input.GetKeyDown(KeyCode.H))

        {

            //接受傷害

            currentHealth = currentHealth - 10;

        }

        //將綠色血條同步到當前血量長度

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);

        //呈現傷害量

        if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            Hurt.sizeDelta += new Vector2(-1, 0) * Time.deltaTime * 10;

        }

    }

}