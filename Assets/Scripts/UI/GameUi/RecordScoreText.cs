using System;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class RecordScoreText : MonoBehaviour
{
    private int _recordScore;
    private TextMeshProUGUI _scoreText;

    private void Start()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();

        _recordScore = PlayerPrefs.GetInt("RecordScore");
        _scoreText.text = Convert.ToString(_recordScore);
    }


}
