using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 3f;
    private float jumpForce = 8f;
    private Rigidbody playerRb;

    private void Start() 
    {
        playerRb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
