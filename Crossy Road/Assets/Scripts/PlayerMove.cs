using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private CharacterController _controller;

    [SerializeField]
    private float _movespeed = 5f;
    [SerializeField]
    private float _gravity = 9f;
    [SerializeField]
    private float _jumpSpeed = 3f;

    private float _directionY;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if(Input.GetButtonDown("jump"))
        {
            _directionY = _jumpSpeed;
        }

        direction.y -= _gravity;
        direction.y = _directionY;

        _controller.Move(direction *_movespeed * Time.deltaTime);
    }
}
