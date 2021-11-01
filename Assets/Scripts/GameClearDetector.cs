using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole ball;

    private void OnGUI()
    {
        if (ball.IsHolding())
        {
            GUI.Label(new Rect(50, 20, 100, 30), "Game Clear!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
