using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float MouseSensitivity = 2;
    float mouseX = 0;
    float mouseY = 0;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * MouseSensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * MouseSensitivity;
        mouseY = Mathf.Clamp(mouseY, -90, 90);
        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
