using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameLogic : MonoBehaviour
{
    public int playerScore;
    public bool isDead = false;
    public Text scoreText;
    public GameObject gameOverCanvas;

    public void UpdateScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Die()
    {
        isDead = true;
        gameOverCanvas.SetActive(true);
    }
}
