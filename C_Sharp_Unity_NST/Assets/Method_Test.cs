using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{        
    int b = 0;
    void Start()
    {
        aaa(b);
        aaa(b);
        aaa(b);
        aaa(b);
        aaa(b);
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void aaa(int b)
    {
        ++b;
    }
}
