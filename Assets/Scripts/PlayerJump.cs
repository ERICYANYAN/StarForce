using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float speeed = 5f;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private bool _jumpRequest;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") )
        {
            _jumpRequest = true;
        }
    }

    private void FixedUpdate()
    {
        if (_jumpRequest)
        {
            _rigidbody.AddForce(Vector2.up*speeed,ForceMode2D.Impulse);
            _jumpRequest = false;
        }
    }
}