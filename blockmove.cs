using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmove : MonoBehaviour
{

    // Update is called once per frame
    int num = 1;
    void Update()
    {
        if (transform.position.x > 25)
        {
            num = -1;
        }
        if (transform.position.x < 20)
        {
            num = 1;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * num);
    }
}
