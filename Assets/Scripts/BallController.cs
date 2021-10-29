using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rigidbody;

    public float jumppower = 10;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y == 0)
        {
            if (Input.GetButton("Jump"))
            {
                rigidbody.velocity = new Vector3(0, jumppower, 0);
            }
        }
    }
}
