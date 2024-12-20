using UnityEngine;

[RequireComponent(typeof(PlayerMoveHorizontal))]
public class PlayerMoveDirection : MonoBehaviour
{
    private PlayerHorizontalMove _playerHorizontalMoveInputSystem;

    private PlayerMoveHorizontal _PlayerMoveHorizontalScript;

    private bool IsPlayerOnMobile;

    private void Awake()
    {
        _playerHorizontalMoveInputSystem = new PlayerHorizontalMove();
        _playerHorizontalMoveInputSystem.Enable();

        _PlayerMoveHorizontalScript = GetComponent<PlayerMoveHorizontal>();

        IsPlayerOnMobile = Application.platform != RuntimePlatform.WindowsPlayer ? true : false;
    }

    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        float inputDirectionX;

        if(IsPlayerOnMobile == true)
        {
            float inputDirectionWithoitClamp = -Input.acceleration.x * 5;
            inputDirectionX = Mathf.Clamp(inputDirectionWithoitClamp, -3.5f, 3.5f);
        }
        else
        {
            inputDirectionX = _playerHorizontalMoveInputSystem.Movement.HorizontalMovementPc.ReadValue<float>();
        }



        Debug.Log(IsPlayerOnMobile);

        _PlayerMoveHorizontalScript.MoveHorizontal(inputDirectionX);
    }


}