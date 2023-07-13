using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent
{
    GameObject current;
    Rigidbody rigid;
    public PlayerMoveMent(GameObject gameObject)
    {
        this.current = gameObject;
        rigid = gameObject.GetComponent<Rigidbody>();
    }
    public void Moving()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Player.speed;
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * Player.speed;
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }
}