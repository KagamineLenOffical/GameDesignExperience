using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPMP : MonoBehaviour
{
    static int hp = 100;
    static int mp = 100;
    public Image HP;
    public Image MP;
    public void HPAddButtonClick()
    {
        if (hp < 100)
        {
            hp++;
        }
        HP.fillAmount = hp / 100.0f;
        print("hp++");
    }
    public void HPSubButtonClick()
    {
        if (hp > 0)
        {
            hp--;
        }
        HP.fillAmount = hp / 100.0f;
        print("hp--");
    }
    public void MPAddButtonClick()
    {
        if (mp < 100)
        {
            mp++;
        }
        MP.fillAmount = mp / 100.0f;
        print("mp++");
    }
    public void MPSubButtonClick()
    {
        if (mp > 0)
        {
            mp--;
        }
        MP.fillAmount = mp / 100.0f;
        print("mp--");
    }
}
