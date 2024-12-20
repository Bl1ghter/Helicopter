using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(TextMeshProUGUI))]
public class RecordScoreDieMenu : MonoBehaviour
{
    private TextMeshProUGUI _recordScoreDieMenuText;
    private int _recordScore;

    private void Start()
    {
        _recordScoreDieMenuText = GetComponent<TextMeshProUGUI>();

        _recordScore = PlayerPrefs.GetInt("RecordScore");
        _recordScoreDieMenuText.text = "Record: " + Convert.ToString(_recordScore);
    }
}
