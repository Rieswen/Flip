using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FlipShit : MonoBehaviour
{
    private bool FacingRight = true;
    private float moveInput;

    void Start()
    {
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        transform.localScale = Scaler;
        Scaler.x *= -1;
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }


    void Update()
    {
        if (moveInput > 0)
        {
            Flip();
        }
        else if (moveInput < 0)
        {
            Flip();
        }
    }
}