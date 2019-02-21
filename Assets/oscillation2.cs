using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillation2 : MonoBehaviour
{
    Vector3 newpos = new Vector3(100f, 1000f, 1110f);
    Vector3 trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = trans + newpos;
        print(Time.timeScale);

    }
}
