using UnityEngine;

[RequireComponent(typeof(CheckIsPlayerFall))]
[RequireComponent(typeof(PlayerCheckJump))]
public class PlayerFallScriptCall : MonoBehaviour
{
    private CheckIsPlayerFall _checkIsPlayerFallScript;
    private PlayerCheckJump _playerCheckJumpScript;

    private void Start()
    {
        _checkIsPlayerFallScript = GetComponent<CheckIsPlayerFall>();
        _playerCheckJumpScript = GetComponent<PlayerCheckJump>();
    }

    private void FixedUpdate()
    {
        CallCheckFallFunk();
    }

    private void CallCheckFallFunk()
    {
        if (_checkIsPlayerFallScript.CheckIsPlayerFallMethod())
        {
            _playerCheckJumpScript.IsPlayerOnPlatform();
        }
    }
}
