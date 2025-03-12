using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{
    int b = 0;
    void Start()
    {
        aaa();
        aaa();
        aaa();
        aaa();
        aaa();
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void aaa()
    {
        ++b;
    }
}
