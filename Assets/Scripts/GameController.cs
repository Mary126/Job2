using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject currentSquare;
    public PlayerController playerController;
    public bool expTrianges = false;
    public TriangleGameController trianglesGameController;
    public void SquareClick(GameObject square)
    {
        if (expTrianges == true && trianglesGameController.currentTriangle != null && square.transform.localScale.x > 1)
        {
            trianglesGameController.SquareClick(square);
        }
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
                playerController.UpdateText("Moves: " + playerController.currentMoves);
            }
            currentSquare = null;
        }
    }
    private void Start()
    {
        trianglesGameController = GetComponent<TriangleGameController>();
        if (expTrianges == true)
        {
            (GetComponent<TriangleGameController>() as MonoBehaviour).enabled = true;
            trianglesGameController.level1.SetActive(true);
        }
        else
        {
            (GetComponent<TriangleGameController>() as MonoBehaviour).enabled = false;
        }
    }
}
