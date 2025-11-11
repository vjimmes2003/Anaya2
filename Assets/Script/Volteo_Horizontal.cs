using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float maxSpeed = 5f;
    public float moveDirection;
    public bool facingRight = true; // <-- Aqu� la declaraci�n

    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }



    void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(moveDirection * maxSpeed, rigidbody.linearVelocity.y);

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
