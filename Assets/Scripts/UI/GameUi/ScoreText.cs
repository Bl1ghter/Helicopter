using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreText : MonoBehaviour
{
    public float Score;

    private TextMeshProUGUI _scoreText;
    private int _scoreMultiplayer = 10;

    private void Start()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void ScoreAdd(float score)
    {
        Score = score * _scoreMultiplayer;
        _scoreText.text = ((int)Score).ToString();
    }
}
