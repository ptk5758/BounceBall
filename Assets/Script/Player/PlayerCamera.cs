using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCamera
{
    GameObject current;    
    [SerializeField] GameObject camera;
    public float xRotate = 0;
    public void SetPlayer(GameObject gameObject)
    {
        current = gameObject;
    }
    public void Update() 
    {
        CameraMoving();
        MouseRotation();
    }
    private void MouseRotation()
    {
        float yRotateSize = Input.GetAxis("Mouse X");
        float yRotate = camera.transform.eulerAngles.y + yRotateSize;
        float xRotateSize = Input.GetAxis("Mouse Y");
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
        camera.transform.eulerAngles = new Vector3(xRotate, yRotate, 0);

    }
    private void CameraMoving()
    {
        camera.transform.position = current.transform.position + new Vector3(0, 10, 0);
    }
}
