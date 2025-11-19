

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovemet : MonoBehaviour
{
    // FEATIRE LIST
    // 1.use arrow key for movement
    // 2. need a variable for speed
    // 3.we need to store the direction of our character
    // 4.need a variable for running
    // 5.special movement example: rolling or dashing
    // 6.mantling
    // 7.if we can climb or not

    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveinput;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveinput * moveSpeed;
    }
    
    public void Move(InputAction.CallBackContext context)
    {
        animator.SetBool("isWalking", true);
        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", moveinput.x);
            animator.SetFloat("LastInputY", moveinput.y);

        }
        moveInput = context.ReadValue<Vector2>();

        animator.SetFloat("InputX", moveinput.x);
        animator.SetFloat("InputY", moveinput.y);

    }
}
