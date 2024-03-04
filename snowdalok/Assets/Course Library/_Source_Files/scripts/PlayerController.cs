using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // This is where we get the player
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
       
        transform.Translate(Vector3.down * Time.deltaTime * speed * forwardInput);
        // Rotate using back
        transform.Rotate(Vector3.back, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
