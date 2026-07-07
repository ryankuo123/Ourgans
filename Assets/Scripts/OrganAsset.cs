using UnityEngine;


[CreateAssetMenu(fileName = "New Organ", menuName = "Inventory/Organ")]
public class OrganAsset : ScriptableObject 
{
    public string organName;
    public Sprite icon;
    public Sprite highlightIcon;
}

