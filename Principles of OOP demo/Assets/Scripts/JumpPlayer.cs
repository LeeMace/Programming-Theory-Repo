using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : PlayerBehaviour
{
    public override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpVelocity = new Vector2(rb.velocity.x, (jumpForce*2));
            rb.velocity = jumpVelocity;
        }

    }
    public override void SayWhatPlayerYouAre()
    {
        Debug.Log("Hi there pal, I am Jumpy, not from nervousness, but from my jump ability.");

    }
}
