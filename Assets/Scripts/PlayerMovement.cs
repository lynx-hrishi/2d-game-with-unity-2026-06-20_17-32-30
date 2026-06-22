using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator _animator;
    private Vector2 movement;
    private Vector2 screenBounds;
    private float playerHalfWidth;
    private float xPosLastFrame;

    void Start()
    {
        Debug.Log("Starting the Game");
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        playerHalfWidth = spriteRenderer.bounds.extents.x;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        ClampMovement();  // Reassing the clamped value back to player position
        FlipCharacter();
    }

    private void FlipCharacter()
    {
        float input = Input.GetAxisRaw("Horizontal");
        if (input > 0 && (transform.position.x > xPosLastFrame))
        {
            // We are moving right
            spriteRenderer.flipX = false; 
        }
        else if (input < 0 && (transform.position.x < xPosLastFrame))
        {
            // We are moving left
            spriteRenderer.flipX = true;
        }
        xPosLastFrame = transform.position.x;
    }

    private void ClampMovement()
    {
        float clampedX = Mathf.Clamp(transform.position.x, -screenBounds.x + playerHalfWidth, screenBounds.x - playerHalfWidth); // refers to (current_player_pos, min_value, max_value)
        Vector2 player_pos = transform.position;  // Get the players current position
        player_pos.x = clampedX;  // Reassign the x value to the clamped position
        transform.position = player_pos;
    }

    private void HandleMovement()
    {
        float input = Input.GetAxisRaw("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);

        if (input != 0)
        {
            _animator.SetBool("isRunning", true);
        }
        else
        {
            _animator.SetBool("isRunning", false);
        }
    }
}
