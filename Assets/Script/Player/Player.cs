using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 50f; // ???? 50 ??????????
    public static float jump = 80f;
    public static int bounce = 0;
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
        /*if (Input.GetKeyDown(KeyCode.Alpha1)) speed++;
        if (Input.GetKeyDown(KeyCode.Alpha2)) speed--;
        Debug.Log(speed);*/
    }

    private void LateUpdate()
    {
        moveMent.Moving();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground") detectListener.OnDetectGround();
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
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
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
    public void OnDetectGround()
    {
        rigid.AddForce(new Vector3(0,Player.jump,0), ForceMode.Impulse);
        Player.bounce++;
    }
}