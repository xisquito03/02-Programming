using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int playerAge = 33;
    public string playerName = "Scorpi";
    private float playerSpeed = 3.125f;
    [SerializeField] private bool isGameOver = false;

    public string message = "Hola mundo.";
    public int points = 256;

    public bool isRaining;

    public Vector3 initialPos = new Vector3(1, 1, 1);


    private void Start()
    {
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");
        Debug.Log(string.Format("Tengo {0} puntos", points));
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));
        Debug.Log("Tengo " + points + " puntos");
        result = x + y;
        Debug.Log(result);
        if(isRaining == true)
        {
            Debug.Log("Recuerda coger paraguas para no mojarte");
        }
        transform.position = initialPos;

    }

    public float x = 2;
    public float y = 3;
    private float result;
    
    

}
