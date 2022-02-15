using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleGameController : MonoBehaviour
{
    public GameObject expantionScreen;
    public GameObject level1;
    public GameObject level2;  
    public GameObject level3;
    public GameObject currentTriangle;
    public int energy;

    public void ShowTriangles(string tg)
    {
        if (tg != "Level Menu")
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            switch (tg)
            {
                case "Level1": level1.SetActive(true); break;
                case "Level2": level2.SetActive(true); break;
                case "Level3": level3.SetActive(true); break;
                default: break;
            }
        }
    }
    public void TriangleClick(GameObject triangle)
    {
        currentTriangle = triangle;
    }
    public void SquareClick(GameObject square)
    {
        energy--;
        GetComponent<GameController>().playerController.currentMoves += 1;
        GetComponent<GameController>().playerController.UpdateText("Moves: " + GetComponent<GameController>().playerController.currentMoves + " Energy: " + energy);
        square.transform.localScale = new Vector3(square.transform.localScale.x - 1, square.transform.localScale.y - 1, 0);
        Destroy(currentTriangle);
        currentTriangle = null;
    }
    private void Start()
    {
        expantionScreen.SetActive(true);
        GetComponent<GameController>().playerController.UpdateText("Moves: " + GetComponent<GameController>().playerController.currentMoves + " Energy: " + energy);
    }
}
