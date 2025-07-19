using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Speed of the player movement
    private InputSystem_Actions playerAction; // Input action for player movement
    private Rigidbody2D rb; // Rigidbody component for physics interactions

    public Animator animator; // Animator component for player animations
    
    private void Awake()
    {
        playerAction = new InputSystem_Actions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerAction.Player.Enable(); // Enable the player input actions
    }

    private void OnDisable()
    {
        playerAction.Player.Disable(); // Disable the player input actions
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector2 input = playerAction.Player.Move.ReadValue<Vector2>(); // Read the movement input from the player
        input = input.normalized; // Normalize the input vector to ensure consistent speed in all directions)
        Vector3 movement = new Vector3(input.x, input.y, 0) * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + (Vector2)movement);

        if (input == Vector2.zero)
        {
            animator.Play("Idle"); // Play idle animation if no input is detected
            return;
        }

        if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
        {
            if (input.x > 0)
            {
                // animator.SetTrigger("walkRight"); // Trigger right movement animation
                animator.Play("WalkRight");
            }
            else
            {
                animator.Play("WalkLeft"); // Trigger left movement animation
            }
        }
        if (Mathf.Abs(input.y) > Mathf.Abs(input.x))
        {
            if (input.y > 0)
            {
                animator.Play("walkUp"); // Trigger upward movement animation
            }
            else
            {
                animator.Play("walkDown"); // Trigger downward movement animation
            }
        }

        // rb.linearVelocity = new Vector2(input.x * speed, input.y * speed); // Set the velocity of the Rigidbody2D for movement
    }
}
