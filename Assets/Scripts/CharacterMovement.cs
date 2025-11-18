using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up, 180f, Space.World);
    }
}
