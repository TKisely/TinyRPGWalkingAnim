using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movingSpeed = 5.0f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;

    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        _animator.SetFloat("Horizontal",movement.x);
        _animator.SetFloat("Vertical",movement.y);
        _animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //Movement
        _rigidbody2D.MovePosition(_rigidbody2D.position+Time.fixedDeltaTime*_movingSpeed*movement);
        throw new NotImplementedException();
    }
}
