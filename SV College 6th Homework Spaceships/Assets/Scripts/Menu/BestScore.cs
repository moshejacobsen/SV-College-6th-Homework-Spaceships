using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private void Start()
    {
        scoreText.text = ScoreManager.score.ToString();
    }
}
