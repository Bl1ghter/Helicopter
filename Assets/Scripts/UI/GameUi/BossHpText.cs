using UnityEngine;
using TMPro;

public class BossHpText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bossHpText;

    public void ChangeHpValue(float _health)
    {
        _bossHpText.text = _health.ToString();
    }
}
