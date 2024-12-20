using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

[RequireComponent(typeof(ScoreSave))]
[RequireComponent(typeof(SetGameDefaultSettings))]
public class RestartGame : MonoBehaviour
{
    private ScoreSave _scoreSaveScript;
    private SetGameDefaultSettings _setGameDefaultSettingsScript;

    public event Action GameOver;

    private readonly static string _deathMenuSceneName = "DieMenu";

    private void Awake()
    {
        _setGameDefaultSettingsScript = GetComponent<SetGameDefaultSettings>();
        _scoreSaveScript = GetComponent<ScoreSave>();

        _setGameDefaultSettingsScript.SetSettings();
    }

    public void RestartingGame()
    {
        GameOver?.Invoke();
    }

    private void OnEnable()
    {
        GameOver += _setGameDefaultSettingsScript.SetSettings;
        GameOver += _scoreSaveScript.CheckNewRecord;
        GameOver += OpenDeathScene;
    }

    private void OnDisable()
    {
        GameOver -= _setGameDefaultSettingsScript.SetSettings;
        GameOver -= _scoreSaveScript.CheckNewRecord;
        GameOver -= OpenDeathScene;
    }
    private void OpenDeathScene()
    {
        StartCoroutine(WaitBeforeDieMenuLoad());
    }


    private void LoadDieMenuScene()
    {
        SceneManager.LoadScene(_deathMenuSceneName);
    }

    private IEnumerator WaitBeforeDieMenuLoad()
    {
        yield return new WaitForSeconds(0.75f);
        LoadDieMenuScene();
    }
}
