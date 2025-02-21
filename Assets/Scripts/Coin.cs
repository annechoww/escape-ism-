using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource audioSource;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().UpdateCoinCount();
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
