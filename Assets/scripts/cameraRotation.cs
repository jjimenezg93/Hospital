using UnityEngine;
using System.Collections;

public class cameraRotation : MonoBehaviour {

    public float rotSpeed;
    float xRotation;
    float yRotation;

    void Start() {
        xRotation = 0;
        yRotation = 0;
    }

    void Update () {
        xRotation = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        yRotation = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
        transform.forward = Quaternion.AngleAxis(xRotation, transform.up) * transform.forward;
        transform.forward = Quaternion.AngleAxis(-yRotation, transform.right) * transform.forward;
    }
}
