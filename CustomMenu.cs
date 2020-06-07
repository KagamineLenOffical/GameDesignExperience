using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class CustomMenu
{
    [MenuItem("CustomMenu/showOriginPoint")]
    public static void showOriginPoint()
    {
        bool flag = Menu.GetChecked("CustomMenu/showOriginPoint");
        ShowXyz._show = !flag;
        Menu.SetChecked("CustomMenu/showOriginPoint", !flag);
    }
    [MenuItem("CustomMenu/showOriginPoint",true)]
    public static bool Check()
    {
        Menu.SetChecked("CustomMenu/showOriginPoint", ShowXyz._show);
        return true;
    }
}
