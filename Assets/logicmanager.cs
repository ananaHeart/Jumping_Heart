using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.VirtualTexturing;

public class logicmanager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameover;

    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOverScreen()
    {
        gameover.SetActive(true);    
    }
    
}
