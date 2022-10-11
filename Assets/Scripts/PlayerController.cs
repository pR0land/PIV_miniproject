using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Vector3 rotationAroundX = new Vector3();
    private Vector3 direction = new Vector3();



    [SerializeField]
    private float movementSpeed = 5, horizontalSensitivity = 3, jumpforce = 5;

    private bool isGrounded = false;
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
        
        if (isGrounded)
        {
            //Bev�gelse
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.z = Input.GetAxisRaw("Vertical");
            //Hop
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        //rotation omkring x aksen n�r man rykker med musen
        rotationAroundX = new Vector3(0, Input.GetAxis("Mouse X"), 0);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = true;
            print("can jump");
        }
    }
}
