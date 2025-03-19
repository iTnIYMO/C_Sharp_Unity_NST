using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{        
    void Start()
    {
        int b = aaa();
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
    }

    int aaa()
    {
        return 1;
        Debug.Log("aaa");
    }
}
