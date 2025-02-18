using UnityEngine;
using UnityEngine.UI;  // Required to use UI components

public class Player : MonoBehaviour
{
    public int coinCount = 1;  // The player's current coin count
    public Text coinCounterText;  // UI Text element to display coin count

    // Method to update the coin count (called by the Coin script)
    public void UpdateCoinCount()
    {
        coinCount = coinCount - 1;
        Debug.Log(coinCount);
        UpdateCoinDisplay();
    }

    // Update the coin counter on the screen
    private void UpdateCoinDisplay()
    {
        if (coinCounterText != null)
        {
            coinCounterText.text = "Coins Remaining: " + coinCount.ToString();
        }
    }
}
