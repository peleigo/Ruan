using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManegement : MonoBehaviour
{
    public GameManager gameManager;
    public static ScoreManegement Instance;
    public  TextMeshProUGUI scoreText;
    public Text HighscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        HighscoreText.text = score.ToString() + "Highscore: " + highscore.ToString();
    }

    private void Update()
    {
        if (scoreText)
        {
            scoreText.text = gameManager.score.ToString() + " points";
        }
        //scoreText.text = score.ToString() + " points";
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + "POINTS";
    }

}
