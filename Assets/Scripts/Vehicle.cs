using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
  [SerializeField] private int wheels = 4;
    [SerializeField] private string name;





    private void Start()
    {
        Debug.Log(string.Format("Este {0} tiene {1} ruedas", name, wheels));
    }

}