using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Grid Container")]
    [SerializeField] private GameObject gridContainer;

    private bool isVisible = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isVisible = !isVisible;

            gridContainer.SetActive(isVisible);
        }
    }
}
