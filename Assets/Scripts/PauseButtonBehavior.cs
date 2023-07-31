using UnityEngine;
using UnityEngine.Serialization;

public class PauseButtonBehavior : MonoBehaviour
{
    // PauseOverlay is the pause menu overlay
    public GameObject pauseOverlay;
    
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseOverlay.SetActive(true);
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
    }
}
