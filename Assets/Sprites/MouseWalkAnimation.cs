using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWalkAnimation : MonoBehaviour
{
    private Animator animator;
    public float speed = 5f; // Adjust the speed as needed

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButton(0))
        {
            WalkLeft();
        }
        // Check if the right mouse button is pressed
        else if (Input.GetMouseButton(1))
        {
            WalkRight();
        }
        // No mouse button pressed, stop walking animation
        else
        {
            StopWalking();
        }
    }

    void WalkLeft()
    {
        // Play the WalkLeft animation
        animator.Play("WalkLeft");

        // Move the character to the left
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        transform.localScale = new Vector3(-1, 1, 1);
    }

    void WalkRight()
    {
        // Play the WalkRight animation
        animator.Play("WalkRight");

        // Move the character to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        transform.localScale = new Vector3(1, 1, 1);
    }

    void StopWalking()
    {
        // Stop the walking animation
        animator.Play("iDLE");
    }
}