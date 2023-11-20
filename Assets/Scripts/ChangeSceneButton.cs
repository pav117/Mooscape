using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public AddTime addTime;
    public void LoadScene(string sceneName)
    {
        GameObject addTimeGameObject = GameObject.FindGameObjectWithTag("TimeManager");
        addTime = addTimeGameObject.GetComponent<AddTime>();
        if (addTime != null)
        {
            addTime.score = addTime.score + 1;
            print(addTime.score);
        }
            
        SceneManager.LoadScene(sceneName);
    }
}