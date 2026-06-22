using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 6;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private float playerHalfHeight;

    void Start()
    {
        playerHalfHeight = spriteRenderer.bounds.extents.y;
    }
    // Update is called once per frame
    void Update()
    {      
        if (Input.GetButtonDown("Jump") && GetIsGrounded())
        {
            Jump();
        }
        Debug.DrawRay(transform.position, Vector2.down * (playerHalfHeight + 0.1f), Color.red);   
    }

    private bool GetIsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("Ground"));
    }

    private void Jump()
    {
        Debug.Log("Player Jumped!");
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
