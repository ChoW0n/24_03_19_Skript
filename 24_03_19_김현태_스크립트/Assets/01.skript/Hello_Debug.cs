using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello_Debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Debug.Log("Hello World")
        Debug.Log("Hello World");
        Debug.LogWarning("Warning");
        Debug.LogError("Error");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
