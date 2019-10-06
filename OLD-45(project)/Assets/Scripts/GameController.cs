using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameObject MeteorsObj;
    private static GameObject level_2;
    private static GameObject level_3;
    private void Start()
    {
        MeteorsObj = GameObject.FindGameObjectWithTag("Respawn");
        MeteorsObj.SetActive(false);
        level_2 = GameObject.FindGameObjectWithTag("Level_2");
        level_2.SetActive(false);
        level_3 = GameObject.FindGameObjectWithTag("LEVEL_3");
        level_3.SetActive(false);
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
    public static void RestartScene()
    {
        SceneManager.LoadScene(1);
    }
    public static void FinishScene()
    {
        SceneManager.LoadScene(2);
    }

    public static void OpenLevel2()
    {
        level_2.SetActive(true);
        MeteorsObj.SetActive(true);
    }
    public static void OpenLevel3()
    {
        level_3.SetActive(true);
    }
}
