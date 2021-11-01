using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    const float Gravity = 9.81f;

    public float gravityScale = 1.0f;
    public GameClearDetector gameClear;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();
        if (!gameClear.IsClear())
        {
            if (Application.isMobilePlatform)
            {
                vector.x = Input.acceleration.x;
                vector.z = Input.acceleration.y;
                vector.y = -1.0f;
            }
            else
            {
                vector.x = Input.GetAxis("Horizontal");
                vector.z = Input.GetAxis("Vertical");
                vector.y = -1.0f;
            }
        }
        else
        {
            vector.x = 0.0f;
            vector.z = 0.0f;
            vector.y = -1.0f;
        }
        
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
