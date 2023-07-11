using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    PlayerMoveMent moveMent;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        moveMent = new PlayerMoveMent(this.gameObject);
    }

    private void LateUpdate()
    {
        moveMent.Moving();
    }

}
class PlayerMoveMent
{
    GameObject current;
    public PlayerMoveMent(GameObject gameObject)
    {
        this.current = gameObject;
    }
    public void Moving()
    {
        Debug.Log("asd");
    }
}
