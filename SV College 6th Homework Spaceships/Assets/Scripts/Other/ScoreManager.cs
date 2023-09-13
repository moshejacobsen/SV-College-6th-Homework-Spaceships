using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    [SerializeField] TextMeshProUGUI scoreText;
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
