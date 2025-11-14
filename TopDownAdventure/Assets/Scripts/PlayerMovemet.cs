

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveinput * moveSpeed;
    }
    
    public void Move(InputAction.CallBackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
