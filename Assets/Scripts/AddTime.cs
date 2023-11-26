using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddTime : MonoBehaviour
{
    public int score = 7;

    GameObject[] InvItem;

    void Update()
    {
        InvItem = GameObject.FindGameObjectsWithTag("InvItem");

        if (score == 18)
        {
            if (InvItem.Length == 0)
            {
                SceneManager.LoadScene(7);
            }
            else if (InvItem.Length >= 1)
            {
                SceneManager.LoadScene(8);
            }
        }
    }
}