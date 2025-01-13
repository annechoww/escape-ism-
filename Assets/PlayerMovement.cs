using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    // Globals
    private Rigidbody2D playerRb;
    public float playerSpeed = 5f;
    private float moveX, moveY;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        // Update Animator parameters
        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);
        animator.SetBool("IsMoving", moveX != 0 || moveY != 0);

    }

    void FixedUpdate()
    {
        playerRb.linearVelocity = new Vector2(moveX, moveY) * playerSpeed;
    }
}
