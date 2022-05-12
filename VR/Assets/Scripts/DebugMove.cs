using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMove : MonoBehaviour
{

    public Transform cameraOffset;
    public float moveSpeed = 5f;

    float xRotation;
    float yRotation;
    public float sensitivity = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float ha = Input.GetAxis("Horizontal");
        float va = Input.GetAxis("Vertical");

        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;

        cameraOffset.position = cameraOffset.position + cameraOffset.right * ha * Time.deltaTime * moveSpeed + cameraOffset.forward * va * Time.deltaTime * moveSpeed;
        cameraOffset.position = new Vector3(cameraOffset.position.x, 2, cameraOffset.position.z);
        
        transform.localEulerAngles = new Vector3(xRotation, yRotation, 0f);
    }
}
