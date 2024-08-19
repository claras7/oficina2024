using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float totalScore;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject next;
    public static GameController instance;
    
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    
    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void Recomecar(string lvlN)
    {
        SceneManager.LoadScene(lvlN);
    }

    public void NextLevel()
    {
       next. SetActive(true);
    }
}
