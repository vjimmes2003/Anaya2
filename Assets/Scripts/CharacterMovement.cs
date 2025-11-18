using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    void FixedUpdate()
    {
        // L�gica para voltear
        if (moveDirection > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveDirection < 0 && facingRight)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up, 180f, Space.World);
    }
}


