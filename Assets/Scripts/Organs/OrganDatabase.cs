using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "OrganDatabase", menuName = "Inventory/OrganDatabase")]
public class OrganDatabase : ScriptableObject
{
    [Tooltip("Add Organ Assets Here")]
    public List<OrganAsset> allOrgans;
}
