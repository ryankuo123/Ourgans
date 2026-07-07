using UnityEngine;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    [Header("Grid Container")]
    [SerializeField] private GameObject gridContainer;

    private bool isVisible = true;

    void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            isVisible = !isVisible;

            gridContainer.SetActive(isVisible);
        }
    }
}
