using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{        
    void Start()
    {
        int b = 0;
        b = aaa(b);
        b = aaa(b);
        b = aaa(b);
        b = aaa(b);
        b = aaa(b);
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
    }

    int aaa(int b)
    {
        return ++b;
    }
}
