using UnityEngine;
using UnityEngine.InputSystem;


public class MovementScript : MonoBehaviour
{
    public float maxSpeed = 4f;
    public float acceleration = 20f;
    public float deceleration = 15f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;


    private Rigidbody2D rb;
    private Vector2 currentVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var kb = Keyboard.current;

        Vector2 moveInput = Vector2.zero;

        if (kb.wKey.isPressed) moveInput.y += 1f;
        if (kb.sKey.isPressed) moveInput.y -= 1f;
        if (kb.dKey.isPressed) moveInput.x += 1f;
        if (kb.aKey.isPressed) moveInput.x -= 1f;

        moveInput = moveInput.normalized;

        Vector2 targetVelocity = moveInput * maxSpeed;

        float rate = (moveInput.magnitude > 0f) ? acceleration : deceleration;

        currentVelocity = Vector2.MoveTowards(currentVelocity, targetVelocity, rate * Time.deltaTime);

        rb.linearVelocity = currentVelocity;
    }
}