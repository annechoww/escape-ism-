using UnityEngine;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject gameManager;
    private int currentPanelIndex = 0;

    private void Awake()
    {
        gameManager.SetActive(false);
    }

    private void Start()
    {
        // Hide all panels at the start
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
        
        // Show the first panel
        if (panels.Length > 0)
            panels[0].SetActive(true);
    }

    public void OnEnterPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            panels[currentPanelIndex].SetActive(false);
            currentPanelIndex++;

            if (currentPanelIndex < panels.Length)
            {
                panels[currentPanelIndex].SetActive(true);
            }
            else
            {
                StartGameplay();
            }
        }
    }

    private void StartGameplay()
    {
        Debug.Log("Gameplay starts now!");
        gameManager.SetActive(true);
    }
}
