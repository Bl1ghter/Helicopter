using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private GameObject _MenuObject;
    
    public void OpenSettings()
    {
        _MenuObject.SetActive(true);
    }
}
