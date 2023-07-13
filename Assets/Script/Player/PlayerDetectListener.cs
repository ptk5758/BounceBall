using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectListener
{
    GameObject current;
    Rigidbody rigid;
    public PlayerDetectListener(GameObject gameObject)
    {
        this.current = gameObject;
        rigid = gameObject.GetComponent<Rigidbody>();
    }
    public void OnDetectGround()
    {
        rigid.AddForce(new Vector3(0, Player.jump, 0), ForceMode.Impulse);
        Player.bounce++;
    }
}