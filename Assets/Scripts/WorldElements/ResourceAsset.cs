using UnityEngine;

public enum ResourceType {one, two, three}

[CreateAssetMenu(fileName = "ResourceAsset", menuName = "Scriptable Objects/ResourceAsset")]
public class ResourceAsset : ScriptableObject
{
    public string resourceName;
    public int resourceAmount;
    public float mineTime;
    public ResourceType type;
    public Sprite icon;
}