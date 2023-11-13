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

    void Update()
    {
        if (byDoor)
        {
            if (transitionInformation != null)
            {
                currentTransitionManager.currentDoorTransition = transitionInformation;
                currentTransitionManager.transiting = true;

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
