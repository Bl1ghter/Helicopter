using UnityEngine;

public class SetGameDefaultSettings : MonoBehaviour
{
    private void Awake()
    {
        SetSettings();
    }

    public void SetSettings() 
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }
}
