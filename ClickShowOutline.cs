using UnityEngine;
using UnityEngine.EventSystems;
using cakeslice;
public class ClickShowOutline : MonoBehaviour
{
    void Start()
    {
        Click3D.click3DEvent.AddListener(delegate (GameObject gameObject, PointerEventData arg1) {
            Outline[] o = FindObjectsOfType<Outline>();
            foreach (Outline oL in o)
            {
                
                oL.enabled = false;
                if (gameObject.GetInstanceID() == oL.gameObject.GetInstanceID())
                {
                    print(oL.gameObject.name);
                    oL.enabled = (oL.enabled == false);
                }
            }
        });
        Outline[] outlines = FindObjectsOfType<Outline>();
        foreach (Outline outline in outlines)
        {
            outline.enabled = false;
        }

    }
}
