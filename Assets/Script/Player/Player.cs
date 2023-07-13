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
    [SerializeField] PlayerCamera playerCamera;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        moveMent = new PlayerMoveMent(this.gameObject);
        detectListener = new PlayerDetectListener(this.gameObject);
        playerCamera.SetPlayer(this.gameObject);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        playerCamera.Update();
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

