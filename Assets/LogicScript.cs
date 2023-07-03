using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverPanel;

    [ContextMenu("Increase Score")]  // For adding context menu in the unity editor. Lets call the function from the editor
    public void updateScore(int score=1)
    {
        playerScore+=score; // Increase the score by 1
        // Debug
        scoreText.text = playerScore.ToString(); // Update the score text. Converting it into a string
    }
     
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void gameOver()
    {
        gameOverPanel.SetActive(true); // Show the game over panel
    }

}
