using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    [SerializeField] private Vector2 _boxSize;
    [SerializeField] private LayerMask _layer;

    private float _boxAngle = 90;

    private void FixedUpdate()
    {
        Collider2D[] collider = Physics2D.OverlapBoxAll(transform.position, _boxSize, _boxAngle, _layer);

        if (collider.Length != 0)
        {
            for(int i = 0; i < collider.Length; i++)
            {
                Destroy(collider[i].gameObject);
            }
        }
    }
}
    