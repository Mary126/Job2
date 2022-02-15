using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int sizeX;
    public int sizeY;
    public GameController gameController;

    private void Start()
    {
        sizeX = (int)transform.localScale.x;
        sizeY = (int)transform.localScale.y;
    }
    private void OnMouseDown()
    {
        gameController.SquareClick(gameObject);
    }
}
