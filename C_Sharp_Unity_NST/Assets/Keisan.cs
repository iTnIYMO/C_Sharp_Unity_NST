using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keisan : MonoBehaviour
{
    //int a = 10;
    //int b = 5;
    int a = 0;
    int b = 10;

    void Start()
    {
        /*
        a += b;
        Debug.Log("a += b �� a =" + a);
        a -= b;
        Debug.Log("a -= b �� a =" + a);
        a *= b;
        Debug.Log("a *= b �� a =" + a);
        a /= b;
        Debug.Log("a /= b �� a =" + a);
        a %= b;
        Debug.Log("a %= b �� a =" + a);
        */
    }
    private void Update()
    {
        a++;
        b--;
        Debug.Log("a++ �� " + a);
        Debug.Log("b++ �� " + b);
    }
}
