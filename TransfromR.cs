using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Reflection;

[CustomEditor(typeof(Transform))]
public class TransformR : Editor
{
    private Editor M_editor;
    private void OnEnable()
    {
        M_editor = Editor.CreateEditor(target, Assembly.GetAssembly(typeof(Editor)).GetType("UnityEditor.TransformInspector", true));
    }
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        GUILayout.Label("Origin Radius");
        ShowXyz.r = EditorGUILayout.Slider(ShowXyz.r, 0, 10);
        ShowXyz.len = (float)EditorGUILayout.DoubleField("Len", ShowXyz.len);
        
        ShowXyz._size = EditorGUILayout.Vector3Field("Size of Cube",ShowXyz._size);

    }
}