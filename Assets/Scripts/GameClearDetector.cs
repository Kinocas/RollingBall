using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearDetector : MonoBehaviour
{
    public Hole ball;
    bool isClear;

    public bool IsClear()
    {
        return isClear;
    }

    private void OnGUI()
    {
        if (ball.IsHolding())
        {
            isClear = true;
            GUI.Label(new Rect(50, 20, 100, 30), "Game Clear!");
        }
    }
}
