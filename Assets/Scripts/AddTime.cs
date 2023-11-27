using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddTime : MonoBehaviour
{
    public int score = 6;

    GameObject[] InvItem;

    GameObject[] Awakener;

    void Update()
    {
        InvItem = GameObject.FindGameObjectsWithTag("InvItem");

        Awakener = GameObject.FindGameObjectsWithTag("Awakener");

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (Awakener.Length == 0)
        {
            if (score == 18)
            {
                if (InvItem.Length == 0)
                {
                    if (sceneName != "Farm")
                    {
                        SceneManager.LoadScene(7);
                    }
                }
                else if (InvItem.Length >= 1)
                {
                    SceneManager.LoadScene(8);
                }
            }
        }
        else if (Awakener.Length == 1)
        {
            ;
        }
    }
}