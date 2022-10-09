using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Vector3 rotationAroundX = new Vector3();
    private Vector3 direction = new Vector3();

    [SerializeField]
    private float movementSpeed = 5, horizontalSensitivity = 3;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        gameObject.transform.Rotate(rotationAroundX*horizontalSensitivity);
        gameObject.transform.Translate(direction*movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //rotation omkring x aksen når man rykker med musen
        rotationAroundX = new Vector3(0, Input.GetAxis("Mouse X"), 0);

        //Bevægelse
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }
}
