using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingTrigger : MonoBehaviour
{
    GameObject[] Ending2Trigger;
    GameObject[] InvItem;

    void Update()
    {
        InvItem = GameObject.FindGameObjectsWithTag("InvItem");
        Ending2Trigger = GameObject.FindGameObjectsWithTag("Ending2Trigger");
    }

    public void OnButtonClick()
    {
        if (InvItem.Length >= 1)
        {
            if (Ending2Trigger.Length == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (Ending2Trigger.Length == 0)
            {
                SceneManager.LoadScene(11);
            }
        }
    }
}
