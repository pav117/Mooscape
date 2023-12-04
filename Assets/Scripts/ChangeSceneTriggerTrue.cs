using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeSceneTriggerTrue : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;
    private bool byDoor;

    public Text BlockedMessage;

    GameObject[] Awakener;

    public AddTime addTime;

    void Update()
    {
        Awakener = GameObject.FindGameObjectsWithTag("Awakener");
        
        if (byDoor)
        {
            if (Awakener.Length == 1)
            {
                if (transitionInformation != null)
                {
                    currentTransitionManager.currentDoorTransition = transitionInformation;
                    currentTransitionManager.transiting = true;

                    GameObject addTimeGameObject = GameObject.FindGameObjectWithTag("TimeManager");
                    addTime = addTimeGameObject.GetComponent<AddTime>();
                    if (addTime != null)
                    {
                        addTime.score = addTime.score + 1;
                        print(addTime.score);
                    }

                    SceneManager.LoadScene(transitionInformation.targetSceneName);
                }
            }
            else if (Awakener.Length == 0)
            {
                BlockedMessage.gameObject.SetActive(true);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            byDoor = true;
        }
    }
}

