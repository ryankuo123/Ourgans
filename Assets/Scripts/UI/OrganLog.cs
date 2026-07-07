using UnityEngine;

public class OrganLog : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private OrganDatabase organDatabase;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotsContainer;

    void Start()
    {
        foreach (Transform child in slotsContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (var organ in organDatabase.allOrgans)
        {
            GameObject newSlot = Instantiate(slotPrefab, slotsContainer);
            OrganSlotUI slotLogic = newSlot.GetComponent<OrganSlotUI>();
            slotLogic.SetupSlot(organ);
        }
    }
}
