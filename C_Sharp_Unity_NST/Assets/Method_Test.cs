using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{        
    void Start()
    {
        int d = aaa(1,2,3);
        Debug.Log(d);
    }

    // Update is called once per frame
    void Update()
    {
    }

    int aaa(int a, int b, int c)
    {
        return a + b + c;
    }
}
