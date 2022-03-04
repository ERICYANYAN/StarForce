using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBetterJump : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private bool _jumpRequest;

    public float UpGravity = 2f;
    public float DownGravity = 3f;
    public float DeafultGravity = 1f;
    


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

 

    private void FixedUpdate()
    {
        if (_rigidbody.velocity.y<0)
        {
            _rigidbody.gravityScale = DownGravity;
        }else if (_rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            _rigidbody.gravityScale = UpGravity;
        }
        else
        {
            _rigidbody.gravityScale = DeafultGravity;
        }
    }
}