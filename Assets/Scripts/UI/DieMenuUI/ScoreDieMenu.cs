using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreDieMenu : MonoBehaviour
{
    private TextMeshProUGUI _scoreDieMenuText;
    private int _score;

    private void Start()
    {
        _scoreDieMenuText = GetComponent<TextMeshProUGUI>();

        _score = PlayerPrefs.GetInt("Score");
        _scoreDieMenuText.text = "Your score: " + _score;
    }
}
