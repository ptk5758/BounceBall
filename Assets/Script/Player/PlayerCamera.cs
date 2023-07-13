using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCamera
{
    GameObject current;    
    [SerializeField] GameObject camera;
    public void SetPlayer(GameObject gameObject)
    {
        current = gameObject;
    }
    public void Update() 
    {
        camera.transform.position = current.transform.position + new Vector3(0, 10, 0);
    }
}
