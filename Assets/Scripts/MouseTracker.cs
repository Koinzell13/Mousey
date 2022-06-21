using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    Vector3 lastMousePos;
    public float mouseCursorSpeed;


    public Vector3 mouseDelta
    {
        get
        {
            return Input.mousePosition - lastMousePos;
        }
    }
    void Start()
    {
        // Get initial mouse position value
        lastMousePos = Input.mousePosition;
    }
    void Update()
    {
        // Use mouseDelta as needed, then update lastMousePos at

        lastMousePos = Input.mousePosition;
        mouseCursorSpeed = Input.GetAxis("Mouse X") / Time.deltaTime;
    }
}
