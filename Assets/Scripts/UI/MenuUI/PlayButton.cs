using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private readonly static string GameSceneName = "Game";

    public void StartGame()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
