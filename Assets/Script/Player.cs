using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 15f; // �⺻ 15�� �����ƺ���
    Rigidbody rigid;
    PlayerMoveMent moveMent;
    PlayerDetectListener detectListener;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        moveMent = new PlayerMoveMent(this.gameObject);
        detectListener = new PlayerDetectListener(this.gameObject);
    }
    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        moveMent.Moving();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground") Debug.Log("�ٴڰ� �浹");
    }

}
class PlayerMoveMent
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
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.VelocityChange);
    }
}
class PlayerDetectListener
{
    GameObject current;
    Rigidbody rigid;
    public PlayerDetectListener(GameObject gameObject)
    {
        this.current = gameObject;
        rigid = gameObject.GetComponent<Rigidbody>();
    }
}