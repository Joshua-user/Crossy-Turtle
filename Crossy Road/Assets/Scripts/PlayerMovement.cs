using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController _controller;

    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _gravity = 5f;

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

        direction.y -= _gravity;

        _controller.Move(direction *_moveSpeed * Time.deltaTime);

    }
}
