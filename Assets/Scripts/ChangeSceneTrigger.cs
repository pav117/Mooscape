using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;
    private bool byDoor;

    public AddTime addTime;

    void Update()
    {
        if (byDoor)
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
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            byDoor = true;
        }
    }
}
