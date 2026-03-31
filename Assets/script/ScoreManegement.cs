using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManegement : MonoBehaviour
{
    public static ScoreManegement Instance;
    public Text scoreText;
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

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + "POINTS";
    }

}
