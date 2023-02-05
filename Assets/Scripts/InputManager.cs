using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    private float horizontalInput;
    void Awake()
    {
        Instance = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
    public float getHorizontalInput()
    {
        return -horizontalInput;
    }
}
