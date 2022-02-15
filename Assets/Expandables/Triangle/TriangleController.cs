using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    public int sizeX;
    public int sizeY;
    public TriangleGameController triangleController;

    private void OnMouseDown()
    {
        triangleController.TriangleClick(gameObject);
        Debug.Log("Clicked");
    }
}
