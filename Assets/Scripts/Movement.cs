using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float sprint = 1;
    public float speed = 3;
    public Vector3 startPos = new Vector3(0, 0.5f, -24);
    private Rigidbody PlayerRb;
    public float jumpPower = 10;
    public bool isOnGround = true;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
       PlayerRb = GetComponent<Rigidbody>();
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        //Player jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            PlayerRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isOnGround = false;
        }
        
        

        //Player control
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Input.GetAxis("Vertical");
        //Sprinting Mechanic
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = 5;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = 1;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * sprint * speed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * sprint * speed);

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        if (cooldown <= 0)
        {
            cooldown = 0;
            speed = 3;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        
        isOnGround = true;
        
        
        if (collision.gameObject.CompareTag("powerUp"))
        {
            speed = 30;
            cooldown = 10;
        }
    }
}
