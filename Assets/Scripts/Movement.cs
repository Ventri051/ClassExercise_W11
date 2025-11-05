using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D myRigidBody;
    [SerializeField] ParticleSystem Pickup;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpSpeed= 10f;
    
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Run();
      
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * speed, myRigidBody.linearVelocity.y);
        myRigidBody.linearVelocity = playerVelocity;
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            myRigidBody.linearVelocity += new Vector2(0f, jumpSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Pickup.Play();
            Destroy(collision.gameObject);

        }
    }
   

}
