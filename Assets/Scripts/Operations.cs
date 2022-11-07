using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{


    private void Calculator(float x, float y)
    {
        Debug.Log(string.Format("Sum: {1}+{2}={0}", x + y, x, y));
        Debug.Log(string.Format("Substraction: {0}-{1}={2}", x, y, x - y));
        Debug.Log(string.Format("Product: {0}*{1}={2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0}/{1}={2}", x, y, x / y));
    }

   
    

    private void Start()
    {
        Calculator(7, 4);
        /* Debug.Log(string.Format("Sum: {1}+{2}={0}", x + y, x, y));
        Debug.Log(string.Format("Substraction: {0}-{1}={2}", x, y, x - y));
        Debug.Log(string.Format("Product: {0}*{1}={2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0}/{1}={2}", x, y, x / y));
        */
    }
}
