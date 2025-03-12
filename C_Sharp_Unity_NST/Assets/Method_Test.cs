using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        aaa();
        aaa();
        aaa();
    }

    // Update is called once per frame
    void Update()
    {
        aaa();
    }

    void aaa()
    {
        Debug.Log("aaa");
    }
}
