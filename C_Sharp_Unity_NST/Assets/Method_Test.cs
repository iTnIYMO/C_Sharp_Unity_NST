using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{        
    void Start()
    {
        aaa(1,2,3);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void aaa(int a, int b, int c)
    {
        Debug.Log(a + b + c);
    }
}
