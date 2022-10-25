using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public float x = 2.0f;
    public float y = 0.5f;
    private bool isGreater;
    private void Start()
    {
        isGreater = x > y;
        Debug.Log(isGreater); 
    }
}
