using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text finalScore;
    [SerializeField] private TMP_Text bestScore;
    [SerializeField] private TMP_Text newBestScore;

    int score = 0;
    int newScore = 0;
    int hightScore;
    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = score.ToString();
        hightScore = PlayerPrefs.GetInt("hightScore", 0);
        Debug.Log(PlayerPrefs.GetInt("hightScore"));
    }

    
    public void ShowFinalResault()
    {
        hightScore = PlayerPrefs.GetInt("hightScore");
        finalScore.text = "score:" + score.ToString();
        bestScore.text = "best score:" + hightScore.ToString();
    }

    public void AddScore()
    {        
        newScore = CubeCollision.cubeNumberToScore;
        score += newScore;
        scoreText.text = score.ToString();
        if (hightScore < score)
        {
            newBestScore.gameObject.SetActive(true);
            PlayerPrefs.SetInt("hightScore", score);
        }

        Debug.Log(PlayerPrefs.GetInt("hightScore"));
    }
}
