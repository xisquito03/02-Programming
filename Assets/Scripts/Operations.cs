using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 7f;
    public float y = 4f;


    private void Start()
    {
        Debug.Log(string.Format("Sum: {1}+{2}={0}", x+y, x, y));
        Debug.Log(string.Format("Substraction: {0}-{1}={2}", x, y, x-y));
        Debug.Log(string.Format("Product: {0}*{1}={2}", x, y, x*y));
        Debug.Log(string.Format("Division: {0}/{1}={2}", x, y, x/y));
        Debug.Log(string.Format("Module: {0}%{1}={2}", x, y, x%y));

     
    }
}
