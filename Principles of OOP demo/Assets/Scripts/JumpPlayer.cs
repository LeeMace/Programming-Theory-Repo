using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : PlayerBehaviour
{
    public override void Jump()
    {
        Vector2 jumpVelocity = new Vector2(rb.velocity.x, (jumpForce*2));
        base.Jump();
    }
    public override void SayWhatPlayerYouAre()
    {
        Debug.Log("Hi there pal, I am Jumpy, not from nervousness, but from my jump ability.");

    }
    public override void Move()
    {
        base.Move();
    }
}
