using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
 
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
 
    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
 
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        if(playerScore>highScore){
            highScore=playerScore;
            PlayerPrefs.SetInt("highScore",playerScore);
            highScoreText.text="High Score: "+highScore.ToString();
        }
    }
}
 