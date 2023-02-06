using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlayer : PlayerBehaviour
{
    public override void Move()
    {
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * (speed*2));
        base.Move();
    }

    public override void SayWhatPlayerYouAre()
    {
        Debug.Log("Hello buddy, I'm Speedy andIliketogofaaaaaaaast");
    
    }
}
