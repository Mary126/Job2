using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int currentMoves = 0;
    public Text moves;
    public void UpdateText(string text)
    {
        moves.text = text;
    }
}
