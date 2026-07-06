using UnityEngine;

public class OrganLog : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private OrganDatabase organDatabase;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotsContainer;

    // Update is called once per frame
    void Start()
    {
        foreach (Transform child in slotsContainer)
        {
            Destroy(child.gameObject);
        }

        // Loop through the master database
        foreach (var organ in organDatabase.allOrgans)
        {
            Debug.Log("organ");
            GameObject newSlot = Instantiate(slotPrefab, slotsContainer);
            OrganSlotUI slotLogic = newSlot.GetComponent<OrganSlotUI>();
            slotLogic.SetupSlot(organ);
        }
    }
}
