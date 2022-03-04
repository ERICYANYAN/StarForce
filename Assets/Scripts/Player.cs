using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speeed = 8;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private float _x;
    private float _y;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _x = Input.GetAxis("Horizontal");
        _y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(_x, _y, 0);
        _rigidbody.transform.position += movement * (speeed * Time.deltaTime);

        float absX = Math.Abs(_x);

        if (absX < 0.0001f)
        {
            _animator.SetBool("isRun",false);
            return;
        }
        if (_x >0 )
        {
            _rigidbody.transform.eulerAngles = new Vector3(0, 0, 0);
            _animator.SetBool("isRun",true);
        }
        else 
        {
            _rigidbody.transform.eulerAngles = new Vector3(0, 180, 0);
            _animator.SetBool("isRun",true);
        }


    }
}