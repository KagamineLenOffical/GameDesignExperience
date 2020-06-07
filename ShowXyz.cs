using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ShowXyz
{
    static Vector3 Opoint = new Vector3(0, 0, 0);
    public static bool _show = true;
    public static float len = 10;
    public static float r=0.2f;
    public static Vector3 _size=new Vector3(0.2f,0.2f,0.2f);
    [DrawGizmo(GizmoType.Pickable|GizmoType.NotInSelectionHierarchy|GizmoType.Selected)]
    public static void _OnDrawGizmos(GameObject target,GizmoType type)
    {
        if (_show)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(Opoint, Vector3.right * len);
            Gizmos.DrawCube(Vector3.right * len, _size);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(Opoint, Vector3.up * len);
            Gizmos.DrawCube(Vector3.up * len, _size);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(Opoint, Vector3.forward * len);
            Gizmos.DrawCube(Vector3.forward * len, _size);
            Gizmos.color = Color.black;
            Gizmos.DrawSphere(Opoint, r);
        }
    }
}
