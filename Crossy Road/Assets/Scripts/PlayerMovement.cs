using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController _controller;

    [SerializeField]
    private float _moveSpeed = 12f;
    [SerializeField]
    private float _gravity = 9f;
    [SerializeField]
    private float _jumpSpeed = 3f;

    private float _directionY;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if(_controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _directionY = _jumpSpeed;
            }
        }

        

        _directionY -= _gravity * Time.deltaTime;

        direction.y = _directionY; 

        _controller.Move(direction *_moveSpeed * Time.deltaTime);

    }
}
