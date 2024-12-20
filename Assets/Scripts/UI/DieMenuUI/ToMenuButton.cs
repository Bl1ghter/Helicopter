using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuButton : MonoBehaviour
{
    private readonly static string MenuSceneName = "Menu";

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(MenuSceneName);
    }
}
