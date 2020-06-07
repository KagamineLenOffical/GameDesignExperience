using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewObject : MonoBehaviour
{
    public GameObject[] perfab = new GameObject[5];
    string objPos="None";
    string objName="None";
    string objSize="None";
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            int a = Random.Range(0, 4);
            int x = Random.Range(0, 10), y = Random.Range(0, 10);

            Instantiate(perfab[a], new Vector2(x,y),Quaternion.identity);
        }
    }

    // Update is called once per frame
    public float timer = 2.0f;
    public float infotimer = 2.0f;
    public int cnt = 0;
    GameObject obj;
    void Update()
    {
        timer -= Time.deltaTime;
        infotimer -= Time.deltaTime;
        if (timer < 0 && cnt < 5)
        {
            cnt++;
            int a = Random.Range(0, 4);
            int x = Random.Range(-10, 10), y = Random.Range(-10, 10);

            obj=Instantiate(perfab[a], new Vector2(x, y), Quaternion.identity);
            int vx = Random.Range(0, 5), vy = Random.Range(0, 5), vz = Random.Range(0, 5);
            obj.GetComponent<Rigidbody>().velocity = new Vector3(vx, vy, vz);
            timer = 2.0f;
        }
        transform.LookAt(obj.transform);
        if (infotimer < 0)
        {
            objPos = "Position:"+obj.transform.position.ToString();
            objName = "Name:"+obj.ToString();
            objSize = "Size:"+obj.transform.localScale.ToString();
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(40, 0, 100, 100), objPos, GUIStyle.none);
        GUI.Label(new Rect(40, 40, 100, 100), objName, GUIStyle.none);
        GUI.Label(new Rect(40, 20, 100, 100), objSize, GUIStyle.none);
    }
}
