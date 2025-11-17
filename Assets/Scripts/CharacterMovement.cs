using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float maxSpeed = 6.0f;
    public float moveDirection;
    public bool FacingRight = true;
    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(moveDirection * maxSpeed, rigidbody.linearVelocity.y);
    }
}
