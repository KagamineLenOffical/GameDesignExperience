using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformShape : MonoBehaviour
{
    GameObject obj;
    float scalex = 1.0f;
    float scaley = 1.0f;
    float scalez = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Cube");

    }
    private void OnGUI()
    {
        GUILayout.Label("x");
        scalex = GUILayout.HorizontalSlider(scalex, 1.0f, 2.0f, GUILayout.Width(100));

        GUILayout.Label("y");
        scaley = GUILayout.HorizontalSlider(scaley, 1.0f, 2.0f, GUILayout.Width(100));

        GUILayout.Label("z");
        scalez = GUILayout.HorizontalSlider(scalez, 1.0f, 2.0f, GUILayout.Width(100));
        obj.transform.localScale = new Vector3(scalex, scaley, scalez);
    }
}
