using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject levelMenu;
    public Button buttn;
    public GameController gameController;

    void TaskOnClick()
    {
        switch (tag)
        {
            case "Level Menu": ShowLevelMenu(); break;
            case "Level1": ShowLevel(level1); break;
            case "Level2": ShowLevel(level2); break;
            case "Level3": ShowLevel(level3); break;
            default: Debug.Log("No buttn tag"); break;
        }
        if (gameController.expTrianges == true)
        {
            gameController.trianglesGameController.ShowTriangles(tag);
        }
    }
    void ShowLevelMenu()
    {
        levelMenu.SetActive(!levelMenu.activeSelf);
    }
    void ShowLevel(GameObject level)
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level.SetActive(true);
        levelMenu.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        buttn.onClick.AddListener(TaskOnClick);
    }
}
