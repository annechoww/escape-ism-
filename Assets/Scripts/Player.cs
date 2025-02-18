using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinCount = 0;
    public int totalCoins = 22;
    public Text coinCounterText;
    public GameObject levelCompletePanel;

    public void UpdateCoinCount()
    {
        coinCount = coinCount + 1;
        totalCoins = totalCoins - 1;
        UpdateCoinDisplay();

        if (totalCoins == 0)
        {
            LevelComplete();
        }
    }

    // Update the coin counter on the screen
    private void UpdateCoinDisplay()
    {
        if (coinCounterText != null)
        {
            coinCounterText.text = coinCount.ToString();
        }
    }

    private void LevelComplete()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true);
        }
    }
}
