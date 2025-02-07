using UnityEngine;

public class Coin : MonoBehaviour
{
    // public int coinValue = 1;  // How much this coin is worth (1 for each collection)
    
    // This will be called when another collider enters the trigger area
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collided with the coin
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collision DETECTED");
            // Update the player's coin counter
            other.GetComponent<Player>().UpdateCoinCount();
            
            // Destroy the coin (make it disappear)
            Destroy(gameObject);
        }
    }
}
