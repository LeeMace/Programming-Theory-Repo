using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
   // [SerializeField] float gravityScale;
    public float horizontalInput;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpVelocity = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = jumpVelocity;
        }
    }
}
