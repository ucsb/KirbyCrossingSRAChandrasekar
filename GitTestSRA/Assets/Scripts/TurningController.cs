using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningController : MonoBehaviour
{
    // Private Variables
    private float turnSpeed;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 45.0f;
        horizontalInput = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        if (Input.GetKey(KeyCode.Comma)) {
            transform.Rotate(Vector3.up, turnSpeed * -horizontalInput * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Period)) {
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}