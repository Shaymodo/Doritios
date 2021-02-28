using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 startPos = new Vector3(0, 20, -25);
    public Quaternion rot1 = Quaternion.Euler(28.488f, 0, 0);
    public Quaternion rot2 = Quaternion.Euler(28.488f, -90, 0);
    public Quaternion rot3 = Quaternion.Euler(28.488f, 180, 0);
    public Quaternion rot4 = Quaternion.Euler(28.488f, 90, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = startPos;
            transform.rotation = rot1;
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
             
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(40, 20, 0);
            transform.rotation = rot2;
            player.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = new Vector3(0, 20, 40);
            transform.rotation = rot3;
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position = new Vector3(-40, 20, 0);
            transform.rotation = rot4;
            player.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

    }
}
