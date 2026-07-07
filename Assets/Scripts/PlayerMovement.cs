using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 6f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isOverPickup = false;
    private OrganPickup currentPickup;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            PlayerInventory inventory = GetComponent<PlayerInventory>();
            inventory.PrintOrgans();
        }

        if (Keyboard.current.eKey.wasPressedThisFrame && isOverPickup)
        {
            currentPickup.AddPickup(GetComponent<PlayerInventory>());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup")) 
        {
            isOverPickup = true;
            currentPickup = collision.GetComponent<OrganPickup>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            isOverPickup = false;
            currentPickup = null;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
