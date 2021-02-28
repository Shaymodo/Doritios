using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public Movement movementcontroller;
    // Start is called before the first frame update
    void Start()
    {
        movementcontroller = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            transform.position = movementcontroller.startPos;
        }
    }
}
