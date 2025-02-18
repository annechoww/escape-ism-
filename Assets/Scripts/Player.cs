using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinCount = 1;
    public Text coinCounterText;

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
