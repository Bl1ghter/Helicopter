using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartButton : MonoBehaviour
{
    private readonly static string GameSceneName = "Game"; 

    public void LoadGameScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
