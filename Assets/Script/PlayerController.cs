using UnityEngine;
public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    void Update()
    {
        // --- Move Left/Right ---
        float inputX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputX * moveSpeed, rb.velocity.y);

        // --- Jump (NO GROUND CHECK) ---
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}