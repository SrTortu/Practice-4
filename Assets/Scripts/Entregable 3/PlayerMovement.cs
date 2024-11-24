using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Atributtes
    //Public
    public float playerSpeed = 30f;
    public float rotationSpeed = 10f;
    public float playerJumpForce = 5f;
    public Transform playerCamera;

    //Private
    private bool isGrounded;
    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        isGrounded = false;
        
    }
    private void Update()
    {
        //Player movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);

        //Player jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("entre");
            playerRigidbody.AddForce(Vector3.up  * playerJumpForce, ForceMode.Impulse);
            isGrounded = false;
        } 

        //Player rotation
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            isGrounded = true;
    }

}
