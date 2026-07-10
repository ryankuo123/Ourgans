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
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = organ.highlightIcon;
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = organ.icon;
        }
    }

    public void AddPickup(PlayerInventory inventory){
        if(inventory != null){
            bool pickedUp = inventory.Add(organ);
            if(pickedUp){
                Destroy(gameObject);
            }
        }
    }
}
