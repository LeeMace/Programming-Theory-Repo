using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField] protected Rigidbody2D rb;
    protected float speed = 10;
    protected float jumpForce = 5;
    protected float horizontalInput;
    private float xRange = 80;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SayWhatPlayerYouAre();
    }
    //ABSTRACTION
    void LateUpdate()
    {
        Move();
        Jump();
        StayInBounds();
    }

    public virtual void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    public virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpVelocity = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = jumpVelocity;
        }
    }

    public virtual void SayWhatPlayerYouAre()
    {
        Debug.Log("Hello friend, I am the normal player. I have the normal movement speed and jump strength.");
    }

    void StayInBounds()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
