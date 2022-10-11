using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
   
    [SerializeField]
    private float tiltMax = 25, tiltMin = -25, verticalSensitivity = 15;
    private float tilt; 
    private Vector3 tiltRotation = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void FixedUpdate()
    {
        gameObject.transform.localEulerAngles = tiltRotation;
    }
    // Update is called once per frame
    void Update()
    {
        tilt -= Input.GetAxis("Mouse Y") * verticalSensitivity;
        tiltRotation.x = Mathf.Clamp(tilt, tiltMin, tiltMax);

    }
}
