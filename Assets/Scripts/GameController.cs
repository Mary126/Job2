using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject currentSquare;
    public PlayerController playerController;
    public void SquareClick(GameObject square)
    {
        currentSquare = square;
    }
    public void CircleClick(GameObject sircle)
    {
        if (currentSquare != null)
        {
            float d = currentSquare.transform.localScale.x * Mathf.Sqrt(2);
            if (d <= sircle.transform.localScale.x)
            {
                currentSquare.transform.position = sircle.transform.position;
                playerController.currentMoves += 1;
                playerController.UpdateText();
            }
            currentSquare = null;
        }
    }
}
