using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rigidbody;

    public float jumppower = 10;
    public GameClearDetector gameClear;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y == 0 && !gameClear.IsClear())
        {
            if (Application.isMobilePlatform)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    rigidbody.velocity = new Vector3(0, jumppower, 0);
                }
            }
            else
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rigidbody.velocity = new Vector3(0, jumppower, 0);
                }
            }
        }
    }
}
