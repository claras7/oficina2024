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
    public GameObject Next;
    public static GameController instance;
    
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    
    public void nextLevel()
    {
        Next.SetActive(true);
    }
    public void Continuar(string lvlN)
    {
        SceneManager.LoadScene(lvlN);
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void Recomecar(string lvlN)
    {
        SceneManager.LoadScene(lvlN);
    }
}
