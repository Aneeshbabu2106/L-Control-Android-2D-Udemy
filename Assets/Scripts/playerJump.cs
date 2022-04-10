using UnityEngine;

public class playerJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    public void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));
    }
}

