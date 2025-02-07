using UnityEngine;
using UnityEngine.UI; // For UI elements

public class Timer : MonoBehaviour
{
    public float timeLimit = 60f; // Set the time limit (in seconds)
    private float timeRemaining;
    public Slider timerSlider; // UI Slider element to display as a status bar
    public GameObject endGamePanel; // A UI panel to display when the game ends

    void Start()
    {
        // Initialize the timer
        timeRemaining = timeLimit;

        // Set the slider's max value
        if (timerSlider != null)
        {
            timerSlider.maxValue = 1;
            timerSlider.value = 1;
        }

        // Make sure the EndGame panel is hidden at the start
        if (endGamePanel != null)
            endGamePanel.SetActive(false);
    }

    void Update()
    {
        // Countdown timer
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            // Update the timer slider (status bar)
            if (timerSlider != null)
                timerSlider.value = timeRemaining / timeLimit; // Update slider value based on remaining time
        }
        else
        {
            // Timer is up, trigger the end of the game
            EndGame();
        }
    }

    // This method is called when time is up
    private void EndGame()
    {
        if (endGamePanel != null)
        {
            endGamePanel.SetActive(true); // Show the end game UI
        }

        // Optionally, you can pause the game here:
        Time.timeScale = 0; // This stops everything (except UI) in the game.
    }
}
