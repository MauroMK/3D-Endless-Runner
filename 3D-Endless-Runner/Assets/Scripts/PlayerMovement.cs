using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Rigidbody playerRb;

    private void Start() 
    {
        playerRb = GetComponent<Rigidbody>();    
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
