using UnityEngine;

public class PlayerMoveHorizontal : MonoBehaviour
{
    [SerializeField] private float _PlayerMoveSpeed;

    public void MoveHorizontal(float direction)
    {
        transform.Translate(Vector2.left * direction * _PlayerMoveSpeed * Time.deltaTime);
    }
}