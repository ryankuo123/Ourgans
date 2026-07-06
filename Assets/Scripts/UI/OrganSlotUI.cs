using UnityEngine;
using UnityEngine.UI;

public class OrganSlotUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    
    [SerializeField] private Color lockedColor = new Color(0.2f, 0.2f, 0.2f, 1f); // Dark Gray

    public void SetupSlot(OrganAsset organAsset)
    {
        iconImage.sprite = organAsset.icon;
    }
}
