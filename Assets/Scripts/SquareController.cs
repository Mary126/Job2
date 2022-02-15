using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int sizeX;
    public int sizeY;
    public GameController gameController;
    public bool isColliding = false;

    private void Start()
    {
        sizeX = (int)transform.localScale.x;
        sizeY = (int)transform.localScale.y;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            isColliding = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isColliding = false;
    }
    private void OnMouseDown()
    {
        gameController.SquareClick(gameObject);
    }
}
