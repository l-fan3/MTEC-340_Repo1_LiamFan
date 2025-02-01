using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlFlow : MonoBehaviour
{
    public bool flag = false;
    public int powerValue = 10;
    public int baseValue = 2;
        
    void Start()
    {
        //Flag Boolean
        if (flag is true)
        {
            Debug.Log("Boolean flag is set");
        }

        else
        {
            Debug.Log("Boolean flag isn't set");
        }
        
        //Expo Loop 
        for (int i = 1; i <= powerValue; i++)
        {
            Debug.Log($"The {i} power of {baseValue} is {Math.Pow(baseValue, i)}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
