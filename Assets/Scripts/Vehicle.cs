using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int wheels = 4;
    [SerializeField] private string name;
    [SerializeField] private bool isOn;
    [SerializeField] string sound;
    [SerializeField] float gasoline;
    public bool canGetBigger;
    



    private void Start()
    {
        Debug.Log(string.Format("Este {0} tiene {1} ruedas", name, wheels));
        if (isOn == true) ;
        {
            Debug.Log(string.Format("Este {0} se mueve y hace {1}", name, sound));
        }


        if (gasoline <= 10 && isOn == true)
        {
            Debug.Log($"A {name} le queda muy poca gasoline");
        }
        else if (isOn == true && gasoline > 10)
        {
            Debug.Log($"{name} tiene suficiente gasolina");
        }
        else
        {
            Debug.Log($"{name} no tiene coche disponible");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += Vector3.one;
        }
    }
}
