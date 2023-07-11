using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 15f; // 기본 15가 딱좋아보임
    Rigidbody rigid;
    PlayerMoveMent moveMent;    

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        moveMent = new PlayerMoveMent(rigid);
    }
    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        moveMent.Moving();
    }

}
class PlayerMoveMent
{
    Rigidbody current;
    public PlayerMoveMent(Rigidbody rigidbody)
    {
        this.current = rigidbody;
    }
    public void Moving()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Player.speed;
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * Player.speed;
        current.AddForce(new Vector3(h, 0, v), ForceMode.VelocityChange);
    }
}
