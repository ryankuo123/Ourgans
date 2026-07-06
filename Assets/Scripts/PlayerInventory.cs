using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<OrganAsset> organs = new List<OrganAsset>();
    public int maxSpace = 5;

    public bool Add(OrganAsset organ){
        organs.Add(organ);
        return true;
    }

    public void Remove(OrganAsset organ){
        organs.Remove(organ);
    }

    public void PrintOrgans(){
        for(int i = 0; i < organs.Count; i++){
            Debug.Log($"{organs[i]}");
        }
    }
}
