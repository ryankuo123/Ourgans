using UnityEngine;

public class ResourceSpot : MonoBehaviour
{
    public ResourceAsset resourceAsset;
    private SpriteRenderer spriteRenderer;

    private void OnValidate()
    {
        if (resourceAsset != null)
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.sprite = resourceAsset.icon;
            }
        }
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if(resourceAsset != null){
            spriteRenderer.sprite = resourceAsset.icon;
        }
    }

    void Update()
    {
        
    }
}
