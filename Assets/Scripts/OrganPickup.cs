using UnityEngine;

public class OrganPickup : MonoBehaviour
{
    public OrganAsset organ;
    private SpriteRenderer spriteRenderer;

    private void OnValidate()
    {
        if (organ != null)
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.sprite = organ.icon;
            }
        }
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if(organ != null){
            spriteRenderer.sprite = organ.icon;
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            PlayerInventory inventory = collision.GetComponent<PlayerInventory>();
            if(inventory != null){
                bool pickedUp = inventory.Add(organ);

                if(pickedUp){
                    Destroy(gameObject);
                }
            }
        }
    }
}
