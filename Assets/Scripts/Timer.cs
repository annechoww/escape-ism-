using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLimit = 60f;
    private float timeRemaining;
    public Slider timerSlider;
    public GameObject endGamePanel;

    void Start()
    {
        timeRemaining = timeLimit;

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
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timerSlider != null)
                timerSlider.value = timeRemaining / timeLimit; // Update slider value based on remaining time
        }
        else
        {
            EndGame();
        }
    }

    public static void EndGame()
    {
        if (endGamePanel != null)
        {
            endGamePanel.SetActive(true);
        }

        Time.timeScale = 0;
    }
}
