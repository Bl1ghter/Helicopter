using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    [SerializeField] private ScoreText _scoreTextScript;

    private int _recordScore;

    private void SavePrefs()
    {
        PlayerPrefs.SetInt("RecordScore", _recordScore);
        PlayerPrefs.SetInt("Score", (int)_scoreTextScript.Score);
        PlayerPrefs.Save();
    }

    private void LoadPrefs()
    {
        _recordScore = PlayerPrefs.GetInt("RecordScore");
    }

    public void CheckNewRecord()
    {
        LoadPrefs();

        if (_scoreTextScript.Score > _recordScore)
        {
            _recordScore = (int)_scoreTextScript.Score;
        }
        SavePrefs();
    }

}
