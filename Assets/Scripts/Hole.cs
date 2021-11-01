using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;
    bool isHolding;

    public bool IsHolding()
    {
        return isHolding;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            isHolding = true;
        }
    }
}
