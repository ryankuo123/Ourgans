using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 6f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        //dont know wut this duz
        moveInput.Normalize();

        //Space key Testing 
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            PlayerInventory inventory = GetComponent<PlayerInventory>();
            inventory.PrintOrgans();
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
