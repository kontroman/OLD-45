using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameObject level_2;
    private void Start()
    {
        level_2 = GameObject.FindGameObjectWithTag("Level_2");
        level_2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            RestartGame();
    }

    public static void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void OpenLevel2()
    {
        level_2.SetActive(true);
    }
}
